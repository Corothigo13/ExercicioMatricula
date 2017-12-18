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
    public partial class Form_confirmaçãoMatricula : Form
    {
        public Form_confirmaçãoMatricula(string matri)
        {
            InitializeComponent();
            txt_Matri.Text = matri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
