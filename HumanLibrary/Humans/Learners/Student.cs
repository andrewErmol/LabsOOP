using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanLibrary.Humans.Learners
{
    public class Student : Learner
    {
        string Group;

        public Student(string surname, int yearOfBirth, string status, string nameOfTheEducationalInstitution, List<int> marks, string group) : base(surname, yearOfBirth, status, nameOfTheEducationalInstitution, marks)
        {
            Group = CheckOnTheCorrectnessOfTheGroupFormat(group);
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Group: {Group}");
        }

        private string CheckOnTheCorrectnessOfTheGroupFormat(string group)
        {
            Regex regex = new Regex(@"\w+-\d{2}");
            Match groupMatch = regex.Match(group);

            if (!groupMatch.Success)
            {
                throw new Exception("Incorrect format of number");
            }

            return group;
        }
    }
}
