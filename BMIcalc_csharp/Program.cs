class Program
{
    static double MetricBMI(double height, double weight)
    {
        return weight / Math.Pow(height, 2);
    }

    static double ImperialBMI(double height, double weight)
    {
        return weight * 703 / Math.Pow(height, 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Metric or Imperial units? Type 1 for Metric, 2 for Imperial: ");
        string choice = Console.ReadLine();

        double bmi = 0;

        if (choice == "1")
        {
            Console.Write("Please input height in cm: ");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Please input weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            bmi = MetricBMI(height, weight);
        }
        else if (choice == "2")
        {
            Console.Write("Please input height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input weight in lbs: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            bmi = ImperialBMI(height, weight);
        }
        else
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine($"Your BMI is {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight!");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Good weight!");
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            Console.WriteLine("You are overweight!");
        }
        else if (bmi > 39.9)
        {
            Console.WriteLine("You are obese!");
        }
    }
}
