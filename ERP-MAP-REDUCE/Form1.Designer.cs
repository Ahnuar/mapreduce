namespace ERP_MAP_REDUCE
{
    partial class Frmain
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
            this.lbPalabras = new System.Windows.Forms.Label();
            this.btContarPalabras = new System.Windows.Forms.Button();
            this.btContarletras = new System.Windows.Forms.Button();
            this.fdFichero = new System.Windows.Forms.OpenFileDialog();
            this.btFichero = new System.Windows.Forms.Button();
            this.lbPalabrasContadas = new System.Windows.Forms.ListBox();
            this.lbLetrasContadas = new System.Windows.Forms.ListBox();
            this.lbLetras = new System.Windows.Forms.Label();
            this.lbFichero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPalabras
            // 
            this.lbPalabras.AutoSize = true;
            this.lbPalabras.Location = new System.Drawing.Point(341, 17);
            this.lbPalabras.Name = "lbPalabras";
            this.lbPalabras.Size = new System.Drawing.Size(95, 13);
            this.lbPalabras.TabIndex = 0;
            this.lbPalabras.Text = "Palabras contadas";
            // 
            // btContarPalabras
            // 
            this.btContarPalabras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btContarPalabras.Location = new System.Drawing.Point(15, 56);
            this.btContarPalabras.Name = "btContarPalabras";
            this.btContarPalabras.Size = new System.Drawing.Size(115, 23);
            this.btContarPalabras.TabIndex = 1;
            this.btContarPalabras.Text = "ContarPalabras";
            this.btContarPalabras.UseVisualStyleBackColor = false;
            this.btContarPalabras.Click += new System.EventHandler(this.btContarPalabras_Click);
            // 
            // btContarletras
            // 
            this.btContarletras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btContarletras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btContarletras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btContarletras.FlatAppearance.BorderSize = 0;
            this.btContarletras.Location = new System.Drawing.Point(15, 103);
            this.btContarletras.Name = "btContarletras";
            this.btContarletras.Size = new System.Drawing.Size(115, 23);
            this.btContarletras.TabIndex = 2;
            this.btContarletras.Text = "Contar Letras";
            this.btContarletras.UseVisualStyleBackColor = false;
            this.btContarletras.Click += new System.EventHandler(this.btContarletras_Click);
            // 
            // fdFichero
            // 
            this.fdFichero.FileName = "openFileDialog2";
            // 
            // btFichero
            // 
            this.btFichero.Location = new System.Drawing.Point(15, 12);
            this.btFichero.Name = "btFichero";
            this.btFichero.Size = new System.Drawing.Size(115, 23);
            this.btFichero.TabIndex = 3;
            this.btFichero.Text = "Selecionar Fichero";
            this.btFichero.UseVisualStyleBackColor = true;
            this.btFichero.Click += new System.EventHandler(this.btFichero_Click);
            // 
            // lbPalabrasContadas
            // 
            this.lbPalabrasContadas.FormattingEnabled = true;
            this.lbPalabrasContadas.Location = new System.Drawing.Point(344, 45);
            this.lbPalabrasContadas.Name = "lbPalabrasContadas";
            this.lbPalabrasContadas.Size = new System.Drawing.Size(187, 264);
            this.lbPalabrasContadas.TabIndex = 4;
            // 
            // lbLetrasContadas
            // 
            this.lbLetrasContadas.FormattingEnabled = true;
            this.lbLetrasContadas.Location = new System.Drawing.Point(606, 45);
            this.lbLetrasContadas.Name = "lbLetrasContadas";
            this.lbLetrasContadas.Size = new System.Drawing.Size(186, 264);
            this.lbLetrasContadas.TabIndex = 5;
            // 
            // lbLetras
            // 
            this.lbLetras.AutoSize = true;
            this.lbLetras.Location = new System.Drawing.Point(603, 17);
            this.lbLetras.Name = "lbLetras";
            this.lbLetras.Size = new System.Drawing.Size(83, 13);
            this.lbLetras.TabIndex = 6;
            this.lbLetras.Text = "Letras contadas";
            // 
            // lbFichero
            // 
            this.lbFichero.AutoSize = true;
            this.lbFichero.Location = new System.Drawing.Point(16, 296);
            this.lbFichero.Name = "lbFichero";
            this.lbFichero.Size = new System.Drawing.Size(114, 13);
            this.lbFichero.TabIndex = 7;
            this.lbFichero.Text = "No hay ningun Fichero";
            // 
            // Frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 321);
            this.Controls.Add(this.lbFichero);
            this.Controls.Add(this.lbLetras);
            this.Controls.Add(this.lbLetrasContadas);
            this.Controls.Add(this.lbPalabrasContadas);
            this.Controls.Add(this.btFichero);
            this.Controls.Add(this.btContarletras);
            this.Controls.Add(this.btContarPalabras);
            this.Controls.Add(this.lbPalabras);
            this.Name = "Frmain";
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPalabras;
        private System.Windows.Forms.Button btContarPalabras;
        private System.Windows.Forms.Button btContarletras;
        private System.Windows.Forms.OpenFileDialog fdFichero;
        private System.Windows.Forms.Button btFichero;
        private System.Windows.Forms.ListBox lbPalabrasContadas;
        private System.Windows.Forms.ListBox lbLetrasContadas;
        private System.Windows.Forms.Label lbLetras;
        private System.Windows.Forms.Label lbFichero;
    }
}

