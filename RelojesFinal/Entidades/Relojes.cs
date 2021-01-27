using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Relojes: IEvento
    {
        public enum Reloj {Primero, Segundo, Tercero}
        private int cantidad;
        private Dictionary<Reloj, Contador> hilos;
        private IEvento referencia;


        private Relojes()
        {

        }
        public Relojes(int cantidad, IEvento referencia)
        {

        }

        public Relojes CargarReloj(Reloj item)
        {

        }

        public void KillEmAll()
        { 
        }

        public void ImprimirReloj(Reloj reloj, string dato)
        {
            throw new NotImplementedException();
        }

        public static Relojes operator -( Relojes reloj, Reloj item) 
        {
        }
        public static Relojes operator +( Relojes reloj, Reloj item) 
        {
        }

            



    }
}
