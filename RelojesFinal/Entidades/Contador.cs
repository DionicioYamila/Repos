using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contador
    {
        private DateTime inicio;
        private Relojes.Reloj reloj;
        private Theard timer;

        public void delegate EventoReloj(Relojes.Reloj j, string tiempo);
         
        public Theard Hilo 
        {
            get { return this.timer; }
        }


        public Contador(Relojes.Reloj reloj, IEvento imprimir) 
        {
        }

        public void EjecutarTimer() 
        {
        }



    }
}
