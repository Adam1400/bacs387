using System;
using System.Collections.Generic;

namespace OOP_Exercise_10
{
    class Program
    {
        //ability interfase 
        public interface ability {
            public string getAbility();

        }

        //Generic monster
        class monster  {
            public string name;
            public monster(string Name) {
                name = Name;
            }
            public string getName() { return name;  }

          
            
        }

        //Squid
        class squid : monster, ability {
            public squid(string name) : base(name) {}
            public string getAbility() {
                string ability = "Suction cups";
                return ability;
            }     
        }

        //Meatball
        class meatball : monster, ability
        {
            public meatball(string name) : base(name){}
            public string getAbility()
            {
                string ability = "Roll";
                return ability;
            }
        }

        //Cyborg
        class cyborg : monster, ability
        {
            public cyborg(string name) : base(name) { }
            public string getAbility()
            {
                string ability = "Compute";
                return ability;
            }
        }

        //Slime guy
        class slimeGuy : monster, ability
        {
            public slimeGuy(string name) : base(name) { }
            public string getAbility()
            {
                string ability = "Slime up";
                return ability;
            }
        }

        //Reservation
        class reservation 
        {
            public monster monsterRes;
            private string checkin, checkout;
            private int room;
            public reservation(monster Monster, int Room, string Checkin, string Checkout) {
                monsterRes = Monster;
                checkin = Checkin;
                checkout = Checkout;
                room = Room;
            }

            public string showReservation() {
                return monsterRes.getName() + " ==> Room:"+ room + " from "+ checkin + " through " + checkout;
            }
        }

        //Hotel
        class hotel {
            public List<reservation> reservations = new List<reservation>();
            public hotel(List<reservation> Reservations) {
                reservations = Reservations;
            }
            public string showAllRes()
            {
                string list = "";
                foreach (reservation x in reservations) {
                    list = list + x.showReservation() + "\n";
                }

                return list;
            }
        }



        static void Main(string[] args)
        {
            //monsters
            squid squidMan = new squid("Walking Squid");
            meatball meatMan = new meatball("A Meatball");
            cyborg cyborgGuy = new cyborg("Cyborg Guy");
            slimeGuy slimeGlob = new slimeGuy("A glob of slime");

            //reservations
            List<reservation> allRes = new List<reservation>();
            allRes.Add(new reservation(squidMan, 1, "11-15-20", "11-16-20"));
            allRes.Add(new reservation(meatMan, 3, "11-15-20", "11-19-20"));
            allRes.Add(new reservation(cyborgGuy, 11, "11-20-20", "12-6-20"));
            allRes.Add(new reservation(slimeGlob, 523, "12-7-20", "12-7-21"));
            
            //hotel
            hotel hotelTransylvania = new hotel(allRes);

            Console.WriteLine("Hotel Reservations");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(hotelTransylvania.showAllRes());
            Console.WriteLine();
            Console.WriteLine("Note Abilities:");
            Console.WriteLine(squidMan.getName() + ": " + squidMan.getAbility()) ;
            Console.WriteLine(meatMan.getName() + ": " + meatMan.getAbility());
            Console.WriteLine(cyborgGuy.getName() + ": " + cyborgGuy.getAbility());
            Console.WriteLine(slimeGlob.getName() + ": " + slimeGlob.getAbility());
            Console.ReadKey();
        }
    }
}
