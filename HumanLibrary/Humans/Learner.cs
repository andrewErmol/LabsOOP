using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLibrary.Humans
{
    public abstract class Learner : Human
    {
        string NameOfTheEducationalInstitution;
        List<int> Marks;

        public Learner(string surname, int yearOfBirth, string status, string nameOfTheEducationalInstitution, List<int> marks) : base(surname, yearOfBirth, status)
        {
            NameOfTheEducationalInstitution = nameOfTheEducationalInstitution;
            Marks = marks;
        }

        public override void Info()
        {
            int AverageMark = 0;

            for (int i = 0; i < Marks.Count; i++)
            {
                AverageMark += Marks[i];
            }
            AverageMark /= Marks.Count;

            Console.Write($"Surname: {Surname}\tStatus: {Status}\t Year of birth: {YearOfBirth}\tAverage mark: {AverageMark}\t");
        }
    }
}
