namespace SimpleMath;
using System.Threading.Tasks;

class Program
{
    static Calculator SimpleMathCalculator = new SimpleCalculator(new SimpleMath());
    static void Main()
    {
        Parallel.Invoke(
                //Let us Assume Add method is Invoked by Thread-1
                () => Add(),
                //Let us Assume Sub method is Invoked by Thread-2
                () => Sub(),
                //Let us Assume Multiply method is Invoked by Thread-1
                () => Multiply(),
                //Let us Assume Divide method is Invoked by Thread-2
                () => Divide()
                );
    }
    

    //Method to create a Logger instance and use to call add from simpleMath
    private static void Add()
    {
        Logger logger_add = Logger.GetLoggerInstance();
        logger_add.Log(SimpleMathCalculator.add(1, 2).ToString());
    }
    //Method to create a Logger instance and use to call Sub from simpleMath
    private static void Sub() {
        Logger logger_sub = Logger.GetLoggerInstance();
        logger_sub.Log(SimpleMathCalculator.sub(2, 1).ToString());
    }

    //Method to create a Logger instance and use to call the Multiply from simpleMath
    private static void Multiply() {
        Logger logger_multiply = Logger.GetLoggerInstance();
        logger_multiply.Log(SimpleMathCalculator.multiply(3, 2).ToString());
    }

    //Method to create a Logger instance and use to call Divide from simpleMath
    private static void Divide() {
        Logger logger_divide = Logger.GetLoggerInstance();
        logger_divide.Log(SimpleMathCalculator.divide(2, 2).ToString());
    }
}
