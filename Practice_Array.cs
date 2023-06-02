using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// test for transfer

namespace CSharpProgramming
{
    class Practice_Array
    {
        const int a_size = 3;

        // 기본 배열 선언 방식은 c, c++과 같으나 2,3차 배열 선언이 간편.
        // 최대 32차원 배열까지 가능
        // int[] iarr = { 0, 1, 2, 3 };
        // int[,] d2iarr = { { 0, 0 }, { 0, 1 } };
        // int[,,] d3iarr = { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };


        // 2차원 이상의 배열은 위의 형태와 같이 고정된 배열 형태
        // 혹은 가변 배열(Jagged Array)로 선언이 가능.
        // 가변 배열 선언 시에는 1차원 배열의 크기를 정해줘야함.
        // int[][] j_iarr = new int[3][];

        // 상수 혹은 지역 변수를 넣어서 변수로도 1차원 배열 사이즈 크기를 정할 수 있음.
        // int[][] j_tmp_arr = new int[a_size][];

        // 3차원 이상도 가능함. 1차원 배열 크기만 정해주면 된다.
        // int[][][] j_d3iarr = new int[3][][];
        int[][] tmp = new int[2][];
        // int?[] tt; nullable type array도 가능 

        public Practice_Array()
        {
            // *** 이후, 배열에 포함되는 다른 배열들에 관한 선언 등의 접근은
            // Field가 아닌 method에서 가능하다. (런타임)
            tmp[0] = new int[2] { 0, 1 };
            // tmp[1] = new int[3]; -> 뒤에 initializing을 하지 않는 경우, 0으로 초기화
            tmp[1] = new int[3] { 2, 3, 4 };

            // 단일 데이터에도 접근 가능
            // tmp[0][0] = 1;

            // C#의 Array는 System.Array에서 파생되어 System.Array의 메소드를 이용할 수 있다.
            // ex) .Length
        }
        public void Method()
        {
            // *** ref : 변수를 참조 형식으로 만들어준다.
            // 받는 함수 쪽에서도 변수에 ref를 적어주도록 한다.
            ChangeData(ref tmp[0][0]);
            // 배열을 파라미터로 사용할 때는 배열 이름만 넘긴다.
            Console.WriteLine(Calc(tmp));
        }
        private void ChangeData(ref int x)
        {
            x = 5;
        }
        private int Calc(int[][] tmp)
        {
            // 가변 배열 tmp의 합을 구하는 함수
            int sum = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                for (int j = 0; j < tmp[i].Length; j++)
                {
                    // tmp[i][j] = tmp[i].ElementAt(j)
                    sum += tmp[i].ElementAt(j);
                }
            }

            return sum;
        }
    }
}
