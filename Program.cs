using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week6_3");
            const double c = 30.125;
            int u = 200,U;
            Console.WriteLine("匯率:" + c + "，美金:" + u +"元，可換新臺幣" + c*u);
            Console.Write("請輸入美金數量:");
            U = Int32.Parse(Console.ReadLine());
            Console.WriteLine("匯率:" + c + "，美金:" + U + "元，可換新臺幣" + c * U);

            Console.ReadLine();
        }
    }
}
