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
            File.WriteAllText(@"D:\기타\test.txt", "문자열을 넣습ㄴㅣ다");
        }
    }
}
