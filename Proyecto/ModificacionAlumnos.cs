using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Proyecto
{
    public partial class ModificacionAlumnos : Form
    {
        public ModificacionAlumnos()
        {
            InitializeComponent();
            comboBox1.DropDownStyle= ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
        }
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Conexion c = new Conexion();

            
            //String cs = c.consultaralumno(textcurp.Text);
            //if (cs == "Se modifico a un alumno")
            //{
            //    SqlConnection cn;
            //    SqlCommand cmd;
            //    SqlDataReader dr;
            //    try
            //    {

            //        //Declarar la cadena (objeto) de conexión al servidor   
            //        cn = new SqlConnection("Data Source=localhost;Initial Catalog=AdmiEscolar;Integrated Security=True");
            //        cn.Open();
            //        //MessageBox.Show("Conectado");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            //    }
            //    SqlCommand cmd = new SqlCommand("dbo.Consulta_curp", cn);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    //se limpian los parámetros 			
            //    cmd.Parameters.AddWithValue("@AlumCURP", textcurp.Text);
            //    SqlDataReader Registro = cmd.ExecuteReader();
            //    if (Registro.Read())
            //    {
            //        textBox4.Text = Registro["AlumNombre"].ToString();
            //        textBox1.Text = Registro["AlumApellidoPat"].ToString();
            //        textBox2.Text = Registro["AlumApellidoMa"].ToString();
            //        comboBox1.Text = Registro["Grdo"].ToString();
            //        comboBox2.Text = Registro["Grpo"].ToString();
            //        textBox3.Text = Registro["AlumCURP"].ToString();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encontro ese CURP");
            //    }
            //}
            //try
            //{

            //    //Declarar la cadena (objeto) de conexión al servidor   
            //    cn = new SqlConnection("Data Source=localhost;Initial Catalog=AdmiEscolar;Integrated Security=True");
            //    cn.Open();
            //    //MessageBox.Show("Conectado");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            //}
            //SqlCommand cmd = new SqlCommand("dbo.Consulta_curp", cn);
            //cmd.CommandType = CommandType.StoredProcedure;

            ////se limpian los parámetros 			
            //cmd.Parameters.AddWithValue("@AlumCURP", textcurp.Text);
            //SqlDataReader Registro= cmd.ExecuteReader();
            //if (Registro.Read())
            //{
            //   textBox4.Text=Registro["AlumNombre"].ToString();
            //   textBox1.Text=Registro["AlumApellidoPat"].ToString();
            //   textBox2.Text = Registro["AlumApellidoMa"].ToString();
            //    comboBox1.Text = Registro["Grdo"].ToString();
            //    comboBox2.Text = Registro["Grpo"].ToString();
            //    textBox3.Text = Registro["AlumCURP"].ToString();
                
            //}
            //else
            //{
            //    MessageBox.Show("No se encontro ese CURP");
            //}
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true)
                textBox1.ReadOnly = false;
            else
                textBox1.ReadOnly = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.ReadOnly == true)
                textBox2.ReadOnly = false;
            else
                textBox2.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.ReadOnly == true)
                textBox4.ReadOnly = false;
            else
                textBox4.ReadOnly = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Enabled == false)
                comboBox1.Enabled = true;
            else
                comboBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.ReadOnly == true)
                textBox3.ReadOnly = false;
            else
                textBox3.ReadOnly = true;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox2.Enabled == false)
                comboBox2.Enabled = true;
            else
                comboBox2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            Conexion cx = new Conexion();
            String cs = cx.consultaralumno(textBox3.Text);
            if (cs == "Se modifico a un alumno")
            {

                MessageBox.Show(c.ModificarAlumno(textBox4.Text, textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, textBox3.Text));
            }
            else
                MessageBox.Show("El curp que trata de modificar no existe");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                //Declarar la cadena (objeto) de conexión al servidor   
                cn = new SqlConnection("Data Source=localhost;Initial Catalog=AdmiEscolar;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            }
            SqlCommand cmd = new SqlCommand("dbo.Consulta_curp", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            //se limpian los parámetros 			
            cmd.Parameters.AddWithValue("@AlumCURP", textcurp.Text);
            SqlDataReader Registro = cmd.ExecuteReader();
            if (Registro.Read())
            {
                textBox4.Text = Registro["AlumNombre"].ToString();
                textBox1.Text = Registro["AlumApellidoPat"].ToString();
                textBox2.Text = Registro["AlumApellidoMa"].ToString();
                comboBox1.Text = Registro["Grdo"].ToString();
                comboBox2.Text = Registro["Grpo"].ToString();
                textBox3.Text = Registro["AlumCURP"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro ese CURP");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu=new Menu();
            menu.Show();
            this.Close();
        }
    }
}
