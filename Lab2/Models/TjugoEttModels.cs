using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class TjugoEttModels
    {
        public int CpuChoice { get; set; }
        public int CpuTurn { get; set; }
        public int ActualNumber { get; set; }
        public int Increment { get; set; }
        public string GameOverText { get; set; }



        public int Randomize(int min, int max)
        {
            Random random = new Random();
            int result = random.Next(min, max);
            return result;
        }


        public void ComputerChoice()
        {
            CpuChoice = 0;

            switch (ActualNumber)
            {
                case 19:
                    CpuChoice = 2;
                    break;
                case 20:
                    CpuChoice = 1;
                    break;
                default:

                    if (CpuTurn%2 == 1)
                    {
                        CpuChoice = CpuSmartMove(CpuChoice);
                    }
                    else
                    {
                        CpuChoice = Randomize(1, 3);

                    }
                    break;
            }
            Increment = CpuChoice;
            CpuTurn++;

        }

        private int CpuSmartMove(int cpuChoice)
        {
            switch (ActualNumber%3)
            {
                case 1:
                    cpuChoice = 2;
                    break;
                case 2:
                    cpuChoice = 1;
                    break;
                default:
                    cpuChoice = Randomize(1, 3);
                    break;

            }
            return cpuChoice;
        }


        public void IncreaseActualNumber(int i)
        {
            if (ActualNumber < 21)
            {
                ActualNumber += Increment;
                if (ActualNumber == 21)
                {
                    if (i == 1)
                    {
                        GameOverText = "You win!";
                    }
                    else if (i == 2)
                    {
                        GameOverText = "You lose";
                    }
                }
                else if (ActualNumber == 22)
                {
                    GameOverText = "Come ooon...";
                }
            }
        }
    }
}