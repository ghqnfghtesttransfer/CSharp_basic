using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Enum
    {
        // enum은 네임스페이스와 클래스 전역변수에서만 생성 가능.
        enum port
        {
            none,
            ftp = 21,
            sftp = 22,
            dns = 53,
            http = 80
        }
        // 생성자를 private으로 만들면 클래스 생성 시 오류 발생
        // Q) 상속을 받은 클래스는 부모 클래스가 생성자를 private으로 만들어도 사용할 수 있을까?

        // Flags enum : enum으로 생성된 변수는 OR 연산을 이용하여 한 변수 내에 플래그
        // 두 개 이상을 가지고 있을 수 있으며 이를 이용한 코딩이 가능.
        [Flags]
        enum Arrows
        {
            none,
            Top,
            Bottom,
            Left,
            Right
        }
        public Practice_Enum()
        {
            
        }
        public void Method()
        {
            // enum 변수의 정수화를 통해 정수 출력
            port _port = port.sftp;
            int sftp_val = (int)_port;
            // Console.WriteLine(_port.GetType());
            // Console.WriteLine(sftp_val.GetType());

            Arrows tmp = Arrows.Bottom | Arrows.Right;

            // 숫자 0과 ==, != 만을 이용하여 플래그 체크 가능
            //if ((tmp & Arrows.Left) != 0)
            // -> 단순 논리 연산이여서 조건문이 만족되었음, 확실한 값 확인을 위해 &&을 이용할 것.
            if (tmp.HasFlag(Arrows.Bottom) & tmp.HasFlag(Arrows.Right))
            {
                Console.WriteLine("{0} is here",tmp.ToString());
            }
        }


    }
}
