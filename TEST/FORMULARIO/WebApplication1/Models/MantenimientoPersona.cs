using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class MantenimientoPersona
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["administracion"].ToString();
            con = new SqlConnection(constr);
        }


        public int Alta(Persona art)
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
                Persona art = new Persona
                {
                    Nombre = registros["Nombre"].ToString(),
                    Apellido = registros["Apellido"].ToString(),
                    Razon = registros["Razon"].ToString(),
                    Aplicale = registros["Aplicale"].ToString())
                };
            personas.Add(art);
            }
            con.Close();
            return personas;
        }


    }
}