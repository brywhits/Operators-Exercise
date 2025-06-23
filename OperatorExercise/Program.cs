namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            
            Console.WriteLine("What is the area of the circle? ");
            string userRadius = Console.ReadLine();
            double radius = double.Parse(userRadius);
            radius = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle is {radius:F2}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
