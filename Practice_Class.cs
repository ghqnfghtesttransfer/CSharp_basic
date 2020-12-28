using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpProgramming
{
    class Practice_Class
    {
        // class에 포함되는 기본 4속성
        // 필드
        private string name;
        private int age;
        private int count;
        
        // 이벤트
        public event EventHandler NameChanged;
        
        // 생성자
        public Practice_Class()
        {
            name = string.Empty;
            age = -1;
            count = 0;
        }

        // 속성
        public string Name
        {
            // public으로 private 변수에 대한 접근을 구현한다.
            // get : public string Name (ex. console.writeline( class.Name))의 형태로 접근하면 
            // 자동으로 get에 매핑되어 get에 적힌 코드 실행. ( RHS, function 내부, 조건 등)
            // Q) return만 되는건가?
            get
            {
                return this.name;
            } 
            set
                // set : 
            {
                if(this.name != value) // Q) value는 어디서 나온 변수인데 선언 없이 사용가능?
                                       // A) value는 선언된 클래스에 값에 대한 변경을 이용할 경우
                                       // right-hand-side에 선언된 값이다.
                {
                    this.name = value;
                    count++;
                    this.name += string.Format(", mem_cnt : {0}", count);
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }
        public int Age
        {
            get { return this.age;  }
            set { this.age = value;  }
        }
        public string GetCustomerData()
        {
            
            string data = string.Format("name : {0}, age : {1}", this.name, this.age);
            return data;
        }
    }
}
