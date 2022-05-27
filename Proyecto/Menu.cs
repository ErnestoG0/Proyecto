using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pb_Certificado_Click(object sender, EventArgs e)
        {
            Certificado certificado = new Certificado();
            certificado.Show();
            this.Close();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_HistorialAcademico_Click(object sender, EventArgs e)
        {
            HistorialAcademico historialAcademico = new HistorialAcademico();
            historialAcademico.Show();
            this.Close();
        }

        private void btnAltaBajaModificacion_Click(object sender, EventArgs e)
        {
            ModificacionAlumnos modificacionAlumnos = new ModificacionAlumnos();
            modificacionAlumnos.Show();
            this.Close();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            AltaAlumnos alta = new AltaAlumnos();
            alta.Show();
            this.Close();
        }
    }
}
