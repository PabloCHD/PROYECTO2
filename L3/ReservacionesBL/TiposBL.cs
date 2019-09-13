using ReservacionesBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionesBL
{
    public class Tipos
    {
        contexto _contexto;
      
        public BindingList<Tipo> ListaTipos { get; private set; }

        public Tipos()
        {
            _contexto = new contexto();
            ListaTipos = new BindingList<Tipo>();

        }

        public BindingList<Tipo> ObtenerTipos()
        {
            _contexto.Tipos.Load();
            ListaTipos = _contexto.Tipos.Local.ToBindingList();

            return ListaTipos;
        }
    }

    public class Tipo
    {
        public int Id { get; set; }
        public string DescripcionTipo { get; set; }
        public int Precio { get; set; }

    }
}
