using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WEB.Models
{
    public class MantenimientoPersona
    {

        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["administracion"].ToString();
            con = new SqlConnection(constr);
        }



        public int Alta(Persona per)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("insert into Prueba(Nombre,Apellido,Razon,Aplicale) values (@nombre,@apellido,@razon,@aplicale)", con);
            comando.Parameters.Add("@nombre", SqlDbType.VarChar);
            comando.Parameters.Add("@apellido", SqlDbType.VarChar);
            comando.Parameters.Add("@razon", SqlDbType.VarChar);
            comando.Parameters.Add("@aplicale", SqlDbType.VarChar);


            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }



        public List<Persona> RecuperarTodos()
        {
            Conectar();
            List<Persona> personas = new List<Persona>();

            SqlCommand com = new SqlCommand("select Nombre,Apellido,Razon,Aplicale from Prueba", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Persona per = new Persona
                {
                    Nombre = registros["Nomre"].ToString(),
                    Apellido = registros["Apellido"].ToString(),
                    Razon = registros["Razon"].ToString(),
                    Aplicale = registros["Aplicale"].ToString()
                };
            personas.Add(per);
            }
            con.Close();
            return personas;
        }


        public Persona Recuperar(string nombre)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("select  Nombre,Apellido,Razon,Aplicale from Prueba where Nombre=@nombre", con);
            comando.Parameters.Add("@nombre", SqlDbType.Text);
            comando.Parameters["@nombre"].Value = nombre;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Persona persona = new Persona();
            if (registros.Read())
            {
                persona.Apellido = registros["apellido"].ToString();
                persona.Razon = registros["razon"].ToString();
                persona.Aplicale = registros["aplicate"].ToString();
            }
            con.Close();
            return persona;
        }


  









    }
}