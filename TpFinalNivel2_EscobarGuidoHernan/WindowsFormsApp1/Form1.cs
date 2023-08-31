using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulo;

        public Form1()
        {
            InitializeComponent();  
        }


        private void BtnListar_Click(object sender, EventArgs e)
        {             
            Cargar();
            btnDetalles.Visible = true;
            BtnLimpiar.Visible = true;
            btnModificar.Visible = true;
            BtnEliminar.Visible = true;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            Cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado;
                if (dgvArticulos.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
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
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            if(dgvArticulos.DataSource != null)
            {
                try
                {
                    if (dgvArticulos.CurrentRow != null)
                    {
                        Articulo seleccionado;
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    
                        DialogResult respuesta = MessageBox.Show("¿De verdad deseas eliminar el articulo " + seleccionado.Nombre.ToString(), "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                            negocio.Eliminar(seleccionado.Id);
                            Cargar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Articulo!!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe Listar Primero...");
            }



        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    if (seleccionado != null)
                    {
                        frmDetalleArticulo detalle = new frmDetalleArticulo(seleccionado);
                        detalle.ShowDialog();
                    }                     
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un articulo primero...");
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


       
        //Filtro Rapido
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filtro = txtFiltro.Text;

            if (dgvArticulos.DataSource!= null)
            {
                
                if (filtro.Length >= 1)
                {
                    listafiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper())); ;
                }
                else
                {
                    listafiltrada = listaArticulo;
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listafiltrada;
                ocultarColumnas();
            }
            else
            {
                MessageBox.Show("No Hay Articulos, Primero debes listar !!! ");
            }
        }


        #region FiltroAvanzado
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }


        }

        private void btnFiltrarAvanzado_Click(object sender, EventArgs e)
        { 
            if(dgvArticulos.DataSource != null) 
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    if (validarFiltro())
                        return;
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro = txtFiltroAvanzado.Text;
                    dgvArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay articulos para filtrar " + " ¡¡ Debes Listar antes...!!");
            }
            

        }

        #endregion

        
        #region Metodos

        private void Cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.Listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una opción en Campo para filtrar");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una opción en Criterio para filtrar");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() ==  "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para número...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo Ingrese Números para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;


        }

        private bool soloNumeros(string Cadena)
        {
            foreach (char caracter in Cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;

        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Precio");
            lblCampo.Visible = false;
            lblCriterio.Visible = false;
            lblFiltro.Visible = false;
            cboCampo.Visible = false;
            cboCriterio.Visible = false;
            txtFiltroAvanzado.Visible = false;
            btnFiltrarAvanzado.Visible = false;
            btnDetalles.Visible = false;
            btnModificar.Visible = false;
            BtnEliminar.Visible = false;
            gbFiltro.Visible = false;
            BtnLimpiar.Visible = false;
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {

            lblCampo.Visible = true;
            lblCriterio.Visible = true;
            lblFiltro.Visible = true;
            cboCampo.Visible = true;
            cboCriterio.Visible = true;
            txtFiltroAvanzado.Visible = true;
            btnFiltrarAvanzado.Visible = true;
            gbFiltro.Visible = true;
        }

        private void btnFiltroRapido_Click(object sender, EventArgs e)
        {
            txtFiltro.Visible = true;
            lblFiltroRapido.Visible = true;
        }
        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            lblFiltroRapido.Visible =false;
            txtFiltro.Visible = false;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = null;
        }

        #endregion


    }
}
