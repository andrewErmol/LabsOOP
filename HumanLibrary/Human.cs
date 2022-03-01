namespace HumanLibrary
{
    /// <summary>
    /// Consist of object Human type
    /// </summary>
    public abstract class Human
    {
        public string Surname { get; }
        public int YearOfBirth { get; }
        public string Status { get; }

        /// <summary>
        /// Create object human type
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="yearOfBirth"></param>
        /// <param name="status"></param>
        protected Human(string surname, int yearOfBirth, string status)
        {
            Surname = surname;
            YearOfBirth = yearOfBirth;
            Status = status;
        }

        /// <summary>
        /// Data of Humans
        /// </summary>
        /// <returns>string consist of data of Humans</returns>
        public abstract string Info();
    }
}