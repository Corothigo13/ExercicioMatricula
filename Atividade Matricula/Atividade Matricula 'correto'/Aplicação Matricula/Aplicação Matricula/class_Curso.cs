using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicação_Matricula
{
    class class_Curso
    {
        public void getCurso()
        {
            FileStream arq = new FileStream("Cursos.txt", FileMode.Open);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.Write("Sistemas de Informação");
            escreve.Write("Medicina");
            escreve.Write("Direito");
            escreve.Write("Engenharia Civil");
            escreve.Write("Ciencia da Computação");
            escreve.Close();
        }
    }
}
