using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo Articulo;
        private List<Articulo> listaArticulo;

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
            Text = articulo.Nombre.ToString().ToUpper();

        }
        private void frmDetalleArticulo_Load_1(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.ListarDetalle(Articulo);
                dgvDetalles.DataSource = listaArticulo;
                cargarImagen(Articulo.ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado;
                if (dgvDetalles.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvDetalles.CurrentRow.DataBoundItem;
                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No Hay Articulo Seleccionado");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            seleccionado = (Articulo)dgvDetalles.CurrentRow.DataBoundItem;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad deseas eliminar el articulo " + seleccionado.Nombre.ToString(), "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvDetalles.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pcbArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");

            }
        }
    }
}
