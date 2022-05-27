using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoIncripcion
{
    public partial class DatosdeInscripcion : Form
    {
        public DatosdeInscripcion()
        {
            InitializeComponent();
          
        }
        
        MySqlConnection mycon = new MySqlConnection("server=localhost;user id =root;password=EmilkarG97;database=admiescolar;sslmode=none");
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable dt;
        internal static string? txtBoxNombre,txtBoxApellidoPat,txtBoxApellidoMat;
        internal static int? numBoxGrado, numBoxGrupo;
        string sql, Alumid;
        int resulta;
        private void loadData()
        {
            try
            {
                sql = "Select AlumID,AlumNombre,AlumApellidoPat,AlumApellidoMa,Grdo,Grpo,AlumCURP,AlumActNac,CertPrimaria From alumnos ";
                mycon.Open();
                cmd = new MySqlCommand();
                cmd.Connection = mycon;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
                da.Dispose();
            }
        }
        private void GuardarDatos()
        {
            
            try
            {
                SubidadeArchivo subidadeArchivo = new SubidadeArchivo();
                sql = "Insert into alumnos(AlumNombre,AlumApellidoPat,AlumApellidoMa,Grdo,Grpo,AlumCURP,AlumActNac,CertPrimaria) values('" + txtNombre.Text + "','" + txtAPaterno.Text + "','" + txtAMaterno.Text + "','" + numGrado.Value.ToString() + "','" + numGrupo.Value.ToString() + "','" + "" + "','" + "" + "','" + ""  + "')";
                mycon.Open();
                cmd = new MySqlCommand();
                cmd.Connection = mycon;
                cmd.CommandText = sql;
                resulta = cmd.ExecuteNonQuery();
                if (resulta > 0)
                {
                    MessageBox.Show("Datos Guardados", "Guardado");
                }
                else
                {
                    MessageBox.Show("Fallo el Guardado", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();

            }
        }
        private void ActualizarDatos()
        {
            try
            {
                sql = "Update alumnos set AlumNombre='" + txtNombre.Text + "',AlumApellidoPat='" + txtAPaterno.Text + "',AlumApellidoMa='" + txtAMaterno.Text + "',Grdo='" + numGrado.Value.ToString() + "',Grpo='" + numGrupo.Value.ToString() + "',AlumCURP='" + "" + "',='" + "',CertPrimaria='" + "" + "'Where AlumID="+ Alumid;
                cmd = new MySqlCommand();
                cmd.Connection= mycon;
                cmd.CommandText= sql;
                resulta = cmd.ExecuteNonQuery();
                if (resulta > 0)
                {
                    MessageBox.Show("Datos Actualizado", "Actualizado");
                }
                else
                {
                    MessageBox.Show("Fallo la Actualizacion", "Error");
                }
            }catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
            }
        }
        private void EliminarDatos()
        {
            try
            {
                sql = "Delete From alumnos Where AlumID=" + Alumid;
                mycon.Open();
                cmd = new MySqlCommand();
                cmd.CommandText= sql;
                resulta= cmd.ExecuteNonQuery();
                if (resulta > 0)
                {
                    MessageBox.Show("Datos Eliminados", "Borrado");
                }
                else
                {
                    MessageBox.Show("Fallo la Eliminacion", "Error");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                mycon.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtBoxNombre = txtNombre.Text;
            txtBoxApellidoPat = txtAPaterno.Text;
            txtBoxApellidoMat = txtAMaterno.Text;
            numBoxGrado = ((int)numGrado.Value);
            numBoxGrupo = ((int)numGrupo.Value);
            using (PdfDocument document = new PdfDocument())
            {
                //Add a page to the document
                PdfPage page = document.Pages.Add();

                //Create PDF graphics for a page
                PdfGraphics graphics = page.Graphics;

                //Set the standard font
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
                PdfFont fontpeque = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                //Create informations Name 
                string txtInfo="El usuario debe realizar el pago para Continuar con la incripcion Escolar";
                string txtPago = "El pago a realizar es en la cuenta xxxxxxxxx-5025";
                // Create pen.
                PdfPen blackPen = new PdfPen(Color.Black, 3);

                // Create rectangle.
                Rectangle rect = new Rectangle(0, 0, 500, 300);

                //Draw the text
                graphics.DrawRectangle(blackPen, rect);
                graphics.DrawString(txtInfo, fontpeque, PdfBrushes.Black, new PointF(80, 30));
                graphics.DrawString(txtNombre.Text, font, PdfBrushes.Black, new PointF(150, 80));                
                graphics.DrawString(txtPago, fontpeque, PdfBrushes.Black, new PointF(130, 230));
                //Save the document
                document.Save("Pago de Incripcion.pdf");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void DatosdeInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void btnPantallaArchivos_Click(object sender, EventArgs e)
        {
            
            SubidadeArchivo subidadeArchivo = new SubidadeArchivo();
            subidadeArchivo.Show();
            
        }

        private void cbxReincripcion_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxReincripcion.Checked)
            {
                lblGrado.Show();
                lblGrupo.Show();
                numGrado.Show();
                numGrupo.Show();
                Point point = new Point();
                point.X = 305;
                point.Y = 270;
                btnGuardar.Location = point;
            }
            else
            {
                
                lblGrado.Hide();
                lblGrupo.Hide();
                numGrupo.Hide();
                numGrado.Hide();
                Point point = new();
                point.X = 300;
                point.Y = 355;
                btnGuardar.Location = point;
            }    
        }

        private void cbxReincripcion_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}