using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Aysa14.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public int Total { get; set; }
        public string Vendedor { get; set; }
    }
}