using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TireMountLibrary
{
    public static class Service
    {
        public static List<Work> Works = new List<Work>();

        public static void SetDataForTireMountWork()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\TireMount.xml");
            XmlElement elem = xml.DocumentElement;

            foreach (XmlNode xnode in elem)
            {
                Work work = new Work();
                Automobile automobile = new Automobile();

                XmlNode attr = xnode.Attributes.GetNamedItem("CarModel");

                if (attr != null)
                {
                    automobile.CarModel = attr.Value;
                }

                foreach (XmlNode childNode in xnode.ChildNodes)
                {
                    if (childNode.Name == "CarNumber")
                    {
                        automobile.CarNumber = childNode.InnerText;
                        work.Car = automobile;
                    }                        

                    if (childNode.Name == "DateOfWork")
                    {
                        work.DateOfWork = DateTime.Parse(childNode.InnerText);
                    }

                    if (childNode.Name == "Cost")
                    {
                        work.Cost = Convert.ToDecimal(childNode.InnerText);
                    }

                    if (childNode.Name == "WorkType")
                    {
                        work.WorkType = Work.SetTypeOfWork(childNode.InnerText);
                    }
                }

                Works.Add(work);
            }
        }

        public static string ViewWorksOfAutomobileModel(string workType)
        {
            TypeOfWork typeOfWork = Work.SetTypeOfWork(workType);
            Dictionary<string, int> countWorkOfEachCar = new Dictionary<string, int>();

            foreach (Work work in Works)
            {
                if (work.WorkType == typeOfWork)
                {
                    if (!countWorkOfEachCar.ContainsKey(work.Car.CarModel))
                    {
                        countWorkOfEachCar.Add(work.Car.CarModel, 1);
                    }
                    else
                    {
                        countWorkOfEachCar[work.Car.CarModel]++;
                    }
                }
            }

            return DictionaryToString(countWorkOfEachCar);
        }

        private static string DictionaryToString(Dictionary<string, int> dictionary)
        {
            string result = "";

            foreach (var elem in dictionary)
            {
                result += $"{elem.Key} {elem.Value}\n";
            }

            return result;
        }

        private static string DictionaryToString(Dictionary<TypeOfWork, decimal> dictionary)
        {
            string result = "";

            foreach (var elem in dictionary)
            {
                result += $"{TypeOfWorkToString(elem.Key)} {elem.Value}\n";
            }

            return result;
        }

        private static string TypeOfWorkToString(TypeOfWork workType)
        {
            switch (workType)
            {
                case TypeOfWork.RepairOfPunctures:
                    return $"Repair of punctures";
                case TypeOfWork.BalancingWheels:
                    return $"Balancing wheels";
                case TypeOfWork.ReplacingTires:
                    return $"Replacing tires";
                case TypeOfWork.Split_convergence:
                    return $"Split-convergence";
                default:
                    return $"Of entered car did not work";
            }
        }

        public static string MoreWorkForAutoModel(string AutomobileModel)
        {
            Dictionary<TypeOfWork, int> workcOfEnteredModel = new Dictionary<TypeOfWork, int>();

            foreach (Work work in Works)
            {
                if (work.Car.CarModel == AutomobileModel)
                {
                    if (!workcOfEnteredModel.ContainsKey(work.WorkType))
                    {
                        workcOfEnteredModel.Add(work.WorkType, 1);
                    }
                    else if (workcOfEnteredModel.ContainsKey(work.WorkType))
                    {
                        workcOfEnteredModel[work.WorkType]++;
                    }
                }
            }

            var max = -1;
            TypeOfWork max_work = TypeOfWork.nullValue;
            
            foreach(var work in workcOfEnteredModel)
            {
                if (work.Value > max)
                {
                    max = work.Value;
                    max_work = work.Key;
                }
            }

            return $"{TypeOfWorkToString(max_work)}: {max}";
        }

        public static string WorkCostOfEnteredInterval(string dateFirst, string dateLast)
        {
            DateTime dateStart = DateTime.Parse(dateFirst);
            DateTime dateFinish = DateTime.Parse(dateLast);

            Dictionary<TypeOfWork, decimal> costForAllWorkTypeOfIntervalDate = new Dictionary<TypeOfWork, decimal>(); 

            foreach (Work work in Works)
            {
                if (work.DateOfWork >= dateStart && work.DateOfWork <= dateFinish)
                {
                    if (!costForAllWorkTypeOfIntervalDate.ContainsKey(work.WorkType))
                    {
                        costForAllWorkTypeOfIntervalDate.Add(work.WorkType, work.Cost);
                    }
                    else
                    {
                        costForAllWorkTypeOfIntervalDate[work.WorkType] += work.Cost;
                    }
                }
            }

            return DictionaryToString(costForAllWorkTypeOfIntervalDate);
        }
    }
}
