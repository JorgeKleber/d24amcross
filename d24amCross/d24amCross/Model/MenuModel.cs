using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d24amCross.Model
{
    public enum MenuIndex
    {
        Home,
        Eportes,
        Plus,
        Amazonia,
        Sobre
    }

    public class MenuModel
    {
        public string Opcao { get; set; }
        public string IconeSrc { get; set; }
        public MenuIndex IndexItem { get; set; }
        public string Background { get; set; }
    }
}
