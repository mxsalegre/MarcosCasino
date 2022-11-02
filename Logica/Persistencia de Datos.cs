using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Logica; 

namespace Logica
{
    public class persistenciaDeDatos
    {
        readonly string RutaListaClientes = @"C:\Users\marco\OneDrive\Escritorio\jijija\Casino Marcos\archivo_listas\ListaCliente.txt";
        readonly string RutaListaEmpleado = @"C:\Users\marco\OneDrive\Escritorio\jijija\Casino Marcos\archivo_listas\ListaEmpleado.txt";
        readonly string RutaListaJuego = @"C:\Users\marco\OneDrive\Escritorio\jijija\Casino Marcos\archivo_listas\ListaJuego.txt";

        public void InicializarArchivo()
        {
            if (!File.Exists(RutaListaClientes))
            {
                File.Create(RutaListaClientes).Close();
            }

            if (!File.Exists(RutaListaJuego))
            {
                File.Create(RutaListaJuego).Close();
            }
            if (!File.Exists(RutaListaEmpleado))
            {
                File.Create(RutaListaEmpleado).Close();
            }
        }

        public List<cliente> LeerArchivoCliente()
        {
            string locationFile = RutaListaClientes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<cliente> ListaClientes = JsonConvert.DeserializeObject<List<cliente>>(content);
                return ListaClientes;
            }
        }
        public List<juego> LeerArchivoJuego()
        {
            string locationFile = RutaListaClientes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<juego> ListaJuego = JsonConvert.DeserializeObject<List<juego>>(content);
                return ListaJuego ;
            }
        }

        public List<empleado> LeerArchivoEmpleado()
        {
            string locationFile = RutaListaEmpleado;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<empleado> ListaEmpleado = JsonConvert.DeserializeObject<List<empleado>>(content);
                return ListaEmpleado;
            }
        }

        public void GuardarArchivoCliente(List<cliente> ListaClientes)
        {
            string locationFile = RutaListaClientes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaClientes);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoEmpleado(List<empleado> ListaEmpleado)
        {
            string locationFile = RutaListaEmpleado;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaEmpleado);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoJuego(List<juego> ListaJuego)
        {
            string locationFile = RutaListaEmpleado;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaJuego);
                writer.Write(jsonContent);
            }
        }
    }
}
