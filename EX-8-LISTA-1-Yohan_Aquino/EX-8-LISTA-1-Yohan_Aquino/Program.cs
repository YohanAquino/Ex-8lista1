using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_8_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. Entrar com dois valores quaisquer. Exibir o maior deles, se existir, caso contrário, enviar
mensagem avisando que os números são idênticos. */
            Comparador com = new Comparador();

            Console.WriteLine("Digite o 1° valor");
            com.setNum1(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 2° valor");
            com.setNum2(double.Parse(Console.ReadLine()));

            Console.WriteLine("{0}", com.getMaior());
            Console.ReadKey();
        }
    }
}
