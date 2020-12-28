using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Use_method
    {
        static void Main(string[] args)
        {
            // 기본 출력 방식
            // System : namespace. root namespace는 global이며 System namespace는 원래 global::System임.
            // System.Console : .NET Framework 클래스
            // System.Console.WriteLine("Hello World...");

            // 클래스 선언 시에는 new를 이용해 새로운 객체 할당


            // 1) Datatype
            // Practice_Datatype PDtmp = new Practice_Datatype();
            // PDtmp.Method();

            // 2) Variable
            // Practice_Variable PVtmp = new Practice_Variable();
            // PVtmp.Method();

            // 3) Array
            // Practice_Array PAtmp = new Practice_Array();
            // PAtmp.Method();

            // 4) String
            // Practice_String PStmp = new Practice_String();
            // PStmp.StringMethod();
            // PStmp.StringBuilderMethod();

            // Q) obj로 새로운 클래스를 받아와 Type을 확인해 보면 해당 클래스와 맞으나
            // Method나 property에는 접근할 수 없는 이유..?
            // Object obj = PStmp;
            // Console.WriteLine(obj.GetType());

            // 5) Enum
            // Practice_Enum PEtmp = new Practice_Enum();
            // PEtmp.Method();

            // 6) Condition
            // Practice_Condition PCtmp = new Practice_Condition();
            // PCtmp.Method();

            // 7) 


            // Console 자동 종료 방지
            // Console.ReadLine() : 엔터 키 입력 시 콘솔 종료
            Console.ReadKey(); //  아무 키 입력 시 콘솔 종료,
            // 실질적으로는 키보드 입력을 받는 역할이지만 키입력을 받고 추가 행동을 진행하지 않아
            // 키 입력 후에 콘솔을 종료하는 행동인 것 처럼 보이는 것.

        }
    }
}
