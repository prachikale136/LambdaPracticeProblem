namespace LambdaPracticePRoblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Student> students = new List<Student>();
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Display();
            
        }
    }
}