using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespace para la conexion a la base de datos
using System.Data;
using System.Data.SqlClient;

namespace Examen___Luis_Dario.Clases
{
    class Conexion
    {
        // Propiedades 

        private string servidor;
        private string baseDatos;
        public SqlConnection conectar;
        public SqlCommand cmd;

        // Contructor
        public Conexion() { }

        /// <summary>
        ///  Funcion que se encarga de contiene las propiedades de la conexion a la base de datos
        /// </summary>
        /// <param name="Servidor"> nombre del servidor de la base de datos</param>
        /// <param name="BaseDatos"> nombre de la base de datos</param>
        public Conexion(string Servidor, string BaseDatos)
        {
            servidor = Servidor;
            baseDatos = BaseDatos;
            RealizarConexion();
        }


        /// <summary>
        /// Funcion que se encarga de realizar la conexion a la base de datos
        /// </summary>
        public void RealizarConexion()
        {
            try
            {
                conectar = new SqlConnection(@"server = " + servidor + "integrated security = true; database = " + baseDatos);

                // Abrir conecxion
                conectar.Open();
            }
            catch (Exception)
            {

                throw new Exception("Servidor o base de datos no encontrados");
            }
        }


        /// <summary>
        /// Funcion que permite realizar un comando QUERY SQL
        /// </summary>
        /// <param name="ejecutarComando"> Valor que ejecuta el comando</param>
        /// <returns> Retorna la ejecucion de un query SQL</returns>

        public SqlCommand EjecutarComando(string ejecutarComando)
        {
            return cmd = new SqlCommand(ejecutarComando, conectar);
        }

        /// <summary>
        /// Funcion que cierra la conecion a la base de datos
        /// </summary>
        public void CerrarConexion()
        {
            conectar.Close();
        }
    }
}
