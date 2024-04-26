

namespace FilesPractice_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //link filepath and initiate list
            string filePath = "C:\\Users\\andya\\OneDrive\\Desktop\\Data\\ClassData.csv";
            List<Class> classList = GetClasses(filePath);

            //while loop for menu options
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose a menu option:\n1- View Classes\n2- Add Class\n3- Exit");
                string menuChoice = Console.ReadLine();
                if (menuChoice != "1" && menuChoice != "2" && menuChoice != "3")
                {
                    continue;
                }
                else if (menuChoice == "1")
                {
                    Console.Clear();
                    if (classList.Count == 0)
                    {
                        Console.WriteLine("There are no classes to display. Add a class and try again.");
                    }
                    else
                    {
                        foreach (var item in classList)
                        {
                            Console.WriteLine(item); 
                        }
                    }
                    Console.WriteLine("\nPress enter to return to the menu");
                    Console.ReadLine();
                }
                else if (menuChoice == "2")
                {
                    Console.Clear();
                    classList.Add(AddClass());

                    Console.Clear();
                    Console.WriteLine("Class added successfully.\n\nPress enter to return to the menu");
                    Console.ReadLine();
                }
                else if (menuChoice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Saving and closing...");
                    Thread.Sleep(3000); 

                    StreamWriter writer = new StreamWriter(filePath);
                    foreach (var item in classList)
                    {
                        writer.WriteLine($"{item.instructor},{item.subject},{item.courseNumber},{item.courseName},{item.room}"); //replicate file format
                    } 

                    writer.Close();
                    Console.WriteLine("Data saved successfully!");

                    break;
                } //end of Menu Choices
            } //end of while
        } //end of main
        public static Class AddClass()
        {
            Class newClass = new Class();

            Console.WriteLine("Instructor Name:");
            newClass.instructor = Console.ReadLine();

            Console.WriteLine("Subject:");
            newClass.subject = Console.ReadLine();

            Console.WriteLine("Course Number:");
            newClass.courseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Course Name:");
            newClass.courseName = Console.ReadLine();

            Console.WriteLine("Room:");
            newClass.room = Console.ReadLine();

            return newClass;
        } //end of AddClass method
        public static List<Class> GetClasses(string filePath)
        {
            List<Class> classData = new List<Class>();

            StreamReader reader = new StreamReader(filePath);  

            while (!reader.EndOfStream) 
            {
                string line = reader.ReadLine();  
                string[] lineData = line.Split(","); //look for commas and turn them into array items

                Class newClass = new Class();

                newClass.instructor = lineData[0];
                newClass.subject = lineData[1];
                newClass.courseNumber = int.Parse(lineData[2]);
                newClass.courseName = lineData[3];
                newClass.room = lineData[4];

                classData.Add(newClass); 
            }

            reader.Close(); //close connection to avoid corruption

            return classData;
        } //end of getClass method
    } //end of program class
} //end of namespace

