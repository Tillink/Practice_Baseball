using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBaseball

{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerNumber computer = new ComputerNumber();
            // 컴퓨터의 번호 3개 출력
            computer.GetComputerNumber();

            // 플레이어가 정한 번호 3개 출력

            // 컴퓨터 번호와 플레이어 번호를 비교
            

            // 모두 같거나 모두 다르지 않다는 조건 하에  1< 숫자 비교결과 <=2  같으면 Ball, 다르면 Strike
            // 모두 같으면 3 Ball
            // 모두 다르면 3 Out ( 숫자 0-9 목록에서 해당 숫자 제거 )

        }
    }
}
