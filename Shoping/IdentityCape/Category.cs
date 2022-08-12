using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
         * IdCategoria int primary key identity,
	    Descripcion varchar(100),
	    Activo bit default 1,
	    FechaRegistro dateTime Default getDate()
     */
    public class Category
    {
        public int IdCategory{ get; set; }
        public string DescriptionCategory{ get; set; }

        public bool Active { get; set; }
    }
}

