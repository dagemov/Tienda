using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityCape;
using System.Data.SqlClient;
using System.Data;
namespace DatesCapa
{
    public class CD_Users
    {
        public List<User> List()
        {

            List<User> List= new List<User>();
            try{
                //Select in c# Asi se hace un query desde  c# con un select
                // this using do open conecction
                using (SqlConnection connection= new SqlConnection(Connection.cn))
                {
                    
                    string query = "select IdUsuario,Nombres,Apellidos,Correo,Clave,Reestablecer,Activo from USUARIO";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();

                    //this using open Reader 
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            List.Add(
                                new User()
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    Nombres = dr["Nombres"].ToString(),
                                    Apellidos = dr["Apellidos"].ToString(),
                                    Correo = dr["Correo"].ToString(),
                                    Clave = dr["Clave"].ToString(),
                                    Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                }
                            ) ;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                List = new List<User>();
                Console.WriteLine("empy list"+ex);
               
            }

            return List;
        }
    }
}
