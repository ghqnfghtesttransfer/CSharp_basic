using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Exception
    {
        public void Method()
        {
            try
            {
                // 실행하고자 하는 코드
            }
            /*catch(Exception ex)
            {
                // 모든 exception을 잡고자 할 때
            }*/
            catch(ArgumentException aex)
            {
                // 특정 exception을 잡아 해당 exception에 대한 커맨드 처리
                // throw를 이용하여 Argument Exception이 발생했음을 알림
                throw new Exception("Argument Exception", aex);
            }
            catch(Exception ex)
            {
                // ArgumentException을 제외한 모든 Exception을 처리
                // Exception에 대해 아무런 처리를 하지 않는다면 Exception이 발생해도 무시하고
                // 넘어가는 형태로 코드가 진행된다.
            }
            finally
            {
                // try나 exception 처리 이후 반드시 실행되는 코드
            }
            
        }
    }
}
