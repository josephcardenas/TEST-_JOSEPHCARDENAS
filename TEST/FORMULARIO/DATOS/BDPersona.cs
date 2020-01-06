using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

using System.Configuration;
using System.Data;




namespace DATOS
{
    public static class BDPersona
    {
      
        public static int Agregar(Persona pPersona)
        {

            int i = 0;
            using (SqlConnection Conn = BDConexion.ObtenerConexion())

            
            {
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO Prueba (Nombre,Apellido,Razon,Aplicale) values ('{0}','{1}','{2}','{3}')",
               
                pPersona.Nombre,
                pPersona.Apellido,
                pPersona.Razon,
                pPersona.Aplicale,SqlDbType.Bit), Conn);

                

                

                int retorno;
                return retorno = Comando.ExecuteNonQuery();

            }
            



        }




    }
}
