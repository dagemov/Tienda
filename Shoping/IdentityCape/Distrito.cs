using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
     * IdDistrito varchar(6) not null,
	    Descripcion varchar(45) not null,
	    IdProvincia varchar(4) not null,
	    IdDepartamento varchar(2) not null,
     * 
     */
    public  class Distrito
    {
        public string IdDistrito { get; set; }
        public string DescriptionDistrito { get; set; }
        public Provincia IdProvincia { get; set; }
        public State IdState { get; set; }
    }
}
