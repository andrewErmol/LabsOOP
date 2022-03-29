namespace TireMountLibrary
{
    public class Work
    {
        public DateTime DateOfWork { get; }
        public decimal Cost { get; }
        public Automobile Car { get; }
        public TypeOfWork WorkType { get; }

        public Work(string dateOfWork, decimal cost, Automobile car, string workType)
        {
            DateOfWork = DateTime.Parse(dateOfWork);
            Cost = cost;
            Car = car;
            WorkType = SetTypeOfWork(workType);
        }

        private TypeOfWork SetTypeOfWork(string workType)
        {
            switch (workType)
            {
                case "Replacing tires":
                    return TypeOfWork.ReplacingTires;
                case "Repair of punctures":
                    return TypeOfWork.RepairOfPunctures;
                case "Balancing wheels":
                    return TypeOfWork.BalancingWheels;
                default:
                    throw new Exception("Doesn't exist entered type of work");
            }
        }
    }
}