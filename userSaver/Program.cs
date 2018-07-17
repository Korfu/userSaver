using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userSaver
{
    class Program
    {
        static void Main()
        {
            var user = new User("","",0);

            Console.WriteLine("Name:");
            user.Name = Console.ReadLine();

            Console.WriteLine("Last name:");
            user.Surname = Console.ReadLine();

            Console.WriteLine("Born in (year):");
            user.Age = DateTime.Today.Year - Int32.Parse(Console.ReadLine());
           

            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            Console.Write(json);
            Console.ReadKey();
        }

     
    }

    public class User
    {
        public User(string firstname,string lastname,int dob)
        {
            Name = firstname;
            Surname = lastname;
            Age = dob;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        private int born;
    }
}
