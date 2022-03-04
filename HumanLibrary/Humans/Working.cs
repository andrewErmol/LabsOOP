namespace HumanLibrary.Humans
{
    /// <summary>
    /// Consist of object Working type
    /// </summary>
    public class Working : Human
    {
        public string PlaceOfWork { get; }
        public string Speciality { get; }
        private List<int> SalaryFor12Months;

        /// <summary>
        /// Create object working type
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="yearOfBirth"></param>
        /// <param name="status"></param>
        /// <param name="placeOfWork"></param>
        /// <param name="speciality"></param>
        /// <param name="marks"></param>
        public Working(string surname, int yearOfBirth, string status, string placeOfWork, string speciality, List<int> marks)
            : base(surname, yearOfBirth, status)
        {
            PlaceOfWork = placeOfWork;
            Speciality = speciality;
            SalaryFor12Months = marks;
        }

        /// <summary>
        /// Find max salary of 12 months
        /// </summary>
        /// <returns>int max salary of 12 months</returns>
        public int MaxSalary()
        {
            int maxSalary = 0;

            for (int i = 0; i < SalaryFor12Months.Count; i++)
            {
                if (SalaryFor12Months[i] > maxSalary)
                {
                    maxSalary = SalaryFor12Months[i];
                }
            }
            return maxSalary;
        }

        public override string Info()
        {
            return $"Surname: {Surname}\tStatus: {Status}\t" +
                $"Year of birth: {YearOfBirth}\tPlace of work: {PlaceOfWork}\t" +
                $"Speciality: {Speciality}\tMax salary of 12 months: {MaxSalary()}\t";
        }
    }
}
