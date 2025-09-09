using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    {
        private String remitente;
        private String mensaje;
        private String fecha;

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida : Si pagas antes de 3 días se le reducirá la sanción al 50%";
            fecha = "";
        }
        public AvisosTrafico(String remitente, String mensaje, String fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string getFecha()
        {
            throw new NotImplementedException();
        }

        public void mostrarAviso()
        {
            Console.WriteLine(String.Format("Mensaje : {0}  ha sido enviado por {1} el dia {2}",mensaje,remitente,fecha));
        }
    }
}
