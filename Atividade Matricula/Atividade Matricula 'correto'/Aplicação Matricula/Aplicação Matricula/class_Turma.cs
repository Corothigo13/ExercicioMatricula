using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicação_Matricula
{
    class class_Turma
    {
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream arq = new FileStream("Alunos.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string[] turma;
            string linha;
            string turmatotal = "";
            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    turma = linha.Split('|');
                 //   if (turma[2] == txt_pesq.Text)
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
            //label_resultPesq.Text = turmatotal;
        }

        }
    }
