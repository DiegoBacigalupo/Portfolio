using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using dominioo;
using negocio;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS03; database=CATALOGO_DB; integrated security=true"; 
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo, A.Nombre, A.Descripcion, Precio, ImagenUrl, M.Descripcion Marca, C.Descripcion categoria, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.codigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                   // aux.Precio = (int)lector["Precio"];

                 if (!(lector.IsDBNull(lector.GetOrdinal("ImagenUrl"))))
                     aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    aux.Categoria = new categorias();
                    aux.Categoria.Id= (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];


                    lista.Add(aux);


                }
                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {
            accesoDatos datos = new accesoDatos();

            try {


                //  datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, ) values('"+nuevo.codigoArticulo+ "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "' )");

                
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, ImagenUrl, IdCategoria) values('" + nuevo.codigoArticulo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @IdCategoria, @ImagenUrl, @IdMarca )");
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
          

               // datos.setearParametro("@IdDebilidad", nuevo.Debilidad.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo nuevo)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo =@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl where Id = @Id");
                datos.setearParametro("@Codigo", nuevo.codigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("Id", nuevo.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int Id)
        {
            try
            {
                accesoDatos datos = new accesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            accesoDatos datos = new accesoDatos();
            try
            {
                string consulta = "select A.Codigo, A.Nombre, A.Descripcion, Precio, ImagenUrl, M.Descripcion Marca, C.Descripcion categoria, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and ";
                if(campo == "Codigo articulo")
                {
                    switch (criterio)
                    {
                      

                        case "Comienza con:":

                            consulta += "A.Codigo like '" + filtro + "%'";
                            break;

                        case "Termina con:":
                            consulta += "A.Codigo like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "A.Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {  
                    switch(criterio)
                    {
                        case "Comienza con:":

                            consulta += "A.Nombre like '" + filtro + "%'";
                    break;

                        case "Termina con:":
                            consulta += "A.Nombre like '%" + filtro + "'";
                    break;

                        default:
                            consulta += "A.Nombre like '%" + filtro + "%'";
                    break;
                    }
                }
                    else
                    {
                    switch (criterio)
                    {
                        case "Comienza con:":

                            consulta += "A.Descripcion like '" + filtro + "%'";
                            break;

                        case "Termina con:":
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;                    
                    }

                    }



                
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    // aux.Precio = (int)lector["Precio"];

                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new categorias();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];


                    lista.Add(aux);


                }
                
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
                     
        }
    }
}
