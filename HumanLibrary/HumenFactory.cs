using HumanLibrary.Humans;
using HumanLibrary.Humans.Learners;

namespace HumanLibrary
{
    /// <summary>
    /// Class for crate object human
    /// </summary>
    internal static class HumansFactory
    {
        private const int SurnameIndex = 0,
            YearOfBirthIndex = 1,
            StatusIndex = 2,
            PlaceOfWorkOrEduIndex = 3,
            GroupOrClassOrSpecIndex = 4,
            SalaryOrMarksIndex = 5;

        /// <summary>
        /// Create object human
        /// </summary>
        /// <param name="line"></param>
        /// <returns>object human</returns>
        public static Human CreateObject(string line)
        {
            string[] attributes = line.Split(' ');

            string surname = attributes[SurnameIndex];
            int yearOfBirth = Convert.ToInt32(attributes[YearOfBirthIndex]);
            string status = attributes[StatusIndex];
            string placeOfWorkOrEdu = attributes[PlaceOfWorkOrEduIndex];
            string groupOrClassOrSpec = attributes[GroupOrClassOrSpecIndex];

            List<int> salaryOrMarks = new List<int>();

            for (int i = SalaryOrMarksIndex; i < attributes.Length; i++)
            {
                salaryOrMarks.Add(Convert.ToInt32(attributes[i]));
            }

            if (attributes[StatusIndex] == "студент")
            {
                return new Student(surname, yearOfBirth, status, placeOfWorkOrEdu, groupOrClassOrSpec, salaryOrMarks);
            }
            else if (attributes[StatusIndex] == "школьник")
            {
                return new Schoolboy(surname, yearOfBirth, status, placeOfWorkOrEdu, groupOrClassOrSpec, salaryOrMarks);
            }
            else
            {
                return new Working(surname, yearOfBirth, status, placeOfWorkOrEdu, groupOrClassOrSpec, salaryOrMarks);
            }
        }
    }
}