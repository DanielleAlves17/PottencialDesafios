using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria )
        {
            Numero = numero;

            
        }
        public string Numero { get; set; }
        private string Modelo { get; set; }

        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string nome)
        {
            
        }




    }
}