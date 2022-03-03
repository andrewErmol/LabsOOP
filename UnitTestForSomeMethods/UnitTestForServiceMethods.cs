using HumanLibrary;
using HumanLibrary.Humans.Learners;
using Xunit;
using FluentAssertions;
using System.IO;
using HumanLibrary.Humans;

namespace UnitTestForSomeMethods
{
    public class UnitTestForServiceMethods
    {
        [Fact]
        public void ReadDataThereAreStudent()
        {
            //Arrange
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt", string.Empty);
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt",
                $"Ермоленко 2002 студент ГГТУ-П.О.Сухого ПМ-31 10 9 6 7 9");

            //Act
            Service.ReadData(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt");

            //Assert
            Service.HumansList.Should().AllBeOfType<Student>();
        }

        [Fact]
        public void ReadDataThereAreSchoolboy()
        {
            //Arrange
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt", string.Empty);
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt",
                $"Грищенко 2012 школьник ЛуненецкаяСШ 5-Б) 3 1 1 2 2 1");

            //Act
            Service.ReadData(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt");

            //Assert
            Service.HumansList.Should().AllBeOfType<Schoolboy>();
        }

        [Fact]
        public void ReadDataThereAreWorking()
        {
            //Arrange
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt", string.Empty);
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt",
                $"Коноплич 2002 рабочий ЗАРУБЕЖНЕФТЬ электро-монтер 1500 1200 1000 1000 1200 2000 1300 1500 1000 800 1100 1100");

            //Act
            Service.ReadData(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt");

            //Assert
            Service.HumansList.Should().AllBeOfType<Working>();            
        }

        [Fact]
        public void SortsLearnerAlphabetically()
        {
            //Arrange
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt", string.Empty);
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt",
                $"Коноплич 2002 рабочий ЗАРУБЕЖНЕФТЬ электро-монтер 1500 1200 1000 1000 1200 2000 1300 1500 1000 800 1100 1100\n" +
                $"Ермоленко 2002 студент ГГТУ-П.О.Сухого ПМ-31 10 9 6 7 9\n" +
                $"Грищенко 2012 школьник ЛуненецкаяСШ 5-Б) 3 1 1 2 2 1");

            //Act
            Service.ReadData(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt");
            Service.SortLearner();

            //Assert
            Service.LearnerList[0].Should().BeOfType<Schoolboy>();
            Service.LearnerList[1].Should().BeOfType<Student>();
            Service.LearnerList[0].Surname.Should().StartWith("Гр").And.EndWith("енко").And.Contain("ищ").And.HaveLength(8);
            Service.LearnerList[1].Surname.Should().StartWith("Ер").And.EndWith("енко").And.Contain("мол").And.HaveLength(9);
        }

        [Fact]
        public void FindCountSchoolboysWithBadMarks()
        {
            //Arrange
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt", string.Empty);
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt",
                $"Коноплич 2002 рабочий ЗАРУБЕЖНЕФТЬ электро-монтер 1500 1200 1000 1000 1200 2000 1300 1500 1000 800 1100 1100\n" +
                $"Ермоленко 2002 студент ГГТУ-П.О.Сухого ПМ-31 10 9 6 7 9\n" +
                $"Грищенко 2012 школьник ЛуненецкаяСШ 5-Б) 3 1 1 2 2 1");

            //Act
            Service.ReadData(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt");
            Service.SortLearner();


            //Assert
            Service.CountLosWithEnteredSchool($"ЛуненецкаяСШ").Should().Be(1);
        }

        [Fact]
        public void FindCountStudentsWithGreatMarks()
        {
            //Arrange
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt", string.Empty);
            File.WriteAllText(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt",
                $"Коноплич 2002 рабочий ЗАРУБЕЖНЕФТЬ электро-монтер 1500 1200 1000 1000 1200 2000 1300 1500 1000 800 1100 1100\n" +
                $"Ермоленко 2002 студент ГГТУ-П.О.Сухого ПМ-31 10 9 8 9 9\n" +
                $"Грищенко 2012 школьник ЛуненецкаяСШ 5-Б) 3 1 1 2 2 1");

            //Act
            Service.ReadData(@"D:\Labs\LabsOOP\UnitTestForSomeMethods\bin\Debug\\CheckTest.txt");
            Service.SortLearner();


            //Assert
            Service.StudentsWithGreatMark().Should().Contain("Ермоленко");
        }
    }
}