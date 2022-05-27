using System.Collections;
using System.Data;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;


namespace ProcesoIncripcion
{
    public partial class SubidadeArchivo : Form
    {
        public SubidadeArchivo()
        {
            InitializeComponent();
            
        }
        MySqlConnection mycon = new MySqlConnection("server=localhost;user id =root;password=EmilkarG97;database=admiescolar;sslmode=none");
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable dt;
        string sql, Alumid;
        TextBox textBox ;
        int resulta;
        bool C1 = false, C2 = false, C3 = false, C4 = false, C5 = false;
    
        private void GuardarDatos()
        {

            try
            {
                
                sql = "Insert into alumnos(AlumNombre,AlumApellidoPat,AlumApellidoMa,Grdo,Grpo,AlumCURP,AlumActNac,CertPrimaria) values('" +  DatosdeInscripcion.txtBoxNombre + "','" + DatosdeInscripcion.txtBoxApellidoPat + "','" + DatosdeInscripcion.txtBoxApellidoMat + "','" + DatosdeInscripcion.numBoxGrado + "','" + DatosdeInscripcion.numBoxGrupo + "','" + SubidadeCurp  + "','" + SubidadeActa + "','" + CertificadoPrim + "')";
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

        private void btnPagoServicio_Click(object sender, EventArgs e)
        {

            
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            SubidaArchivos.InitialDirectory = "C:\\";
            // filtro de archivos.
            SubidaArchivos.Filter = "Archivos de texto (*.pdf)|*.pdf";

            // codigo para abrir el cuadro de dialogo
            if (SubidaArchivos.ShowDialog() == DialogResult.OK)
               
            {               
                try
                {
                    string str_SubidaArchivo = SubidaArchivos.FileName;
                  
                    txtPagoIncripcion.Text = str_SubidaArchivo;
                    txtPagoIncripcion.BackColor = System.Drawing.Color.Green; 
                    C1 = true;
                }
                catch (Exception)
                {
                    C2 = false;
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            SubidadeActa.InitialDirectory = "C:\\";
            // filtro de archivos.
            SubidadeActa.Filter = "Archivos de texto (*.pdf)|*.pdf";

            // codigo para abrir el cuadro de dialogo
            if (SubidadeActa.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = SubidadeActa.FileName;;
                    txtActa.BackColor = System.Drawing.Color.Green;
                    C2 = true;
                }
                catch (Exception)
                {
                    C2 = false;
                    throw;
                }
            }
        }

        private void btnCertificadoPrimaria_Click(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            CertificadoPrim.InitialDirectory = "C:\\";
            // filtro de archivos.
            CertificadoPrim.Filter = "Archivos de texto (*.pdf)|*.pdf";

            // codigo para abrir el cuadro de dialogo
            if (CertificadoPrim.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = CertificadoPrim.FileName;
                    txtCertificadoPrimaria.BackColor = System.Drawing.Color.Green;
                    C5 = true;
                }
                catch (Exception)
                {
                    C5 = false;
                    throw;
                }
            }
        }

        private void btnCurp_Click(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            SubidadeCurp.InitialDirectory = "C:\\";
            // filtro de archivos.
            SubidadeCurp.Filter = "Archivos de texto (*.pdf)|*.pdf";

            // codigo para abrir el cuadro de dialogo
            if (SubidadeCurp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = SubidadeCurp.FileName;
                    txtCurp.BackColor = System.Drawing.Color.Green;
                    C3 = true;
                }
                catch (Exception)
                {
                    C2 = false;
                    throw;
                }
            }
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            DocumentoDomilicio.InitialDirectory = "C:\\";
            // filtro de archivos.
            DocumentoDomilicio.Filter = "Archivos de texto (*.pdf)|*.pdf";

            // codigo para abrir el cuadro de dialogo
            if (DocumentoDomilicio.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string str_RutaArchivo = DocumentoDomilicio.FileName;                   
                    //txtPagoIncripcion.Text = str_RutaArchivo;
                    txtDomicilio.BackColor = System.Drawing.Color.Green;
                    C4= true; 
                }
                catch (Exception)
                {
                    C2 = false;
                    throw;
                }
            }
        }

        private void btnSubirDocumentos_Click(object sender, EventArgs e)
        {
            
            if (C1 && C2 && C3 && C4 && C5 == true)
            {
                GuardarDatos();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error Faltan Archivo a subir");
            }

            this.Close();
        }
    }
}
