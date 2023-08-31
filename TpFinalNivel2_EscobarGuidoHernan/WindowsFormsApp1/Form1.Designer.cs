namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnFiltrarAvanzado = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.btnFiltroRapido = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSalir.Location = new System.Drawing.Point(734, 518);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 44);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.FlatAppearance.BorderSize = 2;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnEliminar.Location = new System.Drawing.Point(701, 329);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 41);
            this.BtnEliminar.TabIndex = 56;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnModificar.Location = new System.Drawing.Point(548, 329);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(127, 41);
            this.btnModificar.TabIndex = 55;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltroAvanzado.FlatAppearance.BorderSize = 2;
            this.btnFiltroAvanzado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFiltroAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAvanzado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroAvanzado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(13, 283);
            this.btnFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(193, 61);
            this.btnFiltroAvanzado.TabIndex = 54;
            this.btnFiltroAvanzado.Text = "Filtro Avanzado";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(512, 36);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(168, 26);
            this.txtFiltroAvanzado.TabIndex = 58;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(312, 36);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(122, 28);
            this.cboCriterio.TabIndex = 53;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(94, 34);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(109, 28);
            this.cboCampo.TabIndex = 52;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // btnFiltrarAvanzado
            // 
            this.btnFiltrarAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarAvanzado.Location = new System.Drawing.Point(700, 33);
            this.btnFiltrarAvanzado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrarAvanzado.Name = "btnFiltrarAvanzado";
            this.btnFiltrarAvanzado.Size = new System.Drawing.Size(90, 32);
            this.btnFiltrarAvanzado.TabIndex = 51;
            this.btnFiltrarAvanzado.Text = "Buscar";
            this.btnFiltrarAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltrarAvanzado.Click += new System.EventHandler(this.btnFiltrarAvanzado_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(442, 38);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(62, 21);
            this.lblFiltro.TabIndex = 50;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(222, 38);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(82, 21);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(7, 38);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(79, 21);
            this.lblCampo.TabIndex = 48;
            this.lblCampo.Text = "Campo:";
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.Location = new System.Drawing.Point(232, 22);
            this.lblFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(140, 25);
            this.lblFiltroRapido.TabIndex = 47;
            this.lblFiltroRapido.Text = "Filtro Rapido:";
            this.lblFiltroRapido.Visible = false;
            this.lblFiltroRapido.MouseLeave += new System.EventHandler(this.txtFiltro_Leave);
            // 
            // btnFiltroRapido
            // 
            this.btnFiltroRapido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltroRapido.FlatAppearance.BorderSize = 2;
            this.btnFiltroRapido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFiltroRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroRapido.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroRapido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFiltroRapido.Location = new System.Drawing.Point(13, 217);
            this.btnFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltroRapido.Name = "btnFiltroRapido";
            this.btnFiltroRapido.Size = new System.Drawing.Size(193, 56);
            this.btnFiltroRapido.TabIndex = 46;
            this.btnFiltroRapido.Text = "Filtro Simple";
            this.btnFiltroRapido.UseVisualStyleBackColor = true;
            this.btnFiltroRapido.Click += new System.EventHandler(this.btnFiltroRapido_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregar.Location = new System.Drawing.Point(13, 146);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(193, 61);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(237, 52);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(567, 26);
            this.txtFiltro.TabIndex = 44;
            this.txtFiltro.Visible = false;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.Leave += new System.EventHandler(this.txtFiltro_Leave);
            this.txtFiltro.MouseLeave += new System.EventHandler(this.txtFiltro_Leave);
            // 
            // BtnListar
            // 
            this.BtnListar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnListar.FlatAppearance.BorderSize = 2;
            this.BtnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnListar.Location = new System.Drawing.Point(13, 75);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(193, 61);
            this.BtnListar.TabIndex = 43;
            this.BtnListar.Text = "Listar Articulos";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetalles.FlatAppearance.BorderSize = 2;
            this.btnDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDetalles.Location = new System.Drawing.Point(237, 329);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(135, 41);
            this.btnDetalles.TabIndex = 42;
            this.btnDetalles.Text = "Ver Detalle";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticulos.Location = new System.Drawing.Point(237, 88);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(567, 231);
            this.dgvArticulos.TabIndex = 41;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.lblCampo);
            this.gbFiltro.Controls.Add(this.lblCriterio);
            this.gbFiltro.Controls.Add(this.lblFiltro);
            this.gbFiltro.Controls.Add(this.btnFiltrarAvanzado);
            this.gbFiltro.Controls.Add(this.cboCampo);
            this.gbFiltro.Controls.Add(this.txtFiltroAvanzado);
            this.gbFiltro.Controls.Add(this.cboCriterio);
            this.gbFiltro.Location = new System.Drawing.Point(15, 406);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(834, 89);
            this.gbFiltro.TabIndex = 59;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "FiltroAvanzado";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiar.FlatAppearance.BorderSize = 2;
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnLimpiar.Location = new System.Drawing.Point(380, 329);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(103, 41);
            this.BtnLimpiar.TabIndex = 60;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 567);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnFiltroRapido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(887, 627);
            this.MinimumSize = new System.Drawing.Size(867, 622);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Button btnFiltrarAvanzado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.Button btnFiltroRapido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

