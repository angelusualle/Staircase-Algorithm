using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPathsOfJumpingAnNLongStaircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPossibleNumberOfJumps(4));
        }
        static int getPossibleNumberOfJumps(int numStairs)
        {
            int count = 0;
            Queue<StepsToProcess> next = new Queue<StepsToProcess>();
            next.Enqueue(new StepsToProcess() { currentSteps = 0, jump = 1 });
            next.Enqueue(new StepsToProcess() { currentSteps = 0, jump = 2 });
            next.Enqueue(new StepsToProcess() { currentSteps = 0, jump = 3 });
            while (next.Count != 0)
            {
                StepsToProcess step = next.Dequeue();
                if(step.currentSteps + step.jump == 4)
                {
                    ++count;
                } else if (step.currentSteps > numStairs) {
                } else if (step.currentSteps < numStairs)
                {
                    next.Enqueue(new StepsToProcess() { currentSteps = step.currentSteps + step.jump, jump = 1 });
                    next.Enqueue(new StepsToProcess() { currentSteps = step.currentSteps + step.jump, jump = 2 });
                    next.Enqueue(new StepsToProcess() { currentSteps = step.currentSteps + step.jump, jump = 3 });
                }
            }
            return count;
        }
    }
    public class StepsToProcess
    {
        public int currentSteps { get; set; }
        public int jump { get; set; }
    }
}
