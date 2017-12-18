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
    public partial class Form_Pesquisar : Form
    {
        public Form_Pesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream arq = new FileStream("Alunos.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string[] turma;
            string linha;
            string turmatotal="";
            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    turma = linha.Split('|');
                    if (turma[2] == txt_pesq.Text)
                    {
                        turmatotal = turmatotal + turma[0] + "\r\n";
                    }
                }
                   /* else
                    {
                        turmatotal = "Não existem turmas desse curso";
                    }
                    */
            } while (linha != null);
            ler.Close();
            label_resultPesq.Text = turmatotal;

        }

    }
}
