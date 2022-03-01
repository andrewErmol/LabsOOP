using System.Text.RegularExpressions;

namespace HumanLibrary.Humans.Learners
{
    /// <summary>
    /// Consist of object Schoolboy type
    /// </summary>
    public class Schoolboy : Learner
    {
        string SchoolClass;

        /// <summary>
        /// Create object schoolboy type
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="yearOfBirth"></param>
        /// <param name="status"></param>
        /// <param name="nameOfTheEducationalInstitution"></param>
        /// <param name="schoolClass"></param>
        /// <param name="marks"></param>
        public Schoolboy(string surname, int yearOfBirth, string status, string nameOfTheEducationalInstitution, string schoolClass, List<int> marks)
            : base(surname, yearOfBirth, status, nameOfTheEducationalInstitution, marks)
        {
            SchoolClass = CheckOnTheCorrectnessOfTheSchoolClassFormat(schoolClass);
        }

        public override string Info()
        {
            return $"{base.Info()}School class: {SchoolClass}";
        }

        /// <summary>
        /// Check of the correct format of shool class
        /// </summary>
        /// <param name="schoolClass"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
