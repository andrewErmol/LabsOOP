using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanLibrary.Humans.Learners
{
    public class Schoolboy : Learner
    {
        string SchoolClass;

        public Schoolboy(string surname, int yearOfBirth, string status, string nameOfTheEducationalInstitution, List<int> marks, string schoolClass) : base(surname, yearOfBirth, status, nameOfTheEducationalInstitution, marks)
        {
            SchoolClass = CheckOnTheCorrectnessOfTheSchoolClassFormat(schoolClass);
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"School class: {SchoolClass}");
        }

        private string CheckOnTheCorrectnessOfTheSchoolClassFormat(string schoolClass)
        {
            Regex primarySchool = new Regex(@"\d{1}-\w{1}\)");
            Regex highSchool = new Regex(@"\d{2}-\w{1}\)");
            Match primarySchoolMatch = primarySchool.Match(schoolClass);
            Match highSchoolMatch = highSchool.Match(schoolClass);

            if (!primarySchoolMatch.Success && !highSchoolMatch.Success)
            {
                throw new Exception("Incorrect format of number");
            }

            return schoolClass;
        }
    }
}
