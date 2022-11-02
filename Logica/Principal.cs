using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Logica
{
    public class principal
    {
        List<cliente> ListaCliente = new List<cliente>();
        List<juego> ListaJuego = new List<juego>();
        List<empleado> ListaEmpleado = new List<empleado>();


        //ABM Cliente
        public void AltaCliente(persona personaNueva, int idCliente)
        {
            ListaCliente = ValidarCliente();

            cliente nuevoCliente = new cliente();
            nuevoCliente.idClientes = idCliente;
            nuevoCliente.dni = personaNueva.dni;
            nuevoCliente.nombre = personaNueva.nombre;
            nuevoCliente.apellido = personaNueva.apellido;
            nuevoCliente.direccion = personaNueva.direccion;
            nuevoCliente.telefono = personaNueva.telefono;
            ListaCliente.Add(nuevoCliente);
            InstanciapersistenciaDeDatos.GuardarArchivoCliente(ListaCliente);
        }
        public void ModificarCliente(cliente modificarcliente, int idCliente)
        {
            ListaCliente = ValidarCliente();
            var ClienteModificado = ListaCliente.Find(x => idCliente == x.idClientes);
            ClienteModificado.idClientes = idCliente;
            ClienteModificado.nombre = modificarcliente.nombre;
            ClienteModificado.apellido = modificarcliente.apellido;
            ClienteModificado.dni = modificarcliente.dni;
            ClienteModificado.direccion = modificarcliente.direccion;
            ClienteModificado.telefono = modificarcliente.telefono;
            var ClienteEliminado = ListaCliente.Find(x => idCliente == x.idClientes);
            ListaCliente.Remove(ClienteModificado);
            ListaCliente.Add(ClienteModificado);
            InstanciapersistenciaDeDatos.GuardarArchivoCliente(ListaCliente);
              

        }
        public void BajaCliente(int idCliente)
        {
            ListaCliente = ValidarCliente();
            var clienteEliminado = ListaCliente.Find(x => idCliente == x.idClientes);
            ListaCliente.Remove(clienteEliminado);
            InstanciapersistenciaDeDatos.GuardarArchivoCliente(ListaCliente);

        }
        //ABM Juego
        public void AltaJuego(juego juegoNuevo, int idjuego)
        {
            juego nuevoJuego = new juego();
            nuevoJuego.cantidad = juegoNuevo.cantidad;
            nuevoJuego.descripcion = juegoNuevo.descripcion;
            nuevoJuego.tipo = juegoNuevo.tipo;
            nuevoJuego.IdJuego = idjuego;
            ListaJuego.Add(nuevoJuego);
            InstanciapersistenciaDeDatos.GuardarArchivoJuego(ListaJuego);
        }

        public void Modificarjuego(juego nuevoJuego, int IdJuego)
        {
            var JuegoModificado = ListaJuego.Find(x => IdJuego == x.IdJuego);


            JuegoModificado.cantidad = nuevoJuego.cantidad;
            JuegoModificado.descripcion = nuevoJuego.descripcion;
            JuegoModificado.tipo = nuevoJuego.tipo;
            JuegoModificado.IdJuego = IdJuego;

            var juegoEliminado = ListaJuego.Find(x => IdJuego == x.IdJuego);
            ListaJuego.Remove(juegoEliminado);
            ListaJuego.Add(JuegoModificado);
            InstanciapersistenciaDeDatos.GuardarArchivoJuego(ListaJuego);
        }
        //ABM Empleado
        public void AltaEmpleado(empleado empleadoNuevo, int idEmpleado)
        {
            ListaEmpleado = ValidarEmpleado();

            empleado nuevoEmpleado = new empleado();
            nuevoEmpleado.idEmpleados = idEmpleado;
            nuevoEmpleado.dni = empleadoNuevo.dni;
            nuevoEmpleado.nombre = empleadoNuevo.nombre;
            nuevoEmpleado.apellido = empleadoNuevo.apellido;
            nuevoEmpleado.direccion = empleadoNuevo.direccion;
            nuevoEmpleado.telefono = empleadoNuevo.telefono;
            ListaEmpleado.Add(nuevoEmpleado);
            InstanciapersistenciaDeDatos.GuardarArchivoEmpleado(ListaEmpleado);
        }
        public void ModificarEmpleado(empleado modificarEmpleado, int idEmpleado)
        {
            var empleadoModificado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleados);

            empleadoModificado.dni = modificarEmpleado.dni;
            empleadoModificado.nombre = modificarEmpleado.nombre;
            empleadoModificado.apellido = modificarEmpleado.apellido;
            empleadoModificado.direccion = modificarEmpleado.direccion;
            empleadoModificado.idEmpleados = idEmpleado;

            var empleadoEliminado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleados);
            ListaEmpleado.Remove(empleadoEliminado);
            ListaEmpleado.Add(empleadoModificado);
            InstanciapersistenciaDeDatos.GuardarArchivoEmpleado(ListaEmpleado);
        }
        public void BajaEmpleado(int idEmpleado)
        {
            ListaEmpleado = ValidarEmpleado();
            var empleadoEliminado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleados);
            ListaEmpleado.Remove(empleadoEliminado);
            InstanciapersistenciaDeDatos.GuardarArchivoEmpleado(ListaEmpleado);

        }

        persistenciaDeDatos InstanciapersistenciaDeDatos = new persistenciaDeDatos();
        public void RellenarLista()
        {
            ListaCliente= InstanciapersistenciaDeDatos.LeerArchivoCliente();
            ListaEmpleado = InstanciapersistenciaDeDatos.LeerArchivoEmpleado();
            ListaJuego = InstanciapersistenciaDeDatos.LeerArchivoJuego();

        }
        public List<cliente> ValidarCliente()
        {
            ListaCliente = InstanciapersistenciaDeDatos.LeerArchivoCliente();
            if (ListaCliente == null)
            {
                List<cliente> NuevaListaCliente = new List<cliente>();
                return NuevaListaCliente;
            }
            else
            {
                return ListaCliente;
            }
        }
        public List<empleado> ValidarEmpleado()
        {
            ListaEmpleado = InstanciapersistenciaDeDatos.LeerArchivoEmpleado();
            if (ListaEmpleado == null)
            {
                List<empleado> NuevaListaEmpleado = new List<empleado>();
                return NuevaListaEmpleado;
                // ListaEmpleados = new List<empleados>();
            }
            else
            { 
                return ListaEmpleado;

            }

        }
    }
}