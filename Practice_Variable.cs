using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Variable
    {
        // Field Variable ( 클래스 내에서 사용하는 전역 변수 )
        int var;
        const int MAX = 1024; // 상수 변수 선언, 컴파일 단계에서 값 결정됨
        readonly int MIN; // 상수 변수 선언 2  , 런타임 단계에서 값 결정됨(객체 할당 시)

        public void Method()
        {
            // Local Variable ( 지역 변수 )
            int localVar = 1;

            Console.WriteLine(var);
            Console.WriteLine(localVar);
            
            // string + 변수의 형태로 출력 가능
            Console.WriteLine("MAX : " + MAX);
            Console.WriteLine("MIN : " + MIN);
        }

        // public void Practice_Variable()
        // 클래스와 같은 함수 이름으로 만들 수 없음.
        public Practice_Variable() // 생성자
        {
            // MAX = 0; -> MAX는 const이기 때문에 생성자에서 할당 불가
            MIN = -1; //   MIN은 Readonly이기 때문에 생성자에서 할당이 가능함.
        }
    }
}
