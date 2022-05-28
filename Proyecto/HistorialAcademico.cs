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
    public partial class HistorialAcademico : Form
    {
        public HistorialAcademico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no hace nada :)
        }

        private void btn_buscarh_Click(object sender, EventArgs e)
        {
            //aqui va el codigo, pero no lo he hecho :P
        }

        private void btn_buscarh_Click_1(object sender, EventArgs e)
        {
            //este es el bueno...
            //creo
        }

        private void txt_curph_TextChanged(object sender, EventArgs e)
        {
            //esta es la textbox :v
        }

        private void pb_RegresarMenu_Click(object sender, EventArgs e)
        {
            Menu menu=new Menu();
            menu.Show();
            this.Close();
        }

        private void dataGridHA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
