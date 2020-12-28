using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Use_method
    {
        private void Calculate(int a) // for Practice_Method, call by value
        {
            a *= 2;
        }
        private void Calculate(ref int a) // for Practice_method, call by reference
        {
            a *= 2;
        }
        private string stringCat(string name, int num)
        {
            return string.Format("num : {0}, name : {1}", num, name);
        }
        /*
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

            // 7) Iteration
            // var PItmp = new Practice_Iteration();
            // var를 이용하여 다양한 클래스 혹은 타입의 변수를 생성할 수 있다.
            // Q) var를 이용할 때와 클래스 혹은 타입명 전체를 이용할 때의 차이점은 무엇일까?
            // PItmp.Method();
            // PItmp.Method2();

            // 8) Yield
            // 일단 패스

            // 9) Exception
            // Practice_Exception.cs 에 정리

            // 10) Namespace
            // using tmpNamespace를 위에 추가하여 
            // 새로운 namespace인 tmpNamespace를 참조하면 더 간결하게 이용할 수 있다.
            // tmpNamespace.Practice_Namespace PNtmp = new tmpNamespace.Practice_Namespace();
            // PNtmp.Method();

            // 11) Struct
            // Practice_Struct PSTtmp = new Practice_Struct();
            // PSTtmp.Method(1, 2);

            // 12) Class
            // Practice_Class PCLtmp = new Practice_Class();
            // PCLtmp.Name = "ho";
            // PCLtmp.Age = 28;
            // PCLtmp.Name = "real";
            // Q) name에 대해 변경했을 때 이벤트가 작동했음을 확인할 수 있는 방법은 무엇인가?
            // Console.WriteLine(PCLtmp.GetCustomerData());

            // 13) Nullable -> Datatype에 포함

            // 14) Method
            Use_method tmp = new Use_method();
            int val = 100;
            // call by value
            Console.WriteLine("val : {0}", val);
            tmp.Calculate(val);
            Console.WriteLine("val : {0}", val);

            // call by Reference
            Console.WriteLine("val : {0}", val);
            tmp.Calculate(ref val);
            Console.WriteLine("val : {0}", val);

            // 비슷한 기능을 하는 것으로 out 키워드가 있음 ( ex. out val )
            // ref변수는 반드시 초기화를 필요로 하지만 out 변수는 초기화를 하지 않아도 가능.

            Console.WriteLine(tmp.stringCat(num: 5, name: "ho"));
            // method의 파라미터 이름을 직접 지정하여 굳이 정해진 함수 파라미터의 순서대로
            // 기입하지 않아도 함수를 실행시킬 수 있다.

            // *** Optional 파라미터 : method의 파라미터에 기본 값을 설정한다.
            // optional 파라미터는 반드시 optional이 아닌 파라미터들 뒤에 위치해야 한다.
            // ex) public void do_something(int a, int b, int c = 0, int d = -1) {}

            // *** params 파라미터 : 가변적인 배열을 인수로 갖게 해준다.
            // 반드시 하나의 method에 하나만 존재할 수 있으며, 맨 마지막에 위치해야 한다.
            // ex) public void do_something(string a, string b, params int[] values) {}

            // Console 자동 종료 방지
            // Console.ReadLine() : 엔터 키 입력 시 콘솔 종료
            Console.ReadKey(); //  아무 키 입력 시 콘솔 종료,
            // 실질적으로는 키보드 입력을 받는 역할이지만 키입력을 받고 추가 행동을 진행하지 않아
            // 키 입력 후에 콘솔을 종료하는 행동인 것 처럼 보이는 것.

        }
        */
    }
}
