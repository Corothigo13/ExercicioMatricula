using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicação_Matricula
{ //usar o cerverttoDateTime para comparar os horarios
    class class_Disciplina 
    {
        public void getdisciplina(string curso)
        {
            FileStream arq = new FileStream("Disciplinas.txt", FileMode.Open);
            StreamWriter escrever = new StreamWriter(arq);
            if (curso == "Sistemas de Informação")
            {
                escrever.Write("Sistemas de Informação | Algoritmos e Tecnicas de Programação | 3 | 19:00 | 20:40");
                escrever.Write("Sistemas de Informação | Introdução a Administração | 2 | 19:00 | 20:40");
                escrever.Write("Sistemas de Informação | Filosofia I | 4 | 19:00 | 20:40");
                escrever.Write("Sistemas de Informação | Introdução a Computação | 5 | 19:00 | 20:40");
                escrever.Write("Sistemas de Informação | Fundamentos da Matematica Discreta| 6 | 19:00 | 20:40");
                escrever.Write("Sistemas de Informação | Laboratorio de ATP | 3 | 20:50 | 22:30");
                escrever.Write("Sistemas de Informação | Algoritmos e Tecnicas de Programação | 6 | 20:50 | 22:30");
                escrever.Write("Sistemas de Informação | Introdução a Administração | 4 |  20:50 | 22:30");
                escrever.Write("Sistemas de Informação | Filosofia I | 5 |  20:50 | 22:30");
                escrever.Write("Sistemas de Informação | Introdução a Computação | 2 |  20:50 | 22:30");
                escrever.Write("Sistemas de Informação | Fundamentos da Matematica Discreta| 4 |  20:50 | 22:30");
            }
            //Fim materias Sistemas
            if (curso == "Direito")
            {
                escrever.Write("Direito | Leis I | 3 | 19:00 | 20:40");
                escrever.Write("Direito | Introdução ao Direito | 2 | 19:00 | 20:40");
                escrever.Write("Direito | Filosofia I | 4 | 19:00 | 20:40");
                escrever.Write("Direito | Sociologia I | 5 | 19:00 | 20:40");
                escrever.Write("Direito | Estudos dos Crimes | 6 | 19:00 | 20:40");
                escrever.Write("Direito | Laboratorio | 3 | 20:50 | 22:30");
                escrever.Write("Direito | Leis I | 6 | 20:50 | 22:30");
                escrever.Write("Direito | Introdução ao Direito | 4 |  20:50 | 22:30");
                escrever.Write("Direito | Filosofia I | 5 |  20:50 | 22:30");
                escrever.Write("Direito | Sociologia I | 2 |  20:50 | 22:30");
                escrever.Write("Direito | Estudos dos Crimes | 4 |  20:50 | 22:30");
            }
            //Fim materias do direito
            if (curso == "Engenharia Civil")//esses ifs deveriam ser no aluno para gerar a grade
            {
                escrever.Write("Engenharia | Matematica I | 3 | 19:00 | 20:40");
                escrever.Write("Engenharia | Introdução a Engenharia | 2 | 19:00 | 20:40");
                escrever.Write("Engenharia | Filosofia I | 4 | 19:00 | 20:40");
                escrever.Write("Engenharia | Arquitetura | 5 | 19:00 | 20:40");
                escrever.Write("Engenharia | Fisica I | 6 | 19:00 | 20:40");
                escrever.Write("Engenharia | Laboratorio | 3 | 20:50 | 22:30");
                escrever.Write("Engenharia | matematica I | 6 | 20:50 | 22:30");
                escrever.Write("Engenharia | Introdução a Engenharia | 4 |  20:50 | 22:30");
                escrever.Write("Engenharia | Filosofia I | 5 |  20:50 | 22:30");
                escrever.Write("Engenharia | Aquitetura | 2 |  20:50 | 22:30");
                escrever.Write("Engenharia | Fisica | 4 |  20:50 | 22:30");
            }
            //Fim das materia de Engenharia


            escrever.Close();


        }
    }
}
