using NewLesson.Cars;
using NewLesson.Constants;

namespace NewLesson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mercedes firstCar = new Mercedes(Color.Blue, 300, 2018, SpeedBoxType.ROBOT, 2.5f);
            Mercedes secondCar = new Mercedes(Color.Green, 200, 2019, SpeedBoxType.AUTO, 2.8f);


        }
    }
}