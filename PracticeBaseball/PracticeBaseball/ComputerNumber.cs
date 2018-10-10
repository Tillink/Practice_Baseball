using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBaseball
{
    public class ComputerNumber
    {
        Random random = new Random();
        List<int> comList = new List<int>();

        public void returnRandomComList()
        {
            int randNum = random.Next(0, 9);    //Debug.WriteLine($"randNum: {randNum}");
            int saveNum = randNum;

            if (comList.Count == 0)
                comList.Add(saveNum);   //Debug.WriteLine($"저장된 숫자: {randNum}");

            else
            {
                bool IsSame = comList.Contains(saveNum);    // 숫자 중복 판단

                while (IsSame)  // 중복인 경우
                {
                    randNum = random.Next(0, 9);    //Console.WriteLine($"다른 숫자 나올때까지 while: {randNum}");

                    if (saveNum != randNum)
                        IsSame = false;
                }

                comList.Add(randNum);
            }

        }

        public void selectedComputerNumber()
        {
            bool isNum3 = false;

            // 컴퓨터 랜덤숫자 3개 출력
            while (!isNum3)
            {
                returnRandomComList();

                if (comList.Count == 3)
                    isNum3 = true;
            }
            
            // computer Numbers print
            // TODO: remove foreach,CW
            foreach (int com in comList)
                Console.WriteLine(com);
        }
    }
}
