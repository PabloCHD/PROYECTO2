using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionesBL
{
    public class contexto:DbContext 
    {
        public contexto():base("Hotel")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());//Agrega datos de inicio a la base de datos despues de eliminar la base de datos
        }
        public DbSet<Reservacion> Reservaciones { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public static object Usuarios { get; internal set; }
    }
}
