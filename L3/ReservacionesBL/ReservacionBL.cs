using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionesBL
{
    public class ReservacionBL
    {
        contexto _contexto;
        public BindingList<Reservacion> ListadeReservaciones { get; set; }

        public ReservacionBL()
        {
            _contexto = new contexto();
            ListadeReservaciones = new BindingList<Reservacion>();
           
        }

        public BindingList<Reservacion> ObtenerReservaciones()
                    {
            _contexto.Reservaciones.Load();
            ListadeReservaciones = _contexto.Reservaciones.Local.ToBindingList();
            return ListadeReservaciones;
        }
        
        //Clase para guardar una reservacion
        public Resultado GuardarReservacion(Reservacion reservacion)
        {
            var resultado = Validar(reservacion);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarReservacion()
        {
            var NuevaReservacion = new Reservacion();

            ListadeReservaciones.Add(NuevaReservacion);
        }

        //Funcion para eliminar un registro
        public bool EliminarReservacion(int id)
        {
            foreach (var reservacion in ListadeReservaciones)
            {
                if(reservacion.Id == id)
                {
                    ListadeReservaciones.Remove(reservacion);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Reservacion reservacion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(reservacion.Nombre)==true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(reservacion.Apellido) == true)
            {
                resultado.Mensaje = "Ingrese un apellido";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(reservacion.Correo) == true)
            {
                resultado.Mensaje = "Ingrese un correo";
                resultado.Exitoso = false;
            }

            if (reservacion.Telefono<0)
            {
                resultado.Mensaje = "Ingrese un telefono valido";
                resultado.Exitoso = false;
            }

            if (reservacion.NumerodePersonas < 0)
            {
                resultado.Mensaje = "Ingrese un valor valido";
                resultado.Exitoso = false;
            }

            if (reservacion.Precio < 0)
            {
                resultado.Mensaje = "Ingrese un precio valido";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Reservacion//Representa una entidad o una tabla en una base de datos
    {
        public int    Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int    Telefono { get; set; }
        public int    NumerodePersonas { get; set; }
        public string TipoHabitacion { get; set; }
        public byte[] Foto { get; set; }
        public double Precio { get; set; }
        public bool   Activo { get; set; }
        
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
