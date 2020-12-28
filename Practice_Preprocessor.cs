#define TEST_ENV
//#define PROD_ENV

#define STANDARD_EDITION
//#define ENTERPRISE_EDITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Preprocessor
    {
        public void Method()
        {
            bool verbose = false;
#if (TEST_ENV) // 본 파일의 상단, #define TEST_ENV가 선언된 경우, 해당 구문을 작동.
            Console.WriteLine("Test Env : option is set");
            verbose = true;
#else          // TEST_ENV가 선언되지 않은 경우, endif까지의 코드 블록을 작동.
            Console.WriteLine("Production");
#endif         // if문 종료를 알림.
               // 해당 전처리기 지시어는 다른 파일에서 define된 foo_var를 바탕으로도 사용할 수 있음.
        }

        #region Public Methoads
        // region 과 endregion 사이의 메소드들에 대해 논리적으로 묶어
        // 코드의 가독성을 높힌다. region과 endregion은 반드시 한 쌍으로 기재하여야 한다.
        public void Run() { }
        public void Create() { }
        #endregion


        /* 기타 전처리기 지시어
         * #undef : #define으로 지정된 심볼 해제 시 사용
         * #elif : #if와 함꼐 사용, else if 약어
         * #line : 거의 사용하지 않음, 라인번호를 임의로 변경(?), 파일명을 임의로 다르게 설정 가능(?)
         * #error : Preprocessing을 중단하고 에러 메시지를 출력함.
         * #warning : 경고 메시지를 출력하지만 preprocessing은 마저 진행.
         */
        public void Method2()
        {
#if (!ENTERPRISE_EDITION)
#warning This class should be used in Enterprise Edtion
#endif

            // #error 예제 -----
            // ENTERPRISE_EDITION과 STANDARD_EDITION은 파일 상단에 define되어있음.
#if (STANDARD_EDITION && ENTERPRISE_EDITION)
#error Use either STANDARD or ENTERPRISE edition
#endif

        }

        // #pragma를 이용하여 warning을 무력화시킬 수도 있음.
        // -> 빠른 정보 획득이 중요한 상황에서는 이용할만하지만 일반적인 코드 구현 단계에서는
        // 되도록 사용하지 않는 것이 좋아보임.
        // ex. CS3021 warning을 무시 -> #pragma warning disable 3021

    }
}
