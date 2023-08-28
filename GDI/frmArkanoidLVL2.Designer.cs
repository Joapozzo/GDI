namespace GDI
{
    partial class frmArkanoidLVL2
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
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.picNave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(-5, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(805, 451);
            this.contenedor.TabIndex = 3;
            this.contenedor.TabStop = false;
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(362, 375);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 26);
            this.picNave.TabIndex = 5;
            this.picNave.TabStop = false;
            // 
            // frmArkanoidLVL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.contenedor);
            this.Name = "frmArkanoidLVL2";
            this.Text = "frmArkanoidLVL2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArkanoidLVL2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.PictureBox picNave;
    }
}