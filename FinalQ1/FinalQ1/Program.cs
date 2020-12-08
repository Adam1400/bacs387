using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalQ1
{
    class Program
    {

        public interface requestData {
            public string getName();
            public int getWattage();

        
        }
        
        class Device: requestData {
            public string Name;
            public int Wattage;
            public Device(string name, int wattage) 
            {
                Name = name;
                Wattage = wattage;
            }

            public string getName() {
                return Name;
            }
            public int getWattage()
            {
                return Wattage;
            }
        }

        class UsedDevice : Device {
            private int Uptime;
            public UsedDevice(string name, int wattage, int uptime) : base(name, wattage) {
                Uptime = uptime;
            
            }
            public int getUptime() {
                return Uptime;
            }
        }

        class Devices {
            private List<UsedDevice> DeviceCollection;
            public Devices(List<UsedDevice> deviceCol) {
                DeviceCollection = deviceCol;
            }

            public int calcMaxRuntime() {

                List<int> uptimelist = new List<int>();
                foreach (UsedDevice x in DeviceCollection) {
                    uptimelist.Add(x.getUptime());
                }

                return uptimelist.Max();
                
            
            }

            public int medianConsomption() {
                int median;
                List<int> wattlist = new List<int>();
                foreach (UsedDevice x in DeviceCollection)
                {
                    wattlist.Add(x.getWattage());
                }
                wattlist.Sort();

                try
                {
                    int half = wattlist.Count() / 2;
                    median = wattlist.ElementAt(half);
                }
                catch
                {
                    int half = (wattlist.Count() / 2) + 1;
                    median = wattlist.ElementAt(half);
                }

                return median;
            }

        }

        

        static void Main(string[] args)
        {
            UsedDevice D1 = new UsedDevice("Iphone", 10, 30);
            UsedDevice D2 = new UsedDevice("Android", 12, 120);
            UsedDevice D3 = new UsedDevice("Desktop", 100, 10);

            List<UsedDevice> deviceSet = new List<UsedDevice>();
            deviceSet.Add(D1);
            deviceSet.Add(D2);
            deviceSet.Add(D3);

            Devices data = new Devices(deviceSet);
            Console.WriteLine(data.calcMaxRuntime());
            Console.WriteLine(data.medianConsomption());

            Console.ReadKey();



        }
    }
}
