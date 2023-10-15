using static Day12_PracticeProblem.Program;

namespace Day12_PracticeProblem
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Phone Number: {PhoneNumber}, Address: {Address}, Age: {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>
        {
                    new Student { Id = 1, Name = "Kumar", PhoneNumber = "1234567890", Address = "123 Main St", Age = 17 },
                    new Student { Id = 2, Name = "Kiruba", PhoneNumber = "2345678910", Address = "456 Elm St", Age = 13 },
                    new Student { Id = 3, Name = "Prahalathan", PhoneNumber = "3456789102", Address = "789 Oak St", Age = 14 },
                    new Student { Id = 4, Name = "David", PhoneNumber = "1234567890", Address = "42 Elm St", Age = 18 },
                    new Student { Id = 5, Name = "Eve", PhoneNumber = "1346798520", Address = "99 Oak St", Age = 22 }
        };

            // Display all student details
            Console.WriteLine("All Student Details:");
            students.ForEach(s => Console.WriteLine(s));

            // Retrieve students with age between 12 and 18
            var filteredStudents = students.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
            Console.WriteLine("\nStudents with Age between 12 and 18:");
            filteredStudents.ForEach(s => Console.WriteLine(s));

            // Sort students by Age in descending order
            var sortedStudents = students.OrderByDescending(s => s.Age).ToList();
            Console.WriteLine("\nStudents Sorted by Age (Descending Order):");
            sortedStudents.ForEach(s => Console.WriteLine(s));

            // Group students by Address and display students in each group
            var groupedStudents = students.GroupBy(s => s.Address);  //////////////
            Console.WriteLine("\nStudents Grouped by Address:");
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Address: {group.Key}");
                group.ToList().ForEach(s => Console.WriteLine(s));
            }

            // Fetch the first three students
            var firstThreeStudents = students.Take(3).ToList();
            Console.WriteLine("\nFirst Three Students:");
            firstThreeStudents.ForEach(s => Console.WriteLine(s));

            // Search for a student by name
            string searchName = "hari";
            var foundStudent = students.FirstOrDefault(s => s.Name == searchName);
            Console.WriteLine($"\nSearch Result for Student with Name '{searchName}':");
            if (foundStudent != null)
            {
                Console.WriteLine(foundStudent);
            }
            else
            {
                Console.WriteLine($"No student found with the name '{searchName}'.");
            }
        }
    }
}