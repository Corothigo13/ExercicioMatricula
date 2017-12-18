using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Matricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Matricular_Click(object sender, EventArgs e)
        {
            Form_Matricula matri = new Form_Matricula();
            matri.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Pesquisar pesq = new Form_Pesquisar();
            pesq.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Administrar admin = new Form_Administrar();
            admin.ShowDialog();
        }
    }
}
