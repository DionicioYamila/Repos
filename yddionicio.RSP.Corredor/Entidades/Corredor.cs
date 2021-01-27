using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        public enum Carril { Carril_1 , Carril_2 }
        protected static Random protegidoAvance;
        protected Carril carrilElegido;
        private short velocidadMax;

        public Carril CarrilElegido
        {
            get
            {
                return this.carrilElegido;
            }
        }

        public short VelocidadMaxima
        {
            get
            {
                return this.velocidadMax;
            }
            set
            {
                if (value >= 10)
                {
                    this.velocidadMax = value;
                }
                
            }
        }

        static Corredor()
        {
            protegidoAvance = new Random();
        }
        protected Corredor(short velocidadMax, Carril carril)
        {
            this.velocidadMax = velocidadMax;
            this.carrilElegido = carril;
        }

        public abstract void Correr();

        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }
        



    }
}
