using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aplicação_Matricula
{
    public partial class Form_Matricula : Form
    {
        public Form_Matricula()
        {
            InitializeComponent();
        }

        private void Form_Matricula_Load(object sender, EventArgs e)
        {
        }

        private void b_confirmaMatri_Click(object sender, EventArgs e)
        {
            double a;
            a = getAluno();
            Form_confirmaçãoMatricula conf = new Form_confirmaçãoMatricula(Convert.ToString(a));
            conf.ShowDialog();
            this.Close();
        }
        public double getAluno()
        {
            string n;
            string cpf;
            string ncurso;
            FileStream arq = new FileStream("Alunos.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            double NumMatricula = 0;
            Random randow = new Random();
            NumMatricula = randow.Next(1, 999999);
            n = txt_nomeMatricula.Text;
            cpf = txt_CPFMatricula.Text;
            ncurso = box_CursoMatricula.Text;
            escreve.WriteLine(n + "|" + cpf + "|" + ncurso + "|" + NumMatricula);
            escreve.Close();
            return NumMatricula;

        }
    }
}
