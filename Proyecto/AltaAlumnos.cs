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
    public partial class AltaAlumnos : Form
    {
        public AltaAlumnos()
        {
            InitializeComponent();
            cmbgrado.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbgrado.Items.Add("1");
            cmbgrado.Items.Add("2");
            cmbgrado.Items.Add("3");
            cmbgrupo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbgrupo.Items.Add("1");
            cmbgrupo.Items.Add("2");
            cmbgrupo.Items.Add("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            if (textnombre.Text != "" && textapellidopa.Text != "" && textmaterno.Text != "" && cmbgrado.Text != "" && cmbgrupo.Text != "" && textcurp.Text != "" )
            {
                MessageBox.Show(c.insertarAlumno(textnombre.Text, textapellidopa.Text, textmaterno.Text, cmbgrado.Text, cmbgrupo.Text, textcurp.Text));
            }
            else
            {
                MessageBox.Show("Rellene todo los campos");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
