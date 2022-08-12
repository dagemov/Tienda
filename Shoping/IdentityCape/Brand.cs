using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
     * IdMarca int primary key identity,
	Descripcion varchar(100),
	Activo bit default 1,
     */
    public class Brand
    {
        public int IdBrand { get; set; }
        public string DescriptionBrand { get; set; }
        public bool BrandActive { get; set; }
    }
}
