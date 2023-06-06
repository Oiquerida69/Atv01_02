using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01Textos
{
    class Program
    {
        static void Main(string[] args)
        {
            // comando /n é para pular linhas
            // comando console.write , serve para escrever
            // comando console.writeline, server para escrever e pular uma linha
            Console.WriteLine("Bem-vindo a Cafetaria do Conradito \n \n");
            Console.WriteLine("Essas são nossas opções");
            Console.WriteLine("- Café expresso R$ 2,50");
            Console.WriteLine("- Capuccino R$3,00");
            Console.WriteLine("- Mocca R$4,000 \n \n \n");
            Console.WriteLine("Volte sempre");
            //sempre usar ; no final

            Console.Read(); // esse comando trava a tela , o comando ReadKey tambem


        }
    }
}
