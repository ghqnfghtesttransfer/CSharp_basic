using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics; // *** Debug 클래스가 포함된 namespace

namespace CSharpProgramming
{
    class Practice_Iteration
    {
        public void Method()
        {
            string[,,] arr = new string[,,] {
                    { {"1", "2"}, {"11","22"} },
                    { {"3", "4"}, {"33", "44"} }
                };
            
            foreach (var s in arr)
            {
                // string test = "44";
                // Debug.WriteLine(s);
                // Debug.Assert(!s.Equals(test),test + " is not allowed");
                // *** Debug에 다양한 method가 있음. 예외처리에 활용하면 좋을 것으로 보임.

                Console.WriteLine(s);
            }
            // for는 3차원 배열의 모든 원소에 접근하기 위해 length를 이용하여 직접적인 접근 필요
            // foreach는 순차적으로 자동 인덱싱 가능
        }
        public void Method2()
        {
            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                keyList.Add(key.KeyChar); // List는 add, Stringbuilder는 append
                //Console.WriteLine(" > {0} is Added", key.KeyChar);
            }
            while (key.Key != ConsoleKey.Q);
                        
            foreach (char c in keyList)
            {
                Console.Write(c);
            }
        }
    }
}
