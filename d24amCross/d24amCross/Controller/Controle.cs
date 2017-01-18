﻿using d24amCross.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Acr.UserDialogs;

namespace d24amCross.Controller
{
    public class Controle
    {
        /// <summary>
        /// Função que exite uma mensagem para o usuário.
        /// </summary>
        /// <param name="msg"></param>
        public void MensagemInfo( string msg )
        {
            App.Current.MainPage.DisplayAlert( "Tuto Inteligente Informa: ", msg, "Ok" );
        }

        public async Task<ObservableCollection<ItemRss>> BaixarFeed( string url )
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add( "User-Agent", "Other" );

           
                var response = await client.GetAsync( url );
                var content = await response.Content.ReadAsStringAsync();


                XElement xmlitems = XElement.Parse( content );

                List<XElement> elements = xmlitems.Descendants( "item" ).ToList();

                var aux = new ObservableCollection<ItemRss>();

                foreach ( XElement rssItem in elements )
                {
                    var rss = new ItemRss();

                    rss.Descricao = rssItem.Element( "description" ).Value;
                    rss.Link = rssItem.Element( "link" ).Value;
                    rss.Titulo = rssItem.Element( "title" ).Value;
                    string url2 = rssItem.Element( "enclosure" ) != null ? rssItem.Element( "enclosure" ).ToString() : "empty";

                    var reg = new Regex( "url=(?:\"|\')?(?<imgSrc>[^>]*[^/].(?:jpg|bmp|gif|png))(?:\"|\')?" );

                    var match = reg.Match( url2 );

                    if ( match.Success )
                    {
                        var encod = match.Groups["imgSrc"].Value;

                        rss.Imagem = encod;
                    }
                    else
                    {
                        if ( Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows )
                        {
                            rss.Imagem = "/d24amLogo.jpg";
                        }
                        else
                        {
                            rss.Imagem = "d24amLogo.jpg";
                        }
                    }

                    aux.Add( rss );
                }
            return aux;
        }
    }
}