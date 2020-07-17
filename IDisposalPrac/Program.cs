using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposalPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.WriteAllText(@"D:\기타\test.txt", "다른 문자열을 넣습ㄴㅣ다");
            //Console.WriteLine(File.ReadAllText(@"D:\기타\test.txt"));
            
            //var file = @"D:기타\test.txt";
            //Console.WriteLine(File.ReadAllText(file));

            using (StreamWriter writer = new StreamWriter(@"D:\기타\test.txt"))
            {
                writer.WriteLine("eilce.io");

                for(int i=1; i<=10; i++)
                {
                    writer.WriteLine("<반복문>안녕하세요 "+i+"트");
                }

            }
            Console.WriteLine(File.ReadAllText(@"D:\기타\test.txt"));
        }
    }
}
