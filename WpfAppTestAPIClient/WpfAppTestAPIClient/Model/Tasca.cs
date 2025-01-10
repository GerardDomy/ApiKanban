using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestAPIClient.Model
{
    public class Tasca
    {
        public string Nom { get; set; }
        public string Descripcio { get; set; }
        public string Autor { get; set; }
        public DateTime DataInici { get; set; }
        public DateTime DataFinal { get; set; }
        public string Estat {  get; set; }
        public string Background { get; set; }
    }

}
