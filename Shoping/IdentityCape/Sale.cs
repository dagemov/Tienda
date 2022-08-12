using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
	/*
     * IdVenta int primary key identity,
		IdCliente int references CLIENTE(IdCliente),
		TotalProducto int,
		MontoTotal decimal (10,2),
		Contacto varchar(50),
		IdDistrito varchar (10),
		Telefono varchar(50),
		Direccion varchar(500),
		IdTransaccion varchar(50),
		FechaVenta datetime default getDate()
     */
	public class Sale
    {
		public int IdSale { get; set; }
		public Customer IdCustomer { get; set; }
		public int TotalProduct { get; set; }
		public decimal MontoTotal { get; set; }
		public string Contact { get; set; }
		public Distrito IdDistrtio { get; set; }
		public string PhoneNumer { get; set; }
		public string Direccion { get; set; }
		public List<SaleDetails> SaleDetails { get; set; }
    }
}
