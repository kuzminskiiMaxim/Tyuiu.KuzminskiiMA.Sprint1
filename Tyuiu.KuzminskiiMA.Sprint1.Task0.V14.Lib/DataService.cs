namespace Tyuiu.KuzminskiiMA.Sprint1.Task0.V14.Lib
{
    public interface ISprint0Task0V14
    {
        int Calculate();
    }

    public class DataService : ISprint0Task0V14
    {
        public int Calculate()
        {
            return 2 * 3 * 3 + 7;
        }
    }
}
