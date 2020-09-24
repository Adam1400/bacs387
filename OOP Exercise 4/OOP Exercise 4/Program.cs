using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_4
{
    //PLAYERS
    class Players
    {
        public string Role;
        public string Name;
        public int Age;
        public Players(string role, string name, int age)
        {
            Role = role;
            Name = name;
            Age = age;
        }

        public string getRole()
        {
            return Role;
        }

        public string getName()
        {
            return Name;
        }

        public int getAge()
        {
            return Age;
        }

    }


    //TEAMS
    class Team
    {
        public List<Players> Roster = new List<Players>();
        public string TeamName, CityName;

        public Team(string teamName, string cityName, List<Players> roster)
        {
            Roster = roster;
            TeamName = teamName;
            CityName = cityName;
        }

        public string getPlayers()
        {
            string listout = "";
            foreach (Players person in Roster)
            {
                listout = listout + person.getRole() + " ==> " + person.getName() + ", Age: " + person.getAge() + "\n";
            }

            return listout;
        }

        public string getTeamName()
        {
            return TeamName;
        }

        public string getCity()
        {
            return CityName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Players> roster = new List<Players>();

            //Players
            roster.Add(new Players("Coach","Vic Fangio", 62));
            roster.Add(new Players("Quarterback","Drew Lock", 23));
            roster.Add(new Players("Running back ", "Melvin Gordon", 27));
            roster.Add(new Players("Running back", "Phillip Lindsay", 28));
            roster.Add(new Players("Wide receiver", "Cortland Sutton", 30));
            roster.Add(new Players("Wide receiver", "Tyrie Cleveland", 32));
            roster.Add(new Players("Tight end", "Noah Fant", 25));
            roster.Add(new Players("Corner Backs","A.J. Bouye", 26));
            roster.Add(new Players("Corner Backs", "Bryce Callahan", 27));
            roster.Add(new Players("Saftey", "Justan Simmons", 29));
            roster.Add(new Players("Saftey", "Kareem Jackson", 26));
            roster.Add(new Players("Defensive Tackle", "Kyle Peko", 32));
            roster.Add(new Players("Defensive End", "Shelby Harris", 33));
            roster.Add(new Players("Line Backer", "Bradley Chubb", 35));
            roster.Add(new Players("Kicker", "Sam Martin", 23));

            //Team
            Team Broncos = new Team("Broncos", "Denver", roster);

            Console.WriteLine(Broncos.getCity() + " " + Broncos.getTeamName());
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(Broncos.getPlayers());

            Console.ReadKey();

        }
    }
}
