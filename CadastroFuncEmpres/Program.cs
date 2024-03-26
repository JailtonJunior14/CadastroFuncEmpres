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
            int func;
            double salario;

            Console.WriteLine("Numero de funcionario que serão cadastrados:");
            func = int.Parse(Console.ReadLine());
            int cont = 0;
            func = "S"

            while (func = "s")
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
                        //contsal = contsal + salario;
                        break;
                    case "c":
                        Console.WriteLine("Informe a quantidade de produtos: ");
                        double produto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor da comissão: ");
                        double comi = double.Parse(Console.ReadLine());
                        salario = (produto * comi);
                        Console.WriteLine("O salario e: " + salario);
                        //contsal = contsal + salario;
                        break;
                    case "h":
                        Console.WriteLine("Informe o valor da hora: ");
                        double vhora = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                        double qhora = double.Parse(Console.ReadLine());
                        sal = vhora * qhora;
                        //contsal = contsal + sal;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                        contsal = contsal + sal;

                }
                Console.WriteLine(contsal);
            }

            Console.ReadKey();
        }
    }
}
