using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominioo;
using System.Xml.Linq;


namespace GestionDeArt
{
    public partial class segundaVentana : Form
    {
        private Articulo articulo = null;

        public segundaVentana(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "modificar pokemon";
        }
        public segundaVentana()
        {
            InitializeComponent();
        }

        private void segundaVentana_Load(object sender, EventArgs e)
        {
            cargar();
            if (articulo != null)
            {
                txbCodigo.Text = articulo.codigoArticulo;
                txbDescripcion.Text = articulo.Descripcion;
                txbNombre.Text = articulo.Nombre;
                txbImagen.Text = articulo.ImagenUrl;
                cargarImagen(articulo.ImagenUrl);

            }

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxDos.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
            }


        }

        private void cargar()
        {
            marcasNegocio elementoNegocio = new marcasNegocio();

            categoriasNegocio catenegocio = new categoriasNegocio();
            try
            {
                cboMarcas.DataSource = elementoNegocio.listar();
                cboMarcas.ValueMember = "Id";
                cboMarcas.DisplayMember= "Descripcion";

                cboCategorias.DataSource = catenegocio.listar();
                cboCategorias.ValueMember= "Id";
                cboCategorias.DisplayMember= "Descripcion";

                if (articulo != null)
                {
                    txbCodigo.Text = articulo.codigoArticulo.ToString();
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cboMarcas.SelectedValue = articulo.Marca.Id;
                    cboCategorias.SelectedValue = articulo.Categoria.Id;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



            private void btnAceptar_Click(object sender, EventArgs e)
            {
                         
                           

                          // Articulo nuevoart = new Articulo();
                           ArticulosNegocio negocio = new ArticulosNegocio();

                           try
                           {    
                              if(articulo == null)                           
                                 articulo = new Articulo();
                             

                               articulo.Nombre = txbNombre.Text;
                               articulo.codigoArticulo = txbCodigo.Text;
                               // int.Parse(txbCodigo.Text);
                              articulo.Descripcion = txbDescripcion.Text;
                              articulo.ImagenUrl = txbImagen.Text;
                                
                              articulo.Marca= (Marcas)cboMarcas.SelectedItem;
                              articulo.Categoria = (categorias)cboCategorias.SelectedItem;

                               //nuevoart.Descripcion = (Marcas)cboDebilidad.SelectedItem;

                               if(articulo.Id!= 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("agregado Exitosamente ");
                }

              

                              
                              /* segundaVentana alta = new segundaVentana();
                               alta.ShowDialog();
                               cargar();*/
                               
                               Close();

                           }
                           catch (Exception ex)
                           {

                               MessageBox.Show(ex.Message);
                           }
               


            }

        private void txbImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

     
}

              
               
            
