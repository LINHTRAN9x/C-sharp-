namespace ConsoleApp1.BaiTap.C__EXAM
{
    class Cylinder
    {
        private double Radius { get; }
        private double Height { get; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            double baseArea = Math.Round(Radius * Radius * Math.PI, 2);
            double lateralArea = Math.Round(2 * Math.PI * Radius * Height, 2);
            double totalArea = Math.Round(2 * Math.PI * Radius * (Height + Radius), 2);
            double volume = Math.Round(Math.PI * Radius * Radius * Height, 2);

            Result(baseArea, lateralArea, totalArea, volume);
        }


        public void Result(double baseArea, double lateralArea, double totalArea, double volume)
        {
            Console.Write("Calculation Results:");
            Console.Write($": Base Area: {baseArea}");
            Console.Write($": Lateral Area: {lateralArea}");
            Console.Write($": Total Area: {totalArea}");
            Console.Write($": Volume: {volume}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the cylinder: ");
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();
        }
    }

}
