using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp;
            double valt = 0;

            do
            {
                Console.WriteLine("Qual a descrição da despesa? ");
                string desp = Console.ReadLine();

                Console.WriteLine("Qual o valor? ");
                double val = double.Parse(Console.ReadLine());

                valt += val;

                Console.WriteLine("Deseja adicionar mais despesas? Sim/Não ");
                resp = Console.ReadLine();

            } while (resp == "S");
            {
                Console.WriteLine("O gasto total foi de " + valt);
                Console.WriteLine("Quantas pessoas moram na casa? ");
                int pes = int.Parse(Console.ReadLine());

                double gastom = valt / pes;

                Console.WriteLine("O gasto médio por morador é de " +  gastom);

                Console.ReadKey();
            }
        }
    }
}
