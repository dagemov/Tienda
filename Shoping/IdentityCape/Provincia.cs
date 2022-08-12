using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
     * IdProvincia varchar(4),
	IdDepartamento varchar(2) not null,
	Descripcion varchar(45) not null,
     * 
     */
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public State IdState { get; set; }
        public string Description { get; set; }
    }
}
