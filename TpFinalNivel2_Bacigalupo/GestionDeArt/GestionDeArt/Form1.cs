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
using negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GestionDeArt
{
    public partial class Form1 : Form
    {
     


        private List<Articulo> listaArticulo;



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();

            cboCampo.Items.Add("Codigo articulo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            segundaVentana alta = new segundaVentana();     
            alta.ShowDialog();
            cargar();

        }
        private void dgvUno_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvUno.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvUno.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
            

        }

       private void cargarImagen(string imagen)
         {
             try
             {
                 pbxUno.Load(imagen);
             }
             catch (Exception ex)
             {

                 pbxUno.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
             }


         }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {

                listaArticulo = negocio.listar();
                dgvUno.DataSource = listaArticulo;
                ocualtarcolumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ocualtarcolumnas()
        {
            dgvUno.Columns["ImagenUrl"].Visible = false;
            dgvUno.Columns["Id"].Visible = false;
        }

         private void button1_Click(object sender, EventArgs e)
          {
              segundaVentana alta = new segundaVentana();
              alta.ShowDialog();
              cargar();
          }

          private void btnModificar_Click(object sender, EventArgs e)
          {
              Articulo seleccionado;
              seleccionado = (Articulo)dgvUno.CurrentRow.DataBoundItem;

              segundaVentana modificar = new  segundaVentana(seleccionado);
              modificar.ShowDialog();
              cargar();
          }

        private void dgvUno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvUno.CurrentRow.DataBoundItem;

            segundaVentana modificar = new segundaVentana(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio elim = new ArticulosNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿seguro de que quieres eliminarlos?", "eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvUno.CurrentRow.DataBoundItem;
                    elim.eliminar(seleccionado.Id);

                    MessageBox.Show("El Articulo fue eliminado.");

                }
                
                cargar();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }




            dgvUno.DataSource = null;
            dgvUno.DataSource = listaFiltrada;
            ocualtarcolumnas();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }




            dgvUno.DataSource = null;
            dgvUno.DataSource = listaFiltrada;
            ocualtarcolumnas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Codigo articulo")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con:");
                cboCriterio.Items.Add("Termina con:");
                cboCriterio.Items.Add("Contiene:");
            }
            else if (opcion == "Descripcion")
            {
               
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con:");
                cboCriterio.Items.Add("Termina con:");
                cboCriterio.Items.Add("Contiene:");
            }
            else  //(opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con:");
                cboCriterio.Items.Add("Termina con:");
                cboCriterio.Items.Add("Contiene:");
            }
            

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("seleccione el campo para filtrar");
                return true;
            }
            if(cboCriterio.SelectedIndex< 0)
            {
                MessageBox.Show("seleccione el criterio para filtrar");
                return true;

            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ArticulosNegocio negocio= new ArticulosNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtfiltroAvanzado.Text;

                dgvUno.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
