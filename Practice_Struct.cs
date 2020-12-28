using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Struct
    {
        // Value type : int, double 등의 기본 데이터 타입
        // Reference type : Class를 정의하여 만들며 상속이 가능, Heap 상의 객체에 대한 레퍼런스를
        // 전달하며 이루어짐.
        //  -> ex) String, Array, List, etc.
        struct _struct
        {
            public int x;
            public int y;
            public _struct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString() 
            {
                // *** ToString() 함수는 다른 namespace 및 클래스에서 사용하는 함수이다.
                // 사용처 및 사용 방식이 다른 것을 확실히 명시하기 위해 override를 적어준다.
                return string.Format("({0}, {1})",x, y);
            }
        }
        public void Method(int x, int y)
        {
            _struct tmp = new _struct(x, y);
            Console.WriteLine(tmp.ToString());
        }
        
    }
}
