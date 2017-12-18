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
    public partial class Form_Administrar : Form
    {
        public Form_Administrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getProf();
            this.Close();
        }
        public void getProf()
        {
            string n;
            string materia;
            string ncurso;
            string horario;
            FileStream arq = new FileStream("Professor.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            n = txt_nomeProf.Text;
            materia = txt_MateriaProf.Text;
            ncurso = box_CursoProf.Text;
            horario = box_horarioProf.Text;
            escreve.WriteLine(n + "|" + materia + "|" + ncurso +"|"+ horario);
            escreve.Close();

        }

    }
}
