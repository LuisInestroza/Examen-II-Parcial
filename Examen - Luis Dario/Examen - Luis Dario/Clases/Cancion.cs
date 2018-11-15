using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces para la conexion a la base de datos
using System.Data;
using System.Data.SqlClient;

namespace Examen___Luis_Dario.Clases
{
    class Cancion
    {

        // Propiedades
        public int id { get; set; }
        public string nombre { get; set; }
        public int artista { get; set; }
        public int album { get; set; }
        public string genero { get; set; }
        public string añoCreacion { get; set; }


        /// <summary>
        /// Funcion que agrega una cancion a la tabla Canciones
        /// </summary>
        /// <param name="nombre"> nombre de la cancion</param>
        /// <param name="artista"> nombre del  artista</param>
        /// <param name="album"> nombre del album</param>
        /// <param name="genero"> genero de la cancion </param>
        /// <param name="añoCreacion"> año de publicacion de la cancion</param>
        /// <returns> Retorna una nueva cancion agregada a la base de datos</returns>
        public static Cancion AgregarCancion(string nombre, int artista, int album, string genero, string añoCreacion)
        {
            // Establecer la conexion
            Conexion conexion = new Conexion(@"local\(server)", "BulletProofRecords");

            string sql;

            Cancion agregar = new Cancion();

            // Quey insert SQL
            sql = @"INSERT INTO Music.Cancion(Nombre, Artista, Album, Genero, AñoCreacion) VALUES(@nombre, @artista, @album, @genero,  @año)";

            SqlCommand cmd = conexion.EjecutarComando(sql);

            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Remplazar los parametros de los campos
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 200).Value = nombre;
                    cmd.Parameters.Add("@artista", SqlDbType.Int).Value = artista;
                    cmd.Parameters.Add("@album", SqlDbType.Int).Value = album;
                    cmd.Parameters.Add("@genero", SqlDbType.NVarChar, 100).Value = genero;
                    cmd.Parameters.Add("@año", SqlDbType.NVarChar, 4).Value = añoCreacion;

                    // Ejecutar
                    rdr = cmd.ExecuteReader();
                }

                while(rdr.Read())
                {
                    agregar.id = rdr.GetInt16(0);
                    agregar.nombre = rdr.GetString(1);
                    agregar.artista = rdr.GetInt16(2);
                    agregar.album = rdr.GetInt16(3);
                    agregar.genero = rdr.GetString(4);
                    agregar.añoCreacion = rdr.GetString(5);

                }

                return agregar;
            }
            catch(SqlException exe)
            {
                return agregar;
            }
            finally
            {
                // Cerrar la conexion
                conexion.CerrarConexion();
            }

        }


        /// <summary>
        /// Funcion que elimina una cancion de la base de datos
        /// </summary>
        /// <param name="id"> identificador primario de la cancion</param>
        /// <returns> Retorna eliminado una cancion de la base de datos</returns>
        public static bool EliminarCancion(int id)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarCancion");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters["id"].Value = id;

            try
            {

                // ejercutar comando
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException exe)
            {

                return false;
            }
            finally
            {
                // Cerrar conexion
                conectar.CerrarConexion();
            }
        }


        /// <summary>
        /// Funcion que agrega una cancion a la tabla Canciones
        /// </summary>
        /// <param name="nombre"> nombre de la cancion</param>
        /// <param name="artista"> nombre del  artista</param>
        /// <param name="album"> nombre del album</param>
        /// <param name="genero"> genero de la cancion </param>
        /// <param name="añoCreacion"> año de publicacion de la cancion</param>
        /// <returns> Retorna listando las cancines de la base de datos</returns>
        public static Cancion ListarCanciones(string nombre, int artista, int album, string genero, string añoCreacion)
        {
            // Establecer la conexion
            Conexion conexion = new Conexion(@"local\(server)", "BulletProofRecords");

            string sql;

            Cancion listar = new Cancion();

            // Quey insert SQL
            sql = @"SELECT * FROM Music.Cancion ";

            SqlCommand cmd = conexion.EjecutarComando(sql);

            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Remplazar los parametros de los campos
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 200).Value = nombre;
                    cmd.Parameters.Add("@artista", SqlDbType.Int).Value = artista;
                    cmd.Parameters.Add("@album", SqlDbType.Int).Value = album;
                    cmd.Parameters.Add("@genero", SqlDbType.NVarChar, 100).Value = genero;
                    cmd.Parameters.Add("@año", SqlDbType.NVarChar, 4).Value = añoCreacion;

                    // Ejecutar
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    listar.id = rdr.GetInt16(0);
                    listar.nombre = rdr.GetString(1);
                    listar.artista = rdr.GetInt16(2);
                    listar.album = rdr.GetInt16(3);
                    listar.genero = rdr.GetString(4);
                    listar.añoCreacion = rdr.GetString(5);

                }

                return listar;
            }
            catch (SqlException exe)
            {
                return listar;
            }
            finally
            {
                // Cerrar la conexion
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Funcion que actualizar una cancion a la tabla Canciones
        /// </summary>
        /// <param name="nombre"> nombre de la cancion</param>
        /// <param name="artista"> nombre del  artista</param>
        /// <param name="album"> nombre del album</param>
        /// <param name="genero"> genero de la cancion </param>
        /// <param name="añoCreacion"> año de publicacion de la cancion</param>
        /// <returns> Retorna  cancion actulizada de la base de datos</returns>

        public static bool ActulizarrCancion(string nombre, int artista, int album, string genero, string año)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_ActualizarCancion");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros
            cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 200));
            cmd.Parameters["nombre"].Value = nombre;
            cmd.Parameters.Add(new SqlParameter("artista", SqlDbType.Int));
            cmd.Parameters["artista"].Value = artista;
            cmd.Parameters.Add(new SqlParameter("album", SqlDbType.Int));
            cmd.Parameters["album"].Value = album;
            cmd.Parameters.Add(new SqlParameter("genero", SqlDbType.NVarChar, 100));
            cmd.Parameters["genero"].Value = genero;
            cmd.Parameters.Add(new SqlParameter("año", SqlDbType.NVarChar, 200));
            cmd.Parameters["año"].Value = año;
          
            try
            {

                // ejercutar comando
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException exe)
            {

                return false;
            }
            finally
            {
                // Cerrar conexion
                conectar.CerrarConexion();
            }
        }

    }
}
