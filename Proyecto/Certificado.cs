using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Certificado : Form
    {
        public Certificado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            if(txtCurp.Text == "MECL000709HSLNHSA6")
            {
                txtNombre.Text = "LUIS EMMANUEL";
                txtApellido.Text = "MENDOZA CHAVARIN";
                txtPromedio.Text = "7.61";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printCertificado = new PrintDocument();
            PrinterSettings ps= new PrinterSettings();
            printCertificado.PrinterSettings = ps;
            printCertificado.PrintPage += Imprimir;
            printCertificado.Print();

        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Verdana", 30, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Verdana", 16, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Verdana", 16, FontStyle.Bold, GraphicsUnit.Point);

            int y = 20;

            e.Graphics.DrawString("SISTEMA EDUCATIVO NACIONAL", font, Brushes.Black, new RectangleF(80, y += 40, 900, 50));
            e.Graphics.DrawString("-Secretaria de Educacion Publica y Cultura del Estado de Sinaloa ", font2, Brushes.Black, new RectangleF(0, y += 80, 900, 40));
            e.Graphics.DrawString("-Departamento de Registro y Certificacion Escolar ", font2, Brushes.Black, new RectangleF(0, y += 50, 900, 40));
            e.Graphics.DrawString("CERTIFICA QUE:", font2, Brushes.Black, new RectangleF(350, y += 80, 900, 40));
            e.Graphics.DrawString(txtNombre.Text + " " + txtApellido.Text, font3, Brushes.Black, new RectangleF(200, y += 50, 900, 40));
            e.Graphics.DrawString("-Con Clave Unica de Registro de Poblacion(CURP):", font2, Brushes.Black, new RectangleF(0, y += 80, 900, 40));
            e.Graphics.DrawString(txtCurp.Text, font3, Brushes.Black, new RectangleF(300, y += 40, 900, 40));
            e.Graphics.DrawString("-Acredito la Educacion:  Secundaria en el Periodo Escolar 2021-2022 ", font2, Brushes.Black, new RectangleF(0, y += 80, 900, 40));
            e.Graphics.DrawString("-Segun Constancias que Obran en el Archivo de Control Escolar.", font2, Brushes.Black, new RectangleF(0, y += 80, 900, 40));
            e.Graphics.DrawString("-Promedio de Aprovechamietno      ["+txtPromedio.Text+"]", font2, Brushes.Black, new RectangleF(0, y += 80, 900, 40));
            e.Graphics.DrawString("-EL Presente Documento de Certificacion Se Expide en:", font2, Brushes.Black, new RectangleF(0, y += 80, 900, 40));
            e.Graphics.DrawString("CULIACAN, SINALOA", font3, Brushes.Black, new RectangleF(300, y += 40, 900, 40));
            e.Graphics.DrawString("_______________________________", font2, Brushes.Black, new RectangleF(200, y +=120, 900, 40));
            e.Graphics.DrawString("Firma del Director del", font2, Brushes.Black, new RectangleF(300, y += 40, 900, 40));
            e.Graphics.DrawString("Instituto", font2, Brushes.Black, new RectangleF(350, y += 40, 900, 40));
        }
        
    }
}
