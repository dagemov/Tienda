using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DatesCapa
{
    public class Connection
    {
        //This a chain in web config for start connection whit dataBase
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
