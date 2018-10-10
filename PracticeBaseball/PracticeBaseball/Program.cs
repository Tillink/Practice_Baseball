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
            //ComputerNumber computerNumber = new ComputerNumber();
            
            //computerNumber.selectedComputerNumber();


            List<int> userNumbers = new List<int>();

            while (userNumbers.Count < 3)
            {
                string userInput = Console.ReadLine();
                int userChoice = int.Parse(userInput);
                bool numRange = userChoice >= 0 && userChoice < 10;

                if (numRange)
                {
                    if (userNumbers.Count == 0)
                        userNumbers.Add(userChoice);

                    else if (userNumbers.Contains(userChoice))
                        return;
                    //userNumbers.Add(userChoice);

                    else
                        return;
                        //Console.WriteLine("숫자가 같습니다. 다른 숫자를 입력해 주세요");
                }
            }
            
        }
    }
}
