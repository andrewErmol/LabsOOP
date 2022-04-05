namespace TireMountLibrary
{
    public class Work
    {
        public DateTime DateOfWork { get; internal set; }
        public decimal Cost { get; internal set; }
        public Automobile Car { get; internal set; }
        public TypeOfWork WorkType { get; internal set; }

        public Work() { }

        public Work(string dateOfWork, decimal cost, string carModel, string carNumber, string workType)
        {
            DateOfWork = DateTime.Parse(dateOfWork);
            Cost = cost;
            Car = new Automobile(carModel, carNumber);
            WorkType = SetTypeOfWork(workType);
        }

        internal static TypeOfWork SetTypeOfWork(string workType)
        {
            switch (workType)
            {
                case "Replacing tires":
                    return TypeOfWork.ReplacingTires;
                case "Repair of punctures":
                    return TypeOfWork.RepairOfPunctures;
                case "Balancing wheels":
                    return TypeOfWork.BalancingWheels;
                case "Split-convergence":
                    return TypeOfWork.Split_convergence;
                default:
                    throw new Exception("Doesn't exist entered type of work");
            }
        }
    }
}