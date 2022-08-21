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
        public int Register(User obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (string.IsNullOrEmpty(obj.Nombres) || string.IsNullOrWhiteSpace(obj.Nombres))
            {
                Mensaje = "The name not can't empy";
            }
            else if (string.IsNullOrEmpty(obj.Apellidos) || string.IsNullOrWhiteSpace(obj.Apellidos))
            {
                Mensaje = "The last name not can't empy";
            }
            else if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje = "The email not can't empy";
            }


            if (string.IsNullOrEmpty(Mensaje))
            {

                string clave = "test123";
                obj.Clave = CN_Recursos.ConvertirSha256(clave);
                return _users.Register(obj, out Mensaje);
                //string asunto = "Creacion de Cuenta";
               // string mensaje_correo = "<h3>Su cuenta fue creada correctamente</h3></br><p>Your password acces  is: !clave!</p>";
                //mensaje_correo = mensaje_correo.Replace("!clave!", clave);
                
                /*
               // bool respuesta = CN_Recursos.EnviarCorreo(obj.Correo, asunto, mensaje_correo);

                if (respuesta)
                {

                    obj.Clave = CN_Recursos.ConvertirSha256(clave);
                    return objCapaDato.Registrar(obj, out Mensaje);
                }
                else
                {
                    Mensaje = "No se puede enviar el correo";
                    return 0;
                }

                */
            }
            else
            {

                return 0;
            }



        }

        public bool Edit(User obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.Nombres) || string.IsNullOrWhiteSpace(obj.Nombres))
            {
                Mensaje = "El nombre del usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Apellidos) || string.IsNullOrWhiteSpace(obj.Apellidos))
            {
                Mensaje = "El apellido del usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje = "El correo del usuario no puede ser vacio";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {

                return _users.Edit(obj, out Mensaje);
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id, out string Mensaje)
        {
            return _users.Delete(id, out Mensaje);
        }
    }
}
