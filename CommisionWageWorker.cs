using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaSixThirdSemester
{
    public class CommissionWageWorker : Worker
    {
        public int Salary { get;}
        public int Percentage { get;}

        public CommissionWageWorker(string _fullName, Gender _gender, int _salary, int _percentage)
            : base(_fullName, _gender)
        {
            Salary = _salary;
            Percentage = _percentage;
            goodsSoldSum = 0;
        }

        public override void Work(int goodsSold)
        {
            goodsSoldSum += goodsSold;
        }

        public override int CalculateWage()
        {
            var wage = 0;
            var addition = (int)((float)goodsSoldSum * (float)Percentage / 100);

            if (addition != 0)
                wage = Salary + addition;

            goodsSoldSum = 0;

            return wage;
        }

        private static int goodsSoldSum;

    }
}
