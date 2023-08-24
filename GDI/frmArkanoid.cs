using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class frmArkanoid : Form
    {   
        Pen lapiz = new Pen(Color.Blue);
        Graphics lienzo;
        public frmArkanoid()
        {
            InitializeComponent();
        }

        private void frmArkanoid_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnJugar.Hide();
            lienzo = contenedor.CreateGraphics();
            lienzo.DrawRectangle(lapiz, 230, 320, 150, 70);
            temporizador.Enabled = true;
        }

        int ejeX, ejeY = 0;
        Random aleatorioX = new Random();
        Random aleatorioY = new Random();

        private void frmArkanoid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmArkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar = Left)
            //{
            //    MessageBox.Show("Test");
            //}
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            ejeX = aleatorioX.Next(0, 500);
            ejeX = aleatorioY.Next(0, 500);

            lienzo.DrawRectangle(lapiz, ejeX, ejeY, 150, 700);

        }
    }
}
