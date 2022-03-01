using HumanLibrary.Humans;

namespace HumanLibrary
{
    /// <summary>
    /// Static class of some methods
    /// </summary>
    public static class Service
    {
        public static List<Human> HumansList;
        public static List<Learner> LearnerList;

        /// <summary>
        /// Create an array of human from the file text
        /// </summary>
        /// <param name="filepath"></param>
        public static void ReadData(string filepath)
        {
            HumansList = new List<Human>();
            List<string> data = new List<string>();

            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }

            foreach (string line in data)
            {
                HumansList.Add(HumansFactory.CreateObject(line));
            }
        }

        /// <summary>
        /// Sorts learner alphabetically
        /// </summary>
        /// <returns>string with sort learner</returns>
        public static string SortLearner()
        {
            LearnerList = new List<Learner>();
            string sortLearner = "";

            for (int i = 0; i < HumansList.Count; i++)
            {
                if (HumansList[i].Status == "школьник" || HumansList[i].Status == "студент")
                {
                    LearnerList.Add((Learner)HumansList[i]);
                }
            }

            for (int i = 0; i < LearnerList.Count - 1; i++)
            {
                for (int j = i+1; j < LearnerList.Count; j++)
                {
                    if (LearnerList[i].CompareTo(LearnerList[j]) == 1)
                    {
                        Learner tmp = LearnerList[i];
                        LearnerList[i] = LearnerList[j];
                        LearnerList[j] = tmp;
                    } 
                }
            }

            for (int i = 0; i < LearnerList.Count; i++)
            {
                sortLearner += $"{LearnerList[i].Info()}\n";
            }

            return sortLearner;
        }

        /// <summary>
        /// Find count schoolboys with bad marks
        /// </summary>
        /// <param name="enteredSchool"></param>
        /// <returns>count schoolboys with bad marks</returns>
        public static int CountLosWithEnteredSchool(string enteredSchool)
        {
            int count = 0;
            const int loserMark = 2;

            for (int i = 0; i < LearnerList.Count; i++)
            {
                if(LearnerList[i].NameOfTheEducationalInstitution == enteredSchool)
                {
                    if (LearnerList[i].AverageMark() <= loserMark)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Find count students with great marks
        /// </summary>
        /// <returns>count students with great marks</returns>
        public static string StudentsWithGreatMark()
        {
            const int greatMark = 9;
            string result = "";

            for (int i = 0; i < LearnerList.Count; i++)
            {
                if(LearnerList[i].AverageMark() >= greatMark)
                {
                    result += $"{LearnerList[i].Info()}\n";
                }
            }

            return result;
        }
    }
}
