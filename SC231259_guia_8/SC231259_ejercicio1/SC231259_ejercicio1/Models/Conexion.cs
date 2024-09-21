using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace SC231259_ejercicio1.Models
{
    public class Conexion
    {
        private string cadenaConexion { get; set; }
        private SqlConnection conexionSQL;

        public Conexion()
        {
            // Cadena de conexión al SQL Server
            cadenaConexion = @"Data Source=ROLANFT\SQLEXPRESS;Initial Catalog=Bolsa_Trabajo;Integrated Security=True";
        }

        // Función para realizar conexión a la base de datos
        public void conectar()
        {
            if (conexionSQL == null)
                conexionSQL = new SqlConnection(cadenaConexion);

            if (conexionSQL.State == ConnectionState.Closed)
                conexionSQL.Open();
        }

        // Método para desconectar
        public void desconectar()
        {
            if (conexionSQL != null && conexionSQL.State != ConnectionState.Closed)
                conexionSQL.Close();
        }

        // Método que obtiene categorías
        public List<SelectListItem> getCategorias()
        {
            conectar();
            List<SelectListItem> items = new List<SelectListItem>();
            string query = "SELECT * FROM categorias ORDER BY sNombreCategoria";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                try
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = lector["sNombreCategoria"].ToString(),
                                Value = lector["nIdCategoria"].ToString()
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de error
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            return items;
        }

        // Método que obtiene localidades
        public List<SelectListItem> getLocalidades()
        {
            conectar();
            List<SelectListItem> items = new List<SelectListItem>();
            string query = "SELECT * FROM municipios ORDER BY sNombreMunicipio";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                try
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = lector["sNombreMunicipio"].ToString(),
                                Value = lector["nIdMunicipio"].ToString()
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            return items;
        }

        // Método que obtiene empresas
        public List<SelectListItem> getEmpresas()
        {
            conectar();
            List<SelectListItem> items = new List<SelectListItem>();
            string query = "SELECT * FROM empresas ORDER BY sNombreEmpresa";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                try
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = lector["sNombreEmpresa"].ToString(),
                                Value = lector["nIdEmpresa"].ToString()
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            return items;
        }

        // Método para cargar datos
        public List<Datos> CargarDatos(int categoria = 1, int municipio = 1, int empresa = 1)
        {
            conectar();
            List<Datos> items = new List<Datos>();
            string query = @"
                SELECT categorias.sNombreCategoria, ofertas.nIdOferta, ofertas.sTituloOferta, 
                       nTipoContrato = CASE ofertas.nTipoContrato WHEN 1 THEN 'Permanente' WHEN 2 THEN 'Por proyecto' END,
                       nTipoJornada = CASE ofertas.nTipoJornada WHEN 1 THEN 'Tiempo Completo' WHEN 2 THEN 'Por horas' END,
                       ofertas.fSalario, ofertas.dFechaPublicacion, empresas.sNombreEmpresa, municipios.sNombreMunicipio
                FROM municipios
                INNER JOIN ofertas ON municipios.nIdMunicipio = ofertas.nIdLocalidad
                INNER JOIN empresas ON ofertas.nIdEmpresa = empresas.nIdEmpresa
                INNER JOIN categorias ON ofertas.nIdCategoria = categorias.nIdCategoria
                WHERE categorias.nIdCategoria = @nIdCategoria 
                  AND municipios.nIdMunicipio = @nIdMunicipio 
                  AND empresas.nIdEmpresa = @nIdEmpresa";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                comando.Parameters.AddWithValue("@nIdCategoria", categoria);
                comando.Parameters.AddWithValue("@nIdMunicipio", municipio);
                comando.Parameters.AddWithValue("@nIdEmpresa", empresa);

                try
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            items.Add(new Datos
                            {
                                sNombreCategoria = lector["sNombreCategoria"].ToString(),
                                nIdOferta = lector["nIdOferta"].ToString(),
                                sTituloOferta = lector["sTituloOferta"].ToString(),
                                nTipoJornada = lector["nTipoJornada"].ToString(),
                                fSalario = lector["fSalario"].ToString(),
                                dFechaPublicacion = lector["dFechaPublicacion"].ToString(),
                                sNombreEmpresa = lector["sNombreEmpresa"].ToString(),
                                sNombreMunicipio = lector["sNombreMunicipio"].ToString()
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            return items;
        }

        // Método para mostrar oferta
        public Datos mostrarOferta(int idOferta)
        {
            conectar();
            Datos item = new Datos();
            string query = "SELECT * FROM ofertas WHERE nIdOferta = @idOferta";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                comando.Parameters.AddWithValue("@idOferta", idOferta);

                try
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            item.nIdCategoria = lector["nIdCategoria"].ToString();
                            item.nIdOferta = lector["nIdOferta"].ToString();
                            item.sTituloOferta = lector["sTituloOferta"].ToString();
                            item.nTipoJornada = lector["nTipoJornada"].ToString();
                            item.fSalario = lector["fSalario"].ToString();
                            item.nIdLocalidad = lector["nIdLocalidad"].ToString();
                            item.nTipoContrato = lector["nTipoContrato"].ToString();
                            item.dFechaPublicacion = lector["dFechaPublicacion"].ToString();
                            item.dFechaContratacion = lector["FechaContratacion"].ToString();
                            item.nIdEmpresa = lector["nIdEmpresa"].ToString();
                            item.nTipoLocalidad = lector["nTipoLocalidad"].ToString();
                            item.sDescripcion = lector["sDescripcion"].ToString();
                            item.nVacantes = lector["nVacantes"].ToString();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            return item;
        }

        // Método para insertar nueva oferta
        public int nuevaOferta(Datos oferta)
        {
            conectar();
            string query = @"
                INSERT INTO ofertas(nIdEmpresa, sTituloOferta, nTipoJornada, nTipoContrato, fSalario, nIdLocalidad, nTipoLocalidad, nIdCategoria, dFechaPublicacion, sDescripcion, FechaContratacion, nVacantes) VALUES (@nIdEmpresa, @sTituloOferta, @nTipoJornada, @nTipoContrato, @fSalario, @nIdLocalidad, @nTipoLocalidad, @nIdCategoria, @dFechaPublicacion, @sDescripcion, @FechaContratacion, @nVacantes)";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                comando.Parameters.AddWithValue("@nIdEmpresa", oferta.nIdEmpresa);
                comando.Parameters.AddWithValue("@sTituloOferta", oferta.sTituloOferta);
                comando.Parameters.AddWithValue("@nTipoJornada", oferta.nTipoJornada);
                comando.Parameters.AddWithValue("@nTipoContrato", oferta.nTipoContrato);
                comando.Parameters.AddWithValue("@fSalario", oferta.fSalario);
                comando.Parameters.AddWithValue("@nIdLocalidad", oferta.nIdLocalidad);
                comando.Parameters.AddWithValue("@nTipoLocalidad", oferta.nTipoLocalidad);
                comando.Parameters.AddWithValue("@nIdCategoria", oferta.nIdCategoria);
                comando.Parameters.AddWithValue("@dFechaPublicacion", oferta.dFechaPublicacion);
                comando.Parameters.AddWithValue("@sDescripcion", oferta.sDescripcion);
                comando.Parameters.AddWithValue("@FechaContratacion", oferta.dFechaContratacion);
                comando.Parameters.AddWithValue("@nVacantes", oferta.nVacantes);

                try
                {
                    return comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    desconectar();
                }
            }
        }


        public int actualizarOferta(int nIdOferta, int nIdEmpresa, string sTituloOferta, int nTipoJornada,
                            int nTipoContrato, double fSalario, int nIdLocalidad, int nTipoLocalidad,
                            int nIdCategoria, string sDescripcion, string FechaContratacion, int nVacantes)
        {
            conectar();
            string query = @"
        UPDATE ofertas
        SET sTituloOferta = @sTituloOferta,
            nTipoJornada = @nTipoJornada,
            nTipoContrato = @nTipoContrato,
            fSalario = @fSalario,
            nIdLocalidad = @nIdLocalidad,
            nTipoLocalidad = @nTipoLocalidad,
            nIdCategoria = @nIdCategoria,
            dFechaPublicacion = @dFechaPublicacion,
            sDescripcion = @sDescripcion,
            FechaContratacion = @FechaContratacion,
            nVacantes = @nVacantes
        WHERE nIdOferta = @nIdOferta";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                comando.Parameters.AddWithValue("@sTituloOferta", sTituloOferta);
                comando.Parameters.AddWithValue("@nTipoJornada", nTipoJornada);
                comando.Parameters.AddWithValue("@nTipoContrato", nTipoContrato);
                comando.Parameters.AddWithValue("@fSalario", fSalario);
                comando.Parameters.AddWithValue("@nIdLocalidad", nIdLocalidad);
                comando.Parameters.AddWithValue("@nTipoLocalidad", nTipoLocalidad);
                comando.Parameters.AddWithValue("@nIdCategoria", nIdCategoria);
                comando.Parameters.AddWithValue("@dFechaPublicacion", DateTime.Now); // Asegúrate de usar la fecha correcta
                comando.Parameters.AddWithValue("@sDescripcion", sDescripcion);
                comando.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                comando.Parameters.AddWithValue("@nVacantes", nVacantes);
                comando.Parameters.AddWithValue("@nIdOferta", nIdOferta);

                try
                {
                    return comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    desconectar();
                }
            }
        }


        // Método para eliminar oferta
        public int EliminarDatos(int idOferta)
        {
            conectar();
            string query = "DELETE FROM ofertas WHERE nIdOferta = @nIdOferta";

            using (SqlCommand comando = new SqlCommand(query, conexionSQL))
            {
                comando.Parameters.AddWithValue("@nIdOferta", idOferta);

                try
                {
                    return comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    desconectar();
                }
            }
        }
    }
}

