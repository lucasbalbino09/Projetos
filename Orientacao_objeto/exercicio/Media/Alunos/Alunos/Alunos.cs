using System;
using System.Collections.Generic;
using System.Text;

namespace Alunos
{
    class Alunos
    {
        public string nome;
        public double nota1; 
        public double nota2; 
        public double nota3;
       

        public double CalculoDasNotas()
        {
            return nota1  + nota2 + nota3;
                                    
        }
        public bool Condicao()
        {
            if(CalculoDasNotas() >= 60.0)
            {
                return true;
            } else
            {
                return false; 
            }
        }
        
        public double NotaRestante()
        {
            if (Condicao())
            {
                return 0.0;
            }
            return 60.0 - CalculoDasNotas();
        }
               
    }
}
