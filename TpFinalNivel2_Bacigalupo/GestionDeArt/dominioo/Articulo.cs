using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dominioo
{
    public class Articulo
    {
        public int Id { get; set; }
        
        public string codigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }      
        public string ImagenUrl { get; set; }        
       // public int Precio { get; set; }

        public Marcas Marca { get; set; }
        public categorias Categoria { get; set; }


    }
}
