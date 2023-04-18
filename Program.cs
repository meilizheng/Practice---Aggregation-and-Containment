namespace Practice___Aggregation_and_Containment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor = new Instructor("Will", "Cram"); //reate a new instance
            Console.WriteLine(instructor); //display instructor information
            SchoolProgram schoolprogram = new SchoolProgram("Programming", "124", "J102", instructor);        //reate a new instance               
            schoolprogram.AddStudent("Ana", "Mendes", 100, 100);         //reate a new instance   
            foreach (Student student in schoolprogram.ClassRoster)  //use foreach display student information after add.
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine(schoolprogram);//display the class and instructor's information
        }
    }
}