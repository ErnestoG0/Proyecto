using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto
{
    internal class Conexion
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {

                //Declarar la cadena (objeto) de conexión al servidor   
                cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=Escuela;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            }
        }

      

        public string insertarAlumno(string AlumNombre, string AlumApellidoPat, string AlumApellidoMa, string Grdo, string Grpo, string AlumCURP)
        {


            string salida = "Se Registro a un alumno";
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.Registrar_ALumno", cn);

                //Indicar que sera Store Procedure

                cmd.CommandType = CommandType.StoredProcedure;

                //se limpian los parámetros 			
                cmd.Parameters.AddWithValue("@NombreA", AlumNombre);
                cmd.Parameters.AddWithValue("@ApellidoPA", AlumApellidoPat);
                cmd.Parameters.AddWithValue("@ApellidoMA", AlumApellidoMa);
                cmd.Parameters.AddWithValue("@Grdo", Grdo);
                cmd.Parameters.AddWithValue("@Grpo", Grpo);
                cmd.Parameters.AddWithValue("@AlumCURP", AlumCURP);
                cmd.Parameters.AddWithValue("@AlumnoActNac", "1"); 
                cmd.Parameters.AddWithValue("@CertPrimaria", "1");

                //Ejecutar la sentencia sql en el servidor
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string ModificarAlumno(string AlumNombre, string AlumApellidoPat, string AlumApellidoMa, string Grdo, string Grpo, string AlumCURP)
        {


            string salida = "Se modifico a un alumno";
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.Modificar_ALumno", cn);

                //Indicar que sera Store Procedure

                cmd.CommandType = CommandType.StoredProcedure;

                //se limpian los parámetros 			
                cmd.Parameters.AddWithValue("@NombreA", AlumNombre);
                cmd.Parameters.AddWithValue("@ApellidoPA", AlumApellidoPat);
                cmd.Parameters.AddWithValue("@ApellidoMA", AlumApellidoMa);
                cmd.Parameters.AddWithValue("@Grdo", Grdo);
                cmd.Parameters.AddWithValue("@Grpo", Grpo);
                cmd.Parameters.AddWithValue("@AlumCURP", AlumCURP);
                cmd.Parameters.AddWithValue("@AlumnoActNac", "1");
                cmd.Parameters.AddWithValue("@CertPrimaria", "1");

                //Ejecutar la sentencia sql en el servidor
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string bajaAlumno(string AlumCURP)
        {


            string salida = "Se Elimino a un alumno";
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.baja_alumno", cn);

                //Indicar que sera Store Procedure

                cmd.CommandType = CommandType.StoredProcedure;

                //se limpian los parámetros 			
               
                cmd.Parameters.AddWithValue("@AlumCURP", AlumCURP);
                

                //Ejecutar la sentencia sql en el servidor
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string consultaralumno(string Curp)
            
        {
            string salida = "";
            try
            {

                //Declarar la cadena (objeto) de conexión al servidor   
                cn = new SqlConnection("Data Source=localhost;Initial Catalog=Escuela;Integrated Security=True");
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
            cmd.Parameters.AddWithValue("@AlumCURP", Curp);
            SqlDataReader Registro = cmd.ExecuteReader();
            if (Registro.Read())
            {
                 return  salida = "Se modifico a un alumno";

            }


            return  salida = "0";
            
        }
        public string GenerarNomina(string ID, string Descripcion, string Monto, string Fecha, string IDNomina)
        {
            string salida = "Se registro una nomina";
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.Registrar_ALumno", cn);

                //Indicar que sera Store Procedure

                cmd.CommandType = CommandType.StoredProcedure;

                //se limpian los parámetros
                cmd.Parameters.AddWithValue("@AEID", ID);
                cmd.Parameters.AddWithValue("@DescripcionNom ", Descripcion);
                cmd.Parameters.AddWithValue("@MontoNomina ", Monto);
                cmd.Parameters.AddWithValue("@FechaEmitida", Fecha);
                cmd.Parameters.AddWithValue("@NominaID", IDNomina);
                //Ejecutar la sentencia sql en el servidor
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
    }
}
