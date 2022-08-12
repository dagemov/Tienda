using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
	/*
		 * IdProducto int primary key identity,
		Nombre varchar(500),
		Descripcion varchar(500),
		IdMarca int references Marca(IdMarca),
		IdCategoria int references Categoria(IdCategoria),
		Precio decimal(10,2) default 0,
		Stock int,
		RutaImagen varchar(200),
		NombreImagen varchar(100),
		Activo bit default 1,
     */
	public class Product
    {
		public int IdProduct { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public Brand IdBran { get; set; }
		public Category IdCategory { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public string PathImage { get; set; }
		public string NameImage { get; set; }


    }
}
