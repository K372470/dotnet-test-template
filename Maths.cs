namespace CoolSoftware.Functions
{
  public class Maths
  {
    public static int Multiply(int input1, int input2) => input1 * input2;
    public static int Square(int input) => input * input;
    public static float Divide(int input1, int input2) => (float)input1 / input2;
    public static int Subtract(int input1, int input2) => input1 - input2;
    public static int Add(int input1, int input2) => input1 + input2;
        public static int Pow(int input, int power)
        {
            var result = 1;
            for (int i = 0; i < power; i++)
                result *= input;
            return result;
        }
  }
}