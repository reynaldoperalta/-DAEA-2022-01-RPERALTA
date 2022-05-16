using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class clsNegPerson
    {
        clsDAOPerson daoPerson = new clsDAOPerson();

        public DataTable GetAll()
        {
            return daoPerson.GeAll();
        }

        public DataTable GetUsuario(int id)
        {
            return daoPerson.GetUsuario(id);
        }

    }
}
