using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionesBL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<contexto>
    {
        protected override void Seed(contexto context)
        {

             base.Seed(context);
        }
    }
}
