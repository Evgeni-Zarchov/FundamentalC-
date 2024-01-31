namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that receives 3 lines of input:· student name, age, average grade.

            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avgGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {avgGrade:F2}");
        }
    }
}
