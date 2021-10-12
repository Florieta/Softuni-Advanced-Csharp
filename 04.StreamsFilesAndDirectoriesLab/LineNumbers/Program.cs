using System;
using System.IO;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader srt = new StreamReader("Input.txt"))
            {
                string line = await srt.ReadLineAsync();
                using(StreamWriter wrt = new StreamWriter("Output.txt"))
                {
                    int count = 1;
                    while (line != null)
                    {
                        await wrt.WriteLineAsync($"{count}. {line}");
                        count++;
                        line = await srt.ReadLineAsync();
                    }
                }
            }
        }
    }
}
