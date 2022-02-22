namespace HumanLibrary
{
    public abstract class Human
    {
        public string Surname { get; }
        public int YearOfBirth { get; }
        public string Status { get; }

        protected Human(string surname, int yearOfBirth, string status)
        {
            Surname = surname;
            YearOfBirth = yearOfBirth;
            Status = status;
        }

        public abstract void Info();
    }
}