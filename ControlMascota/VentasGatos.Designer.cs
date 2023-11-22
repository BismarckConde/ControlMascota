namespace ControlMascota
{
    partial class VentasGatos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeGatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDePerrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvventagato = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombregato = new System.Windows.Forms.TextBox();
            this.txtcolorgato = new System.Windows.Forms.TextBox();
            this.txtedadgato = new System.Windows.Forms.TextBox();
            this.txtcostogato = new System.Windows.Forms.TextBox();
            this.btnagregargato = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDeVentasToolStripMenuItem
            // 
            this.menuDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaDeGatosToolStripMenuItem,
            this.ventasDePerrosToolStripMenuItem});
            this.menuDeVentasToolStripMenuItem.Name = "menuDeVentasToolStripMenuItem";
            this.menuDeVentasToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.menuDeVentasToolStripMenuItem.Text = "menu de ventas ";
            this.menuDeVentasToolStripMenuItem.Click += new System.EventHandler(this.ventaDeGatosToolStripMenuItem_Click);
            // 
            // ventaDeGatosToolStripMenuItem
            // 
            this.ventaDeGatosToolStripMenuItem.Name = "ventaDeGatosToolStripMenuItem";
            this.ventaDeGatosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ventaDeGatosToolStripMenuItem.Text = "Venta de gatos ";
            this.ventaDeGatosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeGatosToolStripMenuItem_Click);
            // 
            // ventasDePerrosToolStripMenuItem
            // 
            this.ventasDePerrosToolStripMenuItem.Name = "ventasDePerrosToolStripMenuItem";
            this.ventasDePerrosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ventasDePerrosToolStripMenuItem.Text = "Ventas de Perros";
            this.ventasDePerrosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeGatosToolStripMenuItem_Click);
            // 
            // lvventagato
            // 
            this.lvventagato.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvventagato.GridLines = true;
            this.lvventagato.Location = new System.Drawing.Point(12, 95);
            this.lvventagato.Name = "lvventagato";
            this.lvventagato.Size = new System.Drawing.Size(542, 217);
            this.lvventagato.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENTA DE GATOS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de la Mascota :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color de Pelo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Edad de la Mascota :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Costo de la Mascota :";
            // 
            // txtnombregato
            // 
            this.txtnombregato.Location = new System.Drawing.Point(184, 333);
            this.txtnombregato.Name = "txtnombregato";
            this.txtnombregato.Size = new System.Drawing.Size(152, 23);
            this.txtnombregato.TabIndex = 7;
            // 
            // txtcolorgato
            // 
            this.txtcolorgato.Location = new System.Drawing.Point(184, 368);
            this.txtcolorgato.Name = "txtcolorgato";
            this.txtcolorgato.Size = new System.Drawing.Size(152, 23);
            this.txtcolorgato.TabIndex = 8;
            // 
            // txtedadgato
            // 
            this.txtedadgato.Location = new System.Drawing.Point(185, 407);
            this.txtedadgato.Name = "txtedadgato";
            this.txtedadgato.Size = new System.Drawing.Size(152, 23);
            this.txtedadgato.TabIndex = 9;
            // 
            // txtcostogato
            // 
            this.txtcostogato.Location = new System.Drawing.Point(184, 450);
            this.txtcostogato.Name = "txtcostogato";
            this.txtcostogato.Size = new System.Drawing.Size(152, 23);
            this.txtcostogato.TabIndex = 10;
            // 
            // btnagregargato
            // 
            this.btnagregargato.Location = new System.Drawing.Point(414, 352);
            this.btnagregargato.Name = "btnagregargato";
            this.btnagregargato.Size = new System.Drawing.Size(140, 52);
            this.btnagregargato.TabIndex = 11;
            this.btnagregargato.Text = "Agregar datos ";
            this.btnagregargato.UseVisualStyleBackColor = true;
            // 
            // VentasGatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 507);
            this.Controls.Add(this.btnagregargato);
            this.Controls.Add(this.txtcostogato);
            this.Controls.Add(this.txtedadgato);
            this.Controls.Add(this.txtcolorgato);
            this.Controls.Add(this.txtnombregato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvventagato);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentasGatos";
            this.Text = "ventas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDeVentasToolStripMenuItem;
        private ToolStripMenuItem ventaDeGatosToolStripMenuItem;
        private ToolStripMenuItem ventasDePerrosToolStripMenuItem;
        private ListView lvventagato;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnombregato;
        private TextBox txtcolorgato;
        private TextBox txtedadgato;
        private TextBox txtcostogato;
        private Button btnagregargato;
    }
}