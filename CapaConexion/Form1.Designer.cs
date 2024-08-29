namespace CapaConexion
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bntCargar = new System.Windows.Forms.Button();
            this.Filtros = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 72);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(947, 285);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bntCargar
            // 
            this.bntCargar.Location = new System.Drawing.Point(12, 388);
            this.bntCargar.Name = "bntCargar";
            this.bntCargar.Size = new System.Drawing.Size(75, 23);
            this.bntCargar.TabIndex = 1;
            this.bntCargar.Text = "button1";
            this.bntCargar.UseVisualStyleBackColor = true;
            this.bntCargar.Click += new System.EventHandler(this.bntCargar_Click);
            // 
            // Filtros
            // 
            this.Filtros.AutoSize = true;
            this.Filtros.Location = new System.Drawing.Point(12, 23);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(43, 16);
            this.Filtros.TabIndex = 2;
            this.Filtros.Text = "Filtros";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(71, 21);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(100, 22);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.Filtros);
            this.Controls.Add(this.bntCargar);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button bntCargar;
        private System.Windows.Forms.Label Filtros;
        private System.Windows.Forms.TextBox tbFiltro;
    }
}

