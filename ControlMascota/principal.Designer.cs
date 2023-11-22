namespace ControlMascota
{
    partial class principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnperro = new System.Windows.Forms.Button();
            this.btngato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS DE MASCOTAS";
            // 
            // btnperro
            // 
            this.btnperro.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnperro.Location = new System.Drawing.Point(63, 132);
            this.btnperro.Name = "btnperro";
            this.btnperro.Size = new System.Drawing.Size(196, 87);
            this.btnperro.TabIndex = 1;
            this.btnperro.Text = "PERRO";
            this.btnperro.UseVisualStyleBackColor = true;
            this.btnperro.Click += new System.EventHandler(this.btnperro_Click);
            // 
            // btngato
            // 
            this.btngato.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btngato.Location = new System.Drawing.Point(390, 132);
            this.btngato.Name = "btngato";
            this.btngato.Size = new System.Drawing.Size(190, 87);
            this.btngato.TabIndex = 2;
            this.btngato.Text = "GATO";
            this.btngato.UseVisualStyleBackColor = true;
            this.btngato.Click += new System.EventHandler(this.btngato_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 326);
            this.Controls.Add(this.btngato);
            this.Controls.Add(this.btnperro);
            this.Controls.Add(this.label1);
            this.Name = "principal";
            this.Text = "principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnperro;
        private Button btngato;
    }
}