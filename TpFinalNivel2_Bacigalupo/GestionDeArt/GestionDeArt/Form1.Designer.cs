namespace GestionDeArt
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
            this.dgvUno = new System.Windows.Forms.DataGridView();
            this.pbxUno = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtfiltroAvanzado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfiltroAvanzado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUno
            // 
            this.dgvUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUno.Location = new System.Drawing.Point(12, 56);
            this.dgvUno.Name = "dgvUno";
            this.dgvUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUno.Size = new System.Drawing.Size(591, 293);
            this.dgvUno.TabIndex = 0;
            this.dgvUno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUno_CellContentClick);
            this.dgvUno.SelectionChanged += new System.EventHandler(this.dgvUno_SelectionChanged_1);
            // 
            // pbxUno
            // 
            this.pbxUno.Location = new System.Drawing.Point(609, 56);
            this.pbxUno.Name = "pbxUno";
            this.pbxUno.Size = new System.Drawing.Size(279, 293);
            this.pbxUno.TabIndex = 1;
            this.pbxUno.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(252, 355);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(505, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(26, 29);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(90, 26);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(145, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(252, 24);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(223, 404);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(79, 21);
            this.cboCriterio.TabIndex = 10;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(75, 404);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(79, 21);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(26, 407);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(175, 407);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 13;
            this.lblCriterio.Text = "Criterio:";
            // 
            // txtfiltroAvanzado
            // 
            this.txtfiltroAvanzado.Location = new System.Drawing.Point(408, 404);
            this.txtfiltroAvanzado.Name = "txtfiltroAvanzado";
            this.txtfiltroAvanzado.Size = new System.Drawing.Size(79, 20);
            this.txtfiltroAvanzado.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblfiltroAvanzado
            // 
            this.lblfiltroAvanzado.AutoSize = true;
            this.lblfiltroAvanzado.Location = new System.Drawing.Point(320, 407);
            this.lblfiltroAvanzado.Name = "lblfiltroAvanzado";
            this.lblfiltroAvanzado.Size = new System.Drawing.Size(82, 13);
            this.lblfiltroAvanzado.TabIndex = 16;
            this.lblfiltroAvanzado.Text = "Filtro avanzado:";
            this.lblfiltroAvanzado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 487);
            this.Controls.Add(this.lblfiltroAvanzado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxUno);
            this.Controls.Add(this.dgvUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUno;
        private System.Windows.Forms.PictureBox pbxUno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtfiltroAvanzado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblfiltroAvanzado;
    }
}

