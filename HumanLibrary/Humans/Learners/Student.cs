using System.Text.RegularExpressions;

namespace HumanLibrary.Humans.Learners
{
    /// <summary>
    /// Consist of object Student type
    /// </summary>
    public class Student : Learner
    {
        string Group;

        /// <summary>
        /// Create object student type
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="yearOfBirth"></param>
        /// <param name="status"></param>
        /// <param name="nameOfTheEducationalInstitution"></param>
        /// <param name="group"></param>
        /// <param name="marks"></param>
        public Student(string surname, int yearOfBirth, string status, string nameOfTheEducationalInstitution, string group, List<int> marks)
            : base(surname, yearOfBirth, status, nameOfTheEducationalInstitution, marks)
        {
            Group = CheckOnTheCorrectnessOfTheGroupFormat(group);
        }

        public override string Info()
        {
            return $"{base.Info()}Group: {Group}";
        }

        /// <summary>
        /// Check of the correct format of group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
