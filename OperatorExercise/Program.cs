namespace OperatorExercise
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var myCalledMethod = AreaOfCircle(radius);
            Console.WriteLine(myCalledMethod);

        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }

        

        










    }
}
