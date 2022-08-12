using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatesCapa;
using IdentityCape;
namespace BusinessCape
{
    public class CN_Users
    {
        private CD_Users _users=new CD_Users();

        public List<User> List()
        {

            return _users.List();
        }
    }
}
