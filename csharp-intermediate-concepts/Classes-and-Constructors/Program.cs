namespace Classes_and_Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //overloaded constructor
            Student student1 = new Student("Imane", "Boulouane");

            Console.WriteLine(student1.GetFullName());
        }
    }
}