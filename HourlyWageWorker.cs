using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaSixThirdSemester
{

    public class HourlyWageWorker : Worker 
    {
        public int NormalHourlyWage { get;}
        public int OvertimeHourlyWage { get;}
        public int StandardOfWorkingHours { get;}
        public HourlyWageWorker(string _fullName, Gender _gender, int _normalHourlyWage, int _overtimeHourlyWage, int _standardOfWorkingHours)
        :base(_fullName,_gender)
        {
            StandardOfWorkingHours = _standardOfWorkingHours;
            NormalHourlyWage = _normalHourlyWage;
            OvertimeHourlyWage = _overtimeHourlyWage;
            hoursWorked = 0;
            workedDays = 0;
        }

        public override void Work(int hours)
        {
            hoursWorked += hours;
            workedDays++;
        }

        public override int CalculateWage()
        {
            var normalHoursWorked = (hoursWorked < StandardOfWorkingHours * workedDays) ? hoursWorked : (StandardOfWorkingHours * workedDays);
            var overtimeHoursWorked = hoursWorked - normalHoursWorked;

            hoursWorked = 0;
            workedDays = 0;

            return normalHoursWorked * NormalHourlyWage + overtimeHoursWorked * OvertimeHourlyWage;
        }


        private int hoursWorked;
        private int workedDays;
    }

}

