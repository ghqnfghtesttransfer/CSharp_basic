using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Datatype
    {
        public void Method()
        {
            /* Difference Variable type between C++ and C#
             * 
             *  모든 변수 타입은 C#이 System.foobar 와 같은 형식으로 컴파일하여 .NET 데이터 타입으로 변경함
             * 
             *      sbyte            : 8비트 signed integer
             *      ushort           : 16비트 unsigned integer
             *      uint             : 32비트 unsigned integer
             *      ulong            : 64비트 unsigned integer
             *      decimal          : 128비트 decimal     
             *          => Decimal : 고정소수점. 부동소수점 방식인 double에 비해 메모리 비용 높음
             *      DateTime         : 날짜, 시간
             *      object           : 모든 타입의 기본 클래스로 모든 유형 포함.
             *          Q) Wrapper 클래스를 의미하는가?
             * */

            // System namespace를 사용 중이기 때문에 아래와 같은 행동이 가능.
            DateTime dt = new DateTime(2020, 12, 24, 14, 08, 0);

            // 포인터 형식인지 아닌지는 모르겠으나 자동으로 다른 타입의 변수와 호환이 가능하다.
            Object obj = dt;
            
            // 출력이 자유로움
            // Console.WriteLine(obj);

            /* Nullable Type
             * 
             * 일반적인 Value type의 변수는 NULL 값을 가질 수 없어 다음과 같은 방식으로
             * Value type 변수를 .NET의 Nullable<T> 타입으로 변환시킨다.
             * 
             * ex) int? i = null;
             * 
             * Nullable type 변수 -> Value type의 형식으로 데이터를 받아올 수도 있다.
             * ex) Nullable<int> j = null;
             * j = 10;
             * int k = j.value;
             * 
             * *** 사용 예시로는 DB에 NULL이 허용된 INT 컬럼이 있을 경우 매핑이 가능하다.
             * 
             */
            
             int? i = null;          
            // Console.WriteLine(i);
        }
    }
}
