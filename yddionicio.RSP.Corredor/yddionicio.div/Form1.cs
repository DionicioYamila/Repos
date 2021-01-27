using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.Persona;

namespace yddionicio.div
{
    public partial class frmRsp : Form
    {
        private List<Persona> corredores;
        private List<Thread> corredoresActivos;
        private bool hayGanador;
        public frmRsp()
        {
            InitializeComponent();
            this.corredores = new List<Persona>();
            this.corredoresActivos = new List<Thread>();
            this.corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this.corredores.Add(new Persona("Fernando", 15, Corredor.Carril.Carril_2));
            this.hayGanador = false;

            this.corredoresActivos.Add(new Thread(corredores[0].Correr));
            this.corredoresActivos.Add(new Thread(corredores[1].Correr));

            corredores[0].Corriendo += PersonaCorriendo;
            corredores[1].Corriendo += PersonaCorriendo;
        }

        private void frmRsp_Load(object sender, EventArgs e)
        {
        }

        private void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }

        private void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallBack d = new CorrenCallBack(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });

            }
            else
            {
                AnalizarCarrera(corredor.CarrilElegido == Corredor.Carril.Carril_1 ? pgbCarril1 : pgbCarril2, avance, corredor);
            }
        }

        private void HayGanador(Corredor corredor)
        {
            foreach (Thread aux in corredoresActivos)
            {
                if (aux.IsAlive)
                {
                    aux.Abort();
                }
            }
            corredor.Guardar("CorredorGanador.txt");
            MessageBox.Show(corredor.ToString());
            this.LimpiarCarriles();
        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            if (carril.Value + avance > carril.Maximum)
            {
                carril.Value = carril.Maximum;
                this.HayGanador(corredor);
            }
            else
            {
                carril.Value += avance;
            }
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            foreach (Thread aux in corredoresActivos)
            {
                aux.Start();
            }
        }

        //protected void Dispose(bool disposing)
        //{

        //}

    }
}
