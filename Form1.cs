using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contribuinte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            calculac calc = new calculac();
            nav(calc, content);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            imprimec imprime = new imprimec();
            nav(imprime, content);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            inclui inc = new inclui();
            nav(inc, content);
        }
        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            excluic ex = new excluic();
            nav(ex,content);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            exibedadosc exibe = new exibedadosc();
            nav(exibe, content);
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculadorac editar = new calculadorac();
            nav(editar, content);
        }
    }
}
