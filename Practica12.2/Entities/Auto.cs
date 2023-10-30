using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica12._2.Entities
{
    internal class Auto
    {
        public string Propietario { get; set; }
        public string Placas { get; set; }
        public DateTime Entrada { get; set; } = DateTime.Now;
        public DateTime Salida {  get; set; }
        public string HoraEntrada { get; set; }
        public string TiempoTranscurrido { get; set; }
        public double CostoEstacionamiento { get; set; }
        public Auto(string propietario, string placas)
        {
            Propietario = propietario;
            Placas = placas;
            HoraEntrada = Entrada.ToShortTimeString();
        }
    }
}
