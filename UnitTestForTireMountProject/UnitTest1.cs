using System.Collections.Generic;
using Xunit;

namespace UnitTestForTireMountProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arange
            Dictionary<string, int> countWorkOfEachCar = new Dictionary<string, int>();
            //Act
            countWorkOfEachCar.Add("ford", 4);
            countWorkOfEachCar["ford"]+=2;
            string result = "";

            foreach (var elem in countWorkOfEachCar)
            {
                result += $"{elem.Key} {elem.Value}\n";
            }

            string expected = "ford 6\n";
            //Assert
            Assert.Equal(expected, result);
        }
    }
}