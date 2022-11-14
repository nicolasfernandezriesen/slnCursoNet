using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Entidad.Practica1;

namespace WindowsApp.Entidad
{
    public class Remito : DcumentoComercial
    {
        public string Cliente { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
