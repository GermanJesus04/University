using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.EntidadesConf
{
    public class JWTSettings
    {
        //nos va a servir para comprobar la firme de nuestros usuarios
        public bool ValidarLlaveFirmaDelEmisor { get; set; }
        public string LlaveFirmaDelEmisor { get; set; } = string.Empty;

        public bool ValidarEmisor { get; set; }
        public string Emisor { get; set; } = string.Empty;

        public bool ValidarAudiencia { get; set; }
        public string AudienciaValida { get; set; } = string.Empty;

        public bool TiempoDeExpiracion { get; set; }
        public bool ValidarTiempoDeVida { get; set; }
    }
}
