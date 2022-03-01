using HumanLibrary;
using HumanLibrary.Humans;
using HumanLibrary.Humans.Learners;

string Adres = @"..\Humen.txt";
Service.ReadData(Adres);

for (int i = 0; i < Service.HumansList.Count; i++)
{
    if (Service.HumansList[i].Status == "школьник" && 2022 - Service.HumansList[i].YearOfBirth > 12)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Service.HumansList[i].Info());
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine(Service.HumansList[i].Info());
    }
}
Console.WriteLine();
Console.WriteLine(Service.SortLearner());

Console.WriteLine($"Count losers: {Service.CountLosWithEnteredSchool("ЛуненецкаяСШ")}");

Console.WriteLine($"\nStudents applying for increased scholarship:\n{Service.StudentsWithGreatMark()}");
