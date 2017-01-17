using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFox
{
    class DrawFox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            int eyes = n/2;
            int nose = n;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}", new String('*', i), new String('-', (2*n+1) - 2* i), new String('*' , i));
            }
            for (int j = 1; j <=n/3 ; j++)
            {
                Console.WriteLine("|{0}\\{1}/{2}|", new String('*',eyes), new String('*', (n+2) - 2*j), new String('*',eyes));
                eyes++;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}", new String('-', i), new String('*', (2 * n + 1) - 2 * i), new String('-', i));
            }
        }
    }
}
