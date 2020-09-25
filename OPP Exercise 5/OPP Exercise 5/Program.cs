using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exercise_5
{

    class CourtEntity
    {
        public int posX, posY, Height, Width;
        public string Classification;

        //give an entity with ==> NAME, POSITION X, POSITION Y, WIDTH X, HEIGHT Y
        public CourtEntity(string name, int x, int y, int width, int height)
        {
            Classification = name;
            Height = height;
            Width = width;
            posX = x;
            posY = y;
        }

        public int getLocation(int index)
        {
            List<int> coordinates = new List<int>();
            coordinates.Add(posX);
            coordinates.Add(posY);
            return coordinates[index];
        }

        public string getName()
        {
            return Classification;
        }

        public int getDimentions(int index) {
            List<int> coordinates = new List<int>();
            coordinates.Add(Width);
            coordinates.Add(Height);
            return coordinates[index];
        }
    }

    class Game
    {
        public int CourtHeight = 10, CourtWidth = 10; //Court Dementions
        public CourtEntity redBasket = new CourtEntity("Basket", 7, 4, 3, 2);  //basket on the right
        public CourtEntity blueBasket = new CourtEntity("Basket", 0, 4, 3, 2); //basket on the left

        public CourtEntity Reff, Ball;
        public List<CourtEntity> Players;

        public Game(List<CourtEntity> players, CourtEntity reff, CourtEntity ball)
        {
            Reff = reff;
            Ball = ball;
            Players = players;


        }

        public string playerLocation() 
        {
            string locations = "Player Locations on Court \n-------------------------- \n";
            foreach (CourtEntity player in Players) 
            {
                locations = locations + player.getName() + ": ["+ player.getLocation(0)+","+player.getLocation(1)+"]\n";
            }
            return locations;
        }

        public string distanceFromRef()
        {
            string diff = "Distances From Ref [" + Reff.getLocation(0) + ","+ Reff.getLocation(1)+"]"+
                "\n------------------------------ \n";
            List<PlayerDistance> distance = new List<PlayerDistance>();

            foreach (CourtEntity Player in Players)
            {

                PlayerDistance CurrentPlayer = new PlayerDistance(Player.getName(),(Math.Abs(Reff.getLocation(0) - Player.getLocation(0)))
                   + (Math.Abs(Reff.getLocation(1) - Player.getLocation(1))));

                distance.Add(CurrentPlayer);
            }

            List<PlayerDistance> sortDis = distance.OrderBy(x => x.getDistance()).ToList();
            
            //distance.Reverse();

            foreach (PlayerDistance Player in sortDis) 
            {
                diff = diff + Player.getName() +": "+ Player.getDistance()+" Units \n";
            }

            return diff;
        }

        public bool basketScored() 
        {
            //for left basket
            if (Ball.getLocation(0) >= blueBasket.getLocation(0) && Ball.getLocation(0) <= blueBasket.getDimentions(0) &&   
                Ball.getLocation(1) >= blueBasket.getLocation(1) && Ball.getLocation(1) <= (blueBasket.getLocation(1) + 1))
            {
                return true;
            }
            if (Ball.getLocation(0) >= redBasket.getLocation(0) && Ball.getLocation(0) <= (redBasket.getDimentions(0)+ redBasket.getLocation(0)) &&
                Ball.getLocation(1) >= redBasket.getLocation(1) && Ball.getLocation(1) <= (redBasket.getLocation(1) + 1))
            {
                return true;
            }
            else { return false; }

        }
    }

    class PlayerDistance 
    {
        public string Name;
        public int Distance;
        public PlayerDistance(string name, int distance) 
        {
            Name = name;
            Distance = distance;
        }
        public int getDistance()
        {
            return Distance;
        }
        public string getName() 
        {
            return Name;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //game 1 players
            List<CourtEntity> Players = new List<CourtEntity>();
            Players.Add(new CourtEntity("Blue 1", 2, 2, 1, 1));
            Players.Add(new CourtEntity("Blue 2", 6, 3, 1, 1));
            Players.Add(new CourtEntity("Blue 3", 4, 7, 1, 1));
            Players.Add(new CourtEntity("Red 1", 9, 2, 1, 1));
            Players.Add(new CourtEntity("Red 2", 5, 6, 1, 1));
            Players.Add(new CourtEntity("Red 3", 3, 10, 1, 1));

            //game 1
            CourtEntity Ball = new CourtEntity("Ball", 0, 4, 1, 1);
            CourtEntity Reff = new CourtEntity("Referee", 5, 0, 1, 1);
            Game Game1 = new Game(Players, Reff, Ball);

            Console.WriteLine("Game 1 Red Team vs Blue Team");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine(Game1.playerLocation());
            Console.WriteLine(Game1.distanceFromRef());
            Console.WriteLine("Basket Scored ==> " + Game1.basketScored());
            Console.WriteLine("Ball Location: [" + Ball.getLocation(0) + "," + Ball.getLocation(1) +"]"+
                " Basket Location: ["+ Game1.blueBasket.getLocation(0)+","+Game1.blueBasket.getLocation(1)+
            "] and [" + Game1.redBasket.getLocation(0) + "," + Game1.redBasket.getLocation(1) + "]");
            Console.WriteLine("");

            //Game 2
            Players.Clear();
            Players.Add(new CourtEntity("Blue 1", 5, 5, 1, 1));
            Players.Add(new CourtEntity("Blue 2", 5, 7, 1, 1));
            Players.Add(new CourtEntity("Blue 3", 6, 8, 1, 1));
            Players.Add(new CourtEntity("Green 1", 6, 5, 1, 1));
            Players.Add(new CourtEntity("Green 2", 5, 8, 1, 1));
            Players.Add(new CourtEntity("Green 3", 9, 9, 1, 1));
            
            Ball = new CourtEntity("Ball", 5, 5, 1, 1);
            Game Game2 = new Game(Players, Reff, Ball);

            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            Console.WriteLine("Game 2 Green Team vs Blue Team");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine(Game2.playerLocation());
            Console.WriteLine(Game2.distanceFromRef());
            Console.WriteLine("Basket Scored ==> " + Game2.basketScored());
            Console.WriteLine("Ball Location: [" + Ball.getLocation(0) + "," + Ball.getLocation(1) + "]" +
                " Basket Locations: [" + Game2.blueBasket.getLocation(0) + "," + Game2.blueBasket.getLocation(1) +
                "] and [" + Game2.redBasket.getLocation(0) + "," + Game2.redBasket.getLocation(1)+"]");


            Console.ReadKey();
        }
    }
}
