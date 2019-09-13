using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionesBL
{
    public class SeguridadBL
    {
        public bool Autorizar(string Usuario, string pass)
        {
            if(Usuario == "Admin" && pass == "123")
            {
                return true;
            }

            else
            {
                if (Usuario == "Pablo" && pass == "456")
                {
                    return true;
                }

            }

            return false;
        }
    }

}
