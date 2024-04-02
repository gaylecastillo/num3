namespace num3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            double minutes = seconds / 60.0;
            Console.WriteLine($"Minutes: {minutes}");

            Console.Write("Enter the number of minutes: ");
            int inputMinutes = int.Parse(Console.ReadLine());
            double hours = inputMinutes / 60.0;
            Console.WriteLine($"Hours: {hours}");

            Console.Write("Enter the number of hours: ");
            int inputHours = int.Parse(Console.ReadLine());
            double days = inputHours / 24.0;
            Console.WriteLine($"Days: {days}");

            Console.Write("Enter the number of days: ");
            int inputDays = int.Parse(Console.ReadLine());
            double months = inputDays / 30.44; // Average number of days in a month
            Console.WriteLine($"Months: {months}");
        }
    }
    }

