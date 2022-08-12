using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
     * IdDetalleVenta int primary key identity,
	    IdVenta int references VENTA(IdVenta),
	    IdProducto int references PRODUCTO(IdProducto),
	    Cantidad int,
	    total decimal(10,2) 
     */
    public class SaleDetails
    {
        public int IdSaleDetails { get; set; }
        public Sale IdSale { get; set; }
        public Product IdProduct { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
    }
}
