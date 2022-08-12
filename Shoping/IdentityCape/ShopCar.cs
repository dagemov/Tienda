using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
     * IdCarrito int primary key identity,
	IdCliente int references CLIENTE(IdCliente),
	IdProductor int references PRODUCTO(IdProducto),
	Cantidad int
     */
    public class ShopCar
    {
        public int IdShopCar { get; set; }
        public Customer IdCustomer { get; set; }
        public Product IdProduct { get; set; }
        public int Amount { get; set; }
    }
}
