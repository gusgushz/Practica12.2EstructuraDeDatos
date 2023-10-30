using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica12._2.Entities
{
    internal class Estacionamiento
    {
        public Queue<Auto> Autos = new();
        int CostoPorSegundo = 2; //Pesos

        public Auto AgregarAutos(string propietario, string placas)
        {
            Auto agregado = new(propietario, placas);
            Autos.Enqueue(agregado);
            return agregado;
        }
        public Auto SacarAutos()
        {
            DateTime Salida = DateTime.Now;
            Auto sacado = Autos.Dequeue();
            TimeSpan SegundosTranscurridos = segundosTranscurrido(Salida);
            double segundos = SegundosTranscurridos.TotalSeconds;
            string segsTrasncurridos = SegundosTranscurridos.TotalSeconds.ToString("000.0");
            double PorPagar = segundos * CostoPorSegundo;
            sacado.CostoEstacionamiento = Math.Round(PorPagar,2);
            sacado.TiempoTranscurrido = segsTrasncurridos;
            return sacado;
        }
        TimeSpan segundosTranscurrido(DateTime salida)
        {
            TimeSpan resultado;
            resultado = salida - Autos.Peek().Entrada;
            return resultado;
        }

    }
}
