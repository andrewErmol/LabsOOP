namespace HumanLibrary.Humans
{
    /// <summary>
    /// Consist of object Learner type
    /// </summary>
    public abstract class Learner : Human, IComparable<Learner>
    {
        internal string NameOfTheEducationalInstitution;
        List<int> Marks;

        /// <summary>
        /// Create object learner type
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="yearOfBirth"></param>
        /// <param name="status"></param>
        /// <param name="nameOfTheEducationalInstitution"></param>
        /// <param name="marks"></param>
        public Learner(string surname, int yearOfBirth, string status, string nameOfTheEducationalInstitution, List<int> marks)
            : base(surname, yearOfBirth, status)
        {
            NameOfTheEducationalInstitution = nameOfTheEducationalInstitution;
            Marks = marks;
        }

        /// <summary>
        /// Sorts learner alphabetically
        /// </summary>
        /// <param name="otherLearner"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(Learner? otherLearner)
        {
            if (otherLearner == null)
                throw new ArgumentException("Incorrect format");

            return Surname.CompareTo(otherLearner.Surname);
        }

        /// <summary>
        /// Find avarge mark
        /// </summary>
        /// <returns>double avarge mark</returns>
        public double AverageMark()
        {
            double averageMark = 0;

            for (int i = 0; i < Marks.Count; i++)
            {
                averageMark += Marks[i];
            }
            averageMark /= Marks.Count;

            return averageMark;
        }

        public override string Info()
        {
            return $"Surname: {Surname}\tStatus: {Status}\t Year of birth: {YearOfBirth}\tAverage mark: {AverageMark()}\t";
        }
    }
}
