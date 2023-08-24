
namespace GDI
{
    partial class frmArkanoid
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
            this.components = new System.ComponentModel.Container();
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(-2, -2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(611, 457);
            this.contenedor.TabIndex = 0;
            this.contenedor.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(208, 146);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(204, 133);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // frmArkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.contenedor);
            this.Name = "frmArkanoid";
            this.Text = "frmArkanoid";
            this.Load += new System.EventHandler(this.frmArkanoid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArkanoid_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmArkanoid_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Timer temporizador;
    }
}