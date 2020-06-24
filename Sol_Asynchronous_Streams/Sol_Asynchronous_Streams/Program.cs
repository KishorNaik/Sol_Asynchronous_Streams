using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Sol_Asynchronous_Streams
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await foreach (var i in GenerateNumber())
            {
                Console.WriteLine(i);
            };
        }

        private async static IAsyncEnumerable<int> GenerateNumber()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}