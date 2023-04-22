using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class LacoRepeticaoFor
    {
        // Método público sem retorno e sem parâmetros
        public void Executar()
        {
            Exemplo01();
        }

        // Método privado sem retorno e sem parâmetros
        private void Exemplo01()
        {
            //int indice = 0;
            //while(indice < 5)
            //{
            //    Console.WriteLine("Oie");
            //    // Incrementando a variável indice
            //    indice = indice + 1;
            //}

            // for(declaração da variável; condição para execução do for; incremento)
            for(int indice = 0; indice < 5; indice = indice + 1)
            {
                Console.WriteLine("Oie");
            }
        }

        // Método privado sem retorno e sem parâmetros
        private void Exemplo02() { }
    }
}
