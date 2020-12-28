using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Condition
    {
        static bool v = false;
        static bool c = false;
        static bool l = false;
        public void Method()
        {
            string args = Console.ReadLine();
            if (args.Length < 1)
            {
                Console.WriteLine("Usage : App.exe options");
                return;
            }
            string option = args;

            switch (option.ToLower())
            {
                case "/v":
                    v = true;
                    Console.WriteLine("V True");
                    break;
                case "/c":
                    c = true;
                    Console.WriteLine("C True");
                    break;
                case "/l":
                    l = true;
                    Console.WriteLine("l True");
                    break;
                default:
                    Console.WriteLine("Unknown argument {0}", option);
                    break;
            }

            /*
             * Q) Method에 string args[]를 넘기는 방식으로 Console Data를 읽어오려
             * 사이트에 기재된 방식을 따라해보았으나 알 수 없는 문제가 발생함.
             * */
            /*
             static void Main(string[] args)
            {            
                if (args.Length != 1)
                {
                    Console.WriteLine("Usage: MyApp.exe option");
                    return;
                }

                string option = args[0];
                switch (option.ToLower())
                {
                    case "/v":
                    case "/verbose":
                        verbose = true;                    
                        break;
                    case "/c":
                        continueOnError = true;
                        break;
                    case "/l":
                        logging = true;
                        break;
                    default:
                        Console.WriteLine("Unknown argument: {0}", option);
                        break;
                }
            }
             */
        }
    }
}
