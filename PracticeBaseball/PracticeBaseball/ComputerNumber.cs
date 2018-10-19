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
        public void GetComputerNumber()
        {
            List<int> comList = new List<int>();
            bool isNum3 = false;

            // 컴퓨터 랜덤숫자 3개 출력
            while (!isNum3)
            {
                returnRandomComList(comList);

                if (comList.Count == 3)
                    isNum3 = true;
            }
            IEnumerable<int> comNum = from x in comList orderby x select x;
            foreach (int com in comList)
                Console.WriteLine(com);
        }

        // 컴퓨터의 랜덤번호 3개 선정
        public void returnRandomComList(List<int> comList)
        {
            int randNum = _random.Next(0, 9);
            int saveNum = randNum;

            if (comList.Count == 0)
                comList.Add(saveNum);

            else
            {
                bool IsSame = comList.Contains(saveNum);    // 숫자 중복 판단

                while (IsSame)  // 중복인 경우
                {
                    randNum = _random.Next(0, 9);

                    if (saveNum != randNum)
                        IsSame = false;
                }

                comList.Add(randNum);
            }
        }
        }
}
