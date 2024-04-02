using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncEmpres
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            double contsal = 0;
            string func;
            double salario;

            Console.WriteLine("Deseja iniciar? S/N");
            func = Console.ReadLine().ToLower();
            int cont = 0;

            while (func == "s")
            {
                Console.WriteLine("Informe a forma de contratação: Assalariado(A), Comissionado(C), Horista(H)");
                string contrato = Console.ReadLine().ToLower();
                switch (contrato)
                {
                    case "a":
                        Console.WriteLine("Insira o salario");
                        double sal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o  desconto: ");
                        double desc = double.Parse(Console.ReadLine());
                        salario = (sal - desc);
                        Console.WriteLine("O salario e: " + salario);
                        contsal += salario;
                        cont ++;
                        break;
                    case "c":
                        Console.WriteLine("Informe a quantidade de produtos: ");
                        double produto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor da comissão: ");
                        double comi = double.Parse(Console.ReadLine());
                        salario = (produto * comi);
                        Console.WriteLine("O salario e: " + salario);
                        contsal += salario;
                        cont++;
                        break;
                    case "h":
                        Console.WriteLine("Informe o valor da hora: ");
                        double vhora = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                        double qhora = double.Parse(Console.ReadLine());
                        salario = vhora * qhora;
                        Console.WriteLine("O salario e: " + salario);
                        contsal += salario;
                        cont++;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                        cont++;


                }
                Console.WriteLine("Deseja Continuar? S/N");
                func = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Total folha de pagamento: " + contsal.ToString("C") );
            Console.WriteLine("Numeros de funcionarios: " + cont);
            Console.WriteLine("Media salarial: " + (contsal / cont).ToString("C"));

            Console.ReadKey();
        }
    }
}
