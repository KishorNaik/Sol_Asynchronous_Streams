using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sol_Asynchronous_Streams
{
    class Program
    {
         static void Main(string[] args)
        {


            Task.Run(async () => {
                await foreach (var i in GnerateNumber())
                {
                    Console.WriteLine(i);
                }
            }).Wait();

            
        }

        private async static IAsyncEnumerable<int> GnerateNumber()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
