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
            List<int> randomNumber = new List<int>();
            List<int> userNumber = new List<int>();
            // 컴퓨터의 번호 3개 출력
            randomNumber = computer.GetComputerNumber().ToList();

            // 플레이어가 정한 번호 3개 출력
            InputUserNumber(userNumber);

            // 컴퓨터 번호와 플레이어 번호를 비교
            Result(randomNumber, userNumber);


        }

        /// <summary>
        /// 컴퓨터 번호와 플레이어 번호를 비교한 결과를 판정한다. 
        /// 서로 번호가 일치하면 Ball, 일부만 틀리면 Strike, 전부 다 틀리면 Out 
        /// </summary>
        /// <param name="randomNumber"></param>
        /// <param name="userNumber"></param>
        private static void Result(List<int> randomNumber, List<int> userNumber)
        {
            //int totalCount = 3;
            List<int> allNumber = new List<int>();
            int idx = 0;
            int countZero = 0;
            int BallCount = 0;
            int StrikeCount = 0;
            int OutCount = 0;

            // 0부터 9까지의 숫자 리스트
            while (idx < 10)
            {
                allNumber.Add(idx);
                idx++;
            }
            // 모두 같으면 BallCount = 3
            // 모두 다르면 OutCount = 3
            // 일부가 같으면 BallCount++, 일부가 다르면 StrikeCount++
            // OutCount인 경우 숫자 0-9 목록에서 해당 숫자 제거
            while (allNumber.Count > 3)
            {
                foreach (var com in randomNumber)
                {
                    bool isSameNumber = userNumber.Contains(com);

                    if (isSameNumber)
                        BallCount++;

                    else if (BallCount != countZero && !isSameNumber)
                        StrikeCount++;

                    else if (BallCount == countZero && StrikeCount == countZero)
                    {
                        OutCount++;
                        //allNumber.Contains()
                    }
                }

                Console.WriteLine($"Ball: {BallCount} \nStrike: {StrikeCount} \nOut:{OutCount}");
            }
        }

        private static void InputUserNumber(List<int> userNumber)
        {
            while (userNumber.Count < 3)
            {
                Console.WriteLine("유저의 숫자 입력");

                string inputString = Console.ReadLine();
                int saveUserNum = int.Parse(inputString);

                if (userNumber.Count < 3 && !userNumber.Contains(saveUserNum))
                    userNumber.Add(saveUserNum);

                else if (userNumber.Contains(saveUserNum))
                    Console.WriteLine("이미 있는 번호입니다. 다시 입력해 주세요.");
            }
        }
    }
}
