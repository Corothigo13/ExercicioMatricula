using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicação_Matricula
{
    class class_Professor
    {
        public void getProf()
        {
            string n="";
            string materia="";
            string ncurso="";
            string horario="";
            FileStream arq = new FileStream("Professor.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            /*n = txt_nomeProf.Text;
            materia = txt_MateriaProf.Text;
            ncurso = box_CursoProf.Text;
            horario = box_horarioProf.Text;*/
            escreve.Write(n + "|" + materia + "|" + ncurso + "|" + horario);
            escreve.Close();

        }
    }
}
