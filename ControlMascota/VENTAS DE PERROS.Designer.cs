namespace ControlMascota
{
    partial class VENTAS_DE_PERROS
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
            this.txtcostoperro = new System.Windows.Forms.TextBox();
            this.txtedadperro = new System.Windows.Forms.TextBox();
            this.txtcolorperro = new System.Windows.Forms.TextBox();
            this.txtnombreperro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvventagato = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnperrocomomascota = new System.Windows.Forms.Button();
            this.btncantidadperros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcostoperro
            // 
            this.txtcostoperro.Location = new System.Drawing.Point(184, 417);
            this.txtcostoperro.Name = "txtcostoperro";
            this.txtcostoperro.Size = new System.Drawing.Size(152, 23);
            this.txtcostoperro.TabIndex = 20;
            // 
            // txtedadperro
            // 
            this.txtedadperro.Location = new System.Drawing.Point(185, 374);
            this.txtedadperro.Name = "txtedadperro";
            this.txtedadperro.Size = new System.Drawing.Size(152, 23);
            this.txtedadperro.TabIndex = 19;
            // 
            // txtcolorperro
            // 
            this.txtcolorperro.Location = new System.Drawing.Point(184, 335);
            this.txtcolorperro.Name = "txtcolorperro";
            this.txtcolorperro.Size = new System.Drawing.Size(152, 23);
            this.txtcolorperro.TabIndex = 18;
            // 
            // txtnombreperro
            // 
            this.txtnombreperro.Location = new System.Drawing.Point(184, 300);
            this.txtnombreperro.Name = "txtnombreperro";
            this.txtnombreperro.Size = new System.Drawing.Size(152, 23);
            this.txtnombreperro.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Costo de la Mascota :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Edad de la Mascota :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Color de Pelo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de la Mascota :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "VENTA DE PERROS";
            // 
            // lvventagato
            // 
            this.lvventagato.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvventagato.GridLines = true;
            this.lvventagato.Location = new System.Drawing.Point(12, 62);
            this.lvventagato.Name = "lvventagato";
            this.lvventagato.Size = new System.Drawing.Size(542, 217);
            this.lvventagato.TabIndex = 11;
            this.lvventagato.UseCompatibleStateImageBehavior = false;
            this.lvventagato.View = System.Windows.Forms.View.Details;
            this.lvventagato.SelectedIndexChanged += new System.EventHandler(this.lvventagato_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre de la Mascota";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color de Pelo";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edad de la Mascota ";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Costo de la Mascota";
            this.columnHeader4.Width = 130;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnagregar.Location = new System.Drawing.Point(394, 316);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(160, 42);
            this.btnagregar.TabIndex = 21;
            this.btnagregar.Text = "Agregar Datos";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnperrocomomascota
            // 
            this.btnperrocomomascota.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnperrocomomascota.Location = new System.Drawing.Point(394, 374);
            this.btnperrocomomascota.Name = "btnperrocomomascota";
            this.btnperrocomomascota.Size = new System.Drawing.Size(160, 52);
            this.btnperrocomomascota.TabIndex = 22;
            this.btnperrocomomascota.Text = "La raza con más perros como mascotas";
            this.btnperrocomomascota.UseVisualStyleBackColor = true;
            // 
            // btncantidadperros
            // 
            this.btncantidadperros.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncantidadperros.Location = new System.Drawing.Point(394, 441);
            this.btncantidadperros.Name = "btncantidadperros";
            this.btncantidadperros.Size = new System.Drawing.Size(160, 68);
            this.btncantidadperros.TabIndex = 23;
            this.btncantidadperros.Text = "La raza y la cantidad de perros como mascotas";
            this.btncantidadperros.UseVisualStyleBackColor = true;
            // 
            // VENTAS_DE_PERROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 521);
            this.Controls.Add(this.btncantidadperros);
            this.Controls.Add(this.btnperrocomomascota);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcostoperro);
            this.Controls.Add(this.txtedadperro);
            this.Controls.Add(this.txtcolorperro);
            this.Controls.Add(this.txtnombreperro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvventagato);
            this.Name = "VENTAS_DE_PERROS";
            this.Text = "VENTAS_DE_PERROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtcostoperro;
        private TextBox txtedadperro;
        private TextBox txtcolorperro;
        private TextBox txtnombreperro;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvventagato;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnagregar;
        private Button btnperrocomomascota;
        private Button btncantidadperros;
    }
}