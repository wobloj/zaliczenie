namespace kolokwium.Services
{
    public class Calculator
    {
        public Calculator() { }
        public int Add(int a,int b)
        {
            return a+b;
        }
        public float Divide(float a, float b)
        {
            try
            {
                return a/b;
            }
            catch
            {
                return 0;
            }
        }
        public int Substract(int a, int b)
        {
            return a-b;
        }
        public int Multiply(int a, int b)
        {
            return a*b;
        }
    }
}
