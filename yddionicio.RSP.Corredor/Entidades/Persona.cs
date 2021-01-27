using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Persona : Corredor
    {
        public delegate void CorrenCallBack(int ValoraAvance, Corredor corredor);
        public event CorrenCallBack Corriendo;

        public string nombre;

        public override void Guardar(string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(this.ToString());
                }

            }
            catch (Exception ex)
            {
                throw new NoSeGuardoExeception(ex);
            }
        }

        public Persona(string nombre, short velocidadMax, Carril carril) : base(velocidadMax, carril)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return string.Format("{0} en carril {1} a una velocidad máxima de {2}", this.nombre, this.carrilElegido, this.VelocidadMaxima);
        }

        public override void Correr()
        {
            for (; ;)
            {
                Corriendo.Invoke(protegidoAvance.Next(1, 10), this);
                System.Threading.Thread.Sleep(300);
            }

        }
    }
}
