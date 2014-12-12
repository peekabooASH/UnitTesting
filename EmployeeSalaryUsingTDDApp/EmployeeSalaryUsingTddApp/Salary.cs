using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryUsingTddApp
{
    
    public class Salary
    {
        public double Total { get; set; }

        public double Basic { get; set; }
        public double Medical { get; set; }
        public double Conyeance { get; set; }
        public int noOfIncrement { get; private set; }

        public Salary()
        {
            Total = 0.0;
        }
        public Salary(double basic, double medical, double conyeance): this()
        {
            Basic = basic;
            Medical = medical;
            Conyeance = conyeance;
        }


        public double GetMedicalAmount()
        {
           return (Basic*Medical)/100;
        }

        public double GetConyeanceAmount()
        {
            return (Basic * Conyeance) / 100;
        }

        public double GetTotal()
        {
            return Basic + GetMedicalAmount() + GetConyeanceAmount();
        }

        public double Increase(double percentOfBasic)
        {
            Basic += (Basic*percentOfBasic)/100;
            noOfIncrement++;
            return Basic;
        }
    }
}
