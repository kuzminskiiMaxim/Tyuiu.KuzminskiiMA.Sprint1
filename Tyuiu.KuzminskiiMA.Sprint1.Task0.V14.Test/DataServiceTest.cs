using Tyuiu.KuzminskiiMA.Sprint1.Task0.V14.Lib;

namespace Tyuiu.KuzminskiiMA.Sprint1.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Returns25()
        {
            DataService dataService = new DataService();

            double result = dataService.Calculate();

            Assert.AreEqual(25, result);
        }
    }
}
