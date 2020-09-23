using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_4
{
    //PLAYERS
    abstract class Players
    {
        public abstract string AssignRole();
        public string Name;
        public int Age;
        public Players(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string getRole()
        {
            return AssignRole();
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
            roster.Add(new Coach("Vic Fangio", 62));
            roster.Add(new QB("Drew Lock", 23));
            roster.Add(new RB("Melvin Gordon", 27));
            roster.Add(new RB("Phillip Lindsay", 28));
            roster.Add(new WR("Cortland Sutton", 30));
            roster.Add(new WR("Tyrie Cleveland", 32));
            roster.Add(new TE("Noah Fant", 25));
            roster.Add(new CB("A.J. Bouye", 26));
            roster.Add(new CB("Bryce Callahan", 27));
            roster.Add(new Safety("Justan Simmons", 29));
            roster.Add(new Safety("Kareem Jackson", 26));
            roster.Add(new DT("Kyle Peko", 32));
            roster.Add(new DE("Shelby Harris", 33));
            roster.Add(new LB("Bradley Chubb", 35));
            roster.Add(new Kicker("Sam Martin", 23));

            //Team
            Team Broncos = new Team("Broncos", "Denver", roster);

            Console.WriteLine(Broncos.getCity() + " " + Broncos.getTeamName());
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(Broncos.getPlayers());

            Console.ReadKey();

        }
    }

    //redundant implementation
    //COACH
    class Coach : Players
    {
        public Coach(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Coach";
        }
    }

    //QB
    class QB : Players
    {
        public QB(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Quarterback";
        }
    }

    //Running back
    class RB : Players
    {
        public RB(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Running back";
        }
    }

    //Wide Reciver
    class WR : Players
    {
        public WR(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Wide Reciver";
        }
    }

    //Tight end
    class TE : Players
    {
        public TE(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Tight End";
        }
    }

    //Corner back
    class CB : Players
    {
        public CB(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Corner back";
        }
    }

    //Safety
    class Safety : Players
    {
        public Safety(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Safety";
        }
    }

    //Defensive Tackele
    class DT : Players
    {
        public DT(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Defensive Tackle";
        }
    }

    //Defensive End
    class DE : Players
    {
        public DE(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Defensive End";
        }
    }

    //Line Backer
    class LB : Players
    {
        public LB(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Line Backer";
        }
    }

    //Kicker
    class Kicker : Players
    {
        public Kicker(string name, int age) : base(name, age) { }

        public override string AssignRole()
        {
            return "Kicker";
        }
    }

}
