using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBaseball
{
    public class ComputerNumber
    {
        private Random _random = new Random();

        // 컴퓨터가 가진 숫자 알려줌   // 콘솔 프린트는 삭제예정
        public List<int> GetComputerNumber(int number=3)
        {
            List<int> comList = new List<int>();
            bool isNum3 = false;

            // 컴퓨터 랜덤숫자 3개 출력
            while (!isNum3)
            {
                ReturnRandomComList(comList);

                if (comList.Count == number)
                    isNum3 = true;
            }

            // 테스트용. 삭제 예정
            //foreach (int com in comList)
            //        Console.WriteLine(com);

            return comList.ToList();
        }

        // 컴퓨터의 랜덤번호 3개 선정
        public void ReturnRandomComList(List<int> comList)
        {
            int count = 0;
            int minNum = 0;
            int maxNum = 9;
            int randNum = _random.Next(minNum, maxNum);
            int saveNum = randNum;

            if (comList.Count == count)
                comList.Add(saveNum);

            else
            {
                bool IsSame = comList.Contains(saveNum);    // 숫자 중복 판단

                while (IsSame)  // 중복인 경우
                {
                    randNum = _random.Next(minNum, maxNum);

                    if (saveNum != randNum)
                        IsSame = false;
                }

                comList.Add(randNum);
            }
        }
    }
}
