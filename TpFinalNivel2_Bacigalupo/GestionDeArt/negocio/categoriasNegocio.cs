using dominioo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class categoriasNegocio
    {
        public List<categorias> listar()
        {
            List<categorias> lista = new List<categorias>();
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    categorias aux = new categorias();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }

                return lista;

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
    }
}
