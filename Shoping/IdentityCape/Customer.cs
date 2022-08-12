using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCape
{
    /*
     * IdCliente int primary key identity,
	Nombres varchar(100),
	Apellidos varchar(100),
	Correo varchar(100),
	Clave varchar(150),
	Reestablecer bit default 0,
	FechaRegistro datetime default getDate()
     */
    public class Customer
    {
        public int IdCustomer{ get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Restablecer { get; set; }
    }
}
