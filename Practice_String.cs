using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_String
    {
        // *** C# 문자열은 한 번 생성되면 다시 변경할 수 없다.
        // >> string 타입의 변수에 대해 값을 변경하면 겉으로 보기엔 데이터가 변경되지만
        // 실질적으로는 기존의 변수와 같은 이름을 가진 새로운 변수를 다른 메모리에 할당하며
        // 이를 사용자에게 보여준다. (주1)
        
        public string s1;
        string s2;

        char c1;
        char c2;

        public Practice_String()
        {
            // (주1)
            s1 = "ab";
            s1 = "abc";

            s2 = "bed";

            c1 = '+';
            c2 = '-';
        }
        public void StringMethod()
        {
            string tmp = (s1 + "-" + s2); // 문자 하나만 넣을 때 " "도 가능
            Console.WriteLine("tmp : {0}", tmp); // {0} : 0번째 인덱스에 있는 변수

            string tmp2 = (s1 + c1 + s2 + c2); // 문자열과 문자의 조합도 가능
            Console.WriteLine("tmp : {0}, tmp2 : {1} ", tmp, tmp2);

            int SIndex = 1;
            int LIndex = 3;
            string tmp3 = tmp2.Substring(SIndex, LIndex); // SIndex부터 LIndex까지
            Console.WriteLine("tmp3 : {0}, \nStart : {1}, Last : {2}", tmp3, SIndex, LIndex);
            // c처럼 \n으로 개행문자 이용 가능
            // {(int)}를 이용하여 자유로운 데이터 출력 가능

            // 문자열 -> 문자배열로 변환, 이를 이용해 index로 접근할 수 있다.
            char[] charArr = tmp2.ToCharArray();
            // 문자배열 -> 문자열 변환은 아래와 같이 이루어짐.
            // string s = new string(charArr);

            // *** string에는 []을 이용하여 접근 불가
            // Console.WriteLine(tmp2[1]);
            Console.WriteLine(charArr[1]);
        }
        public void StringBuilderMethod()
        {
            // *** string이 값이 변경되면 변수를 새로 만드는 것과 다르게
            // string builder는 고정된 메모리에 대해 작동이 이루어진다.
            // stringBuilder를 사용하는 것이 string을 사용하는 것보다 효율적이다
            // -> string에 대한 값 변경은 내부적으로 적어도 3줄 이상의 코드가 진행되기 때문
            // String builder는 클래스로 생각하여 사용.

            StringBuilder sb = new StringBuilder();
            for(int i = 1; i < 10; i++)
            {
                // Append의 파라미터는 string으로 할 것.
                // ToString()을 이용하여 다른 데이터 타입을 string으로 변환할 수 있다.
                sb.Append(i.ToString() + ' ');
            }
            Console.WriteLine(sb); // String builder 그 자체를 출력할 수도 있다.

            // String builder clear로 string builder를 초기화할 수 있다.
            sb.Clear();
            for(double x = 0.0; x < 1.0; x += 0.1)
            {
                sb.Append(x.ToString()+' ');
            }
            Console.WriteLine(sb);

            // Q) new/delete 처럼 선언된 클래스를 소멸시키는 방법이 있는가?
        }
    }
}
