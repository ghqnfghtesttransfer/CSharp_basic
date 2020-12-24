using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Use_method
    {
        static void Main()
        {
            // 기본 출력 방식
            // System : namespace. root namespace는 global이며 System namespace는 원래 global::System임.
            // System.Console : .NET Framework 클래스
            // System.Console.WriteLine("Hello World...");
            // 클래스 선언 시에는 new를 이용해 새로운 객체 할당
            
            
            // 1) Datatype
            // Practice_Datatype PD_tmp = new Practice_Datatype();
            // PD_tmp.Method();
            
            Practice_Variable tmp = new Practice_Variable();
            tmp.Method();

            

            // Console 자동 종료 방지
            // Console.ReadLine() : 엔터 키 입력 시 콘솔 종료
            Console.ReadKey(); //  아무 키 입력 시 콘솔 종료
        }
    }
}
