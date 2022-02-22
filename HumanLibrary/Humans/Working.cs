using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLibrary.Humans
{
    public class Working : Human
    {
        string PlaceOfWork;
        string Speciality;
        List<int> SalaryFor12Months;

        public Working(string surname, int yearOfBirth, string status, string placeOfWork, string speciality, List<int> marks) : base(surname, yearOfBirth, status)
        {
            PlaceOfWork = placeOfWork;
            Speciality = speciality;
            SalaryFor12Months = marks;
        }

        public override void Info()
        {
            int maxSalary = 0;

            for (int i = 0; i < SalaryFor12Months.Count; i++)
            {
                if (SalaryFor12Months[i] > maxSalary)
                {
                    maxSalary = SalaryFor12Months[i];
                }
            }

            Console.Write($"Surname: {Surname}\tStatus: {Status}\t Year of birth: {YearOfBirth}\tMax salary of 12 mounths: {maxSalary}\t");
        }
    }
}
