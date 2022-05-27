using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class ProcesoNomina : Form
    {
        public ProcesoNomina()
        {
            InitializeComponent();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtMonto.Text == "" || txtFechaExp.Text == "")
            {
                MessageBox.Show("Porfavor Llene registro");
            }
            else
            {
                Conexion c = new Conexion();
                MessageBox.Show(c.GenerarNomina(txtIDEmpleado.Text,txtDescripcion.Text,txtMonto.Text,txtFechaExp.Text,txtIDNomina.Text)); // int IDNomina
                //Generar destino y formatos
                FileStream fs = new FileStream(@"\Downloads\Nomina PDF.pdf", FileMode.Create);
                Document doc = new Document(PageSize.A5, 5, 5, 5, 5);
                PdfWriter PW = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                doc.AddAuthor("Escuela secundaria tecnica");
                //definir formatos
                iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                doc.Add(new Paragraph("Nomina\nEscuela secundaria tecnica                Fecha de expedicion: " + txtFechaExp.Text + "\nDocumento: Solicitud de nomina"));
                doc.Add(Chunk.NEWLINE);
                //columnas
                PdfPTable tblEjemplo = new PdfPTable(4);
                //Configuracion de columnas
                //ID
                PdfPCell clID = new PdfPCell(new Phrase("ID del empleado", standarfont));
                clID.BorderWidth = 0;
                clID.BorderWidthBottom = 0.75f;
                //Nombre
                PdfPCell clNombre = new PdfPCell(new Phrase("ID del empleado", standarfont));
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.75f;
                //Descripcion
                PdfPCell clDescripcion = new PdfPCell(new Phrase("ID del empleado", standarfont));
                clDescripcion.BorderWidth = 0;
                clDescripcion.BorderWidthBottom = 0.75f;
                //Monto
                PdfPCell clMonto = new PdfPCell(new Phrase("ID del empleado", standarfont));
                clMonto.BorderWidth = 0;
                clMonto.BorderWidthBottom = 0.75f;
                //Agregarlo a la tabla
                tblEjemplo.AddCell(clID);
                tblEjemplo.AddCell(clNombre);
                tblEjemplo.AddCell(clDescripcion);
                tblEjemplo.AddCell(clMonto);
                //Agregar valores en la tabla
                clID = new PdfPCell(new Phrase(txtIDEmpleado.Text, standarfont));
                clID.BorderWidth = 0;
                clNombre = new PdfPCell(new Phrase(txtNombre.Text, standarfont));
                clNombre.BorderWidth = 0;
                clDescripcion = new PdfPCell(new Phrase(txtDescripcion.Text, standarfont));
                clDescripcion.BorderWidth = 0;
                clMonto = new PdfPCell(new Phrase(txtMonto.Text, standarfont));
                clMonto.BorderWidth = 0;
                tblEjemplo.AddCell(clID);
                tblEjemplo.AddCell(clNombre);
                tblEjemplo.AddCell(clDescripcion);
                tblEjemplo.AddCell(clMonto);

                doc.Add(tblEjemplo);
                doc.Close();
                PW.Close();
                MessageBox.Show("PDF generado con exito");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
