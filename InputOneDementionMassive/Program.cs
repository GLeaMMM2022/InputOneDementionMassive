using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOneDementionMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод элементов массива в столбик
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
