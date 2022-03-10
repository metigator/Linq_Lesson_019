
using System;

namespace Shared
{
    public class Employee
    { 
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }
         
        public bool HasHealthInsurance { get; set; }

        public bool HasPensionPlan { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return
                    string.Format($"" +
                    $"{Id.ToString().PadRight(5, ' ')}\t" +
                    $" {String.Concat(LastName, ", ", FirstName).PadRight(18, ' ')}\t" + 
                    $"{HireDate.Date.ToShortDateString()}\t" +
                    $"{Gender.PadRight(3, ' ').PadRight(3, ' ')}\t" +
                    $"{Department.PadRight(8, ' ')}\t" +
                    $"{(HasHealthInsurance? "Medical coverage" : "").PadRight(17, ' ')}\t" +
                    $"{(HasPensionPlan ? "Pensionable" : "").PadRight(12, ' ')}\t" +
                    $"{Salary:c0}");
        }
    }

    
}
