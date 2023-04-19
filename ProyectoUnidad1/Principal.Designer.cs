namespace ProyectoUnidad1
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lbdorn_carpetas = new System.Windows.Forms.ListBox();
            this.lbdorn_notas = new System.Windows.Forms.ListBox();
            this.txbnotas = new System.Windows.Forms.TextBox();
            this.btndorn_nuevo = new System.Windows.Forms.Button();
            this.btndorn_color = new System.Windows.Forms.Button();
            this.btndorn_fuente = new System.Windows.Forms.Button();
            this.btndorn_mas = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.btndorn_newCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdorn_carpetas
            // 
            this.lbdorn_carpetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbdorn_carpetas.ForeColor = System.Drawing.Color.Black;
            this.lbdorn_carpetas.FormattingEnabled = true;
            this.lbdorn_carpetas.ItemHeight = 15;
            this.lbdorn_carpetas.Location = new System.Drawing.Point(0, -3);
            this.lbdorn_carpetas.Name = "lbdorn_carpetas";
            this.lbdorn_carpetas.Size = new System.Drawing.Size(150, 559);
            this.lbdorn_carpetas.TabIndex = 0;
            this.lbdorn_carpetas.SelectedIndexChanged += new System.EventHandler(this.lbdorn_carpetas_SelectedIndexChanged);
            // 
            // lbdorn_notas
            // 
            this.lbdorn_notas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbdorn_notas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbdorn_notas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbdorn_notas.FormattingEnabled = true;
            this.lbdorn_notas.ItemHeight = 15;
            this.lbdorn_notas.Location = new System.Drawing.Point(147, 1);
            this.lbdorn_notas.Name = "lbdorn_notas";
            this.lbdorn_notas.Size = new System.Drawing.Size(273, 585);
            this.lbdorn_notas.TabIndex = 1;
            this.lbdorn_notas.SelectedIndexChanged += new System.EventHandler(this.lbdorn_notas_SelectedIndexChanged);
            // 
            // txbnotas
            // 
            this.txbnotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbnotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbnotas.Enabled = false;
            this.txbnotas.Location = new System.Drawing.Point(427, 77);
            this.txbnotas.Multiline = true;
            this.txbnotas.Name = "txbnotas";
            this.txbnotas.Size = new System.Drawing.Size(490, 491);
            this.txbnotas.TabIndex = 2;
            this.txbnotas.TextChanged += new System.EventHandler(this.txbnotas_TextChanged);
            this.txbnotas.Leave += new System.EventHandler(this.txbnotas_Leave);
            // 
            // btndorn_nuevo
            // 
            this.btndorn_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.btndorn_nuevo.BackgroundImage = global::ProyectoUnidad1.Properties.Resources.notas_adhesivas__1_;
            this.btndorn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndorn_nuevo.Location = new System.Drawing.Point(439, 14);
            this.btndorn_nuevo.Name = "btndorn_nuevo";
            this.btndorn_nuevo.Size = new System.Drawing.Size(32, 32);
            this.btndorn_nuevo.TabIndex = 3;
            this.btndorn_nuevo.UseVisualStyleBackColor = false;
            this.btndorn_nuevo.Click += new System.EventHandler(this.btndorn_nuevo_Click);
            // 
            // btndorn_color
            // 
            this.btndorn_color.BackColor = System.Drawing.Color.Transparent;
            this.btndorn_color.BackgroundImage = global::ProyectoUnidad1.Properties.Resources.font_size;
            this.btndorn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndorn_color.Location = new System.Drawing.Point(621, 12);
            this.btndorn_color.Name = "btndorn_color";
            this.btndorn_color.Size = new System.Drawing.Size(32, 32);
            this.btndorn_color.TabIndex = 5;
            this.btndorn_color.UseVisualStyleBackColor = false;
            this.btndorn_color.Click += new System.EventHandler(this.btndorn_color_Click);
            // 
            // btndorn_fuente
            // 
            this.btndorn_fuente.BackColor = System.Drawing.Color.Transparent;
            this.btndorn_fuente.BackgroundImage = global::ProyectoUnidad1.Properties.Resources.font;
            this.btndorn_fuente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndorn_fuente.Location = new System.Drawing.Point(659, 12);
            this.btndorn_fuente.Name = "btndorn_fuente";
            this.btndorn_fuente.Size = new System.Drawing.Size(32, 32);
            this.btndorn_fuente.TabIndex = 6;
            this.btndorn_fuente.UseVisualStyleBackColor = false;
            this.btndorn_fuente.Click += new System.EventHandler(this.btndorn_fuente_Click);
            // 
            // btndorn_mas
            // 
            this.btndorn_mas.BackColor = System.Drawing.Color.Transparent;
            this.btndorn_mas.BackgroundImage = global::ProyectoUnidad1.Properties.Resources.expand_button;
            this.btndorn_mas.Location = new System.Drawing.Point(890, 14);
            this.btndorn_mas.Name = "btndorn_mas";
            this.btndorn_mas.Size = new System.Drawing.Size(32, 32);
            this.btndorn_mas.TabIndex = 7;
            this.btndorn_mas.UseVisualStyleBackColor = false;
            this.btndorn_mas.Click += new System.EventHandler(this.btndorn_mas_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(621, 54);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(0, 15);
            this.lbfecha.TabIndex = 8;
            // 
            // btndorn_newCar
            // 
            this.btndorn_newCar.Location = new System.Drawing.Point(0, 545);
            this.btndorn_newCar.Name = "btndorn_newCar";
            this.btndorn_newCar.Size = new System.Drawing.Size(150, 41);
            this.btndorn_newCar.TabIndex = 9;
            this.btndorn_newCar.Text = "Crear carpeta";
            this.btndorn_newCar.UseVisualStyleBackColor = true;
            this.btndorn_newCar.Click += new System.EventHandler(this.btndorn_newCar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(929, 580);
            this.Controls.Add(this.btndorn_newCar);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.btndorn_mas);
            this.Controls.Add(this.btndorn_fuente);
            this.Controls.Add(this.btndorn_color);
            this.Controls.Add(this.btndorn_nuevo);
            this.Controls.Add(this.txbnotas);
            this.Controls.Add(this.lbdorn_notas);
            this.Controls.Add(this.lbdorn_carpetas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbdorn_carpetas;
        private ListBox lbdorn_notas;
        private TextBox txbnotas;
        private Button btndorn_nuevo;
        private Button btndorn_color;
        private Button btndorn_fuente;
        private Button btndorn_mas;
        private Label lbfecha;
        private Button btndorn_newCar;
    }
}