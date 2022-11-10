using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaSixThirdSemester
{
    public abstract class Worker
    {
        public enum Gender : byte
        {
            Male = 1,
            Female
        }

        public Worker(string fullName, Gender gender)
        {
            FullName = fullName;
            Description = gender;
        }

        public string FullName { get;}
        public Gender Description { get;}
        public abstract void Work(int goodsSold);
        public abstract int CalculateWage();
    }
}
