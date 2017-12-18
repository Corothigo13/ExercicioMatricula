using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicação_Matricula
{
    public class class_Aluno
    {
        public double getAluno(string n, string cpf, string ncurso)
        {
            FileStream arq = new FileStream("Alunos.txt", FileMode.OpenOrCreate);
            StreamWriter escreve = new StreamWriter(arq);
            double NumMatricula = 0;
            Random randow = new Random();
            NumMatricula = randow.Next(1, 999999);
            //n = txt_nomeMatricula.Text;

            escreve.Write(n + "|" + cpf + "|" + ncurso + "|" +  NumMatricula);
            escreve.Close();
            return NumMatricula;
        }

    }
}
