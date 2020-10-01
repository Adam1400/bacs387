using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    class Account
    {
        public double Balance;
        public string Name;
        public int Count;

        public Account(string name, double balance) 
        {
            Balance = balance;
            Name = name;
            Count = 0;
        }

        public double AddFunds(double Funds) 
        {
            Count++;
            Balance = Balance + Funds;
            return Balance;
        }

        public double RemoveFunds(double Funds)
        {
            Count++;
            Balance = Balance - Funds;
            return Balance;
        }

        public double CheckBalance() 
        {
            return Balance;
        }

        public int getTransactionCount() 
        {
            return Count;
        }

        public string getName()
        {
            return Name;
        }
    }

    class Member 
    {
        public string Name;
        public List<Account> Accounts;
        public int Count;

        public Member(string name, List<Account> accounts) 
        {
            Name = name;
            Accounts = accounts;
            Count = 0;
        }

        public string CloseAccount(string accountName) 
        {
            foreach (Account account in Accounts) 
            {
                if (account.getName() == accountName)
                {
                    Accounts.Remove(account);
                    return accountName + " Account Removed";
                }
            }
            return "No " + accountName + " Found";
        }

        public int memberAccountCount() 
        {
            return Accounts.Count();
        }

        public int getTransactionCount() 
        {
            int Total = 0;
            foreach (Account account in Accounts) 
            {
                Total = Total + account.getTransactionCount();
            }

            return Total;
        }

        public string getName() 
        {
            return Name;
        }

        public double totalBalance() 
        {
            double Total = 0;
            foreach (Account account in Accounts) 
            {
                Total = Total + account.CheckBalance();
            }
            return Total;
        }
    }

    class Bank 
    {
        public double Balance;
        public List<Member> Members;

        public Bank(List<Member> members) 
        { 
            Members = members;
           
            Balance = 0;

            foreach (Member member in Members) 
            {
                Balance = Balance + member.totalBalance();
            }
           
        }

        public string listAllMembers() 
        {
            string memberList = "Members \n---------------------------- \n";
            foreach (Member person in Members) 
            {
                memberList = memberList + person.getName() +"\n";
            }

            return memberList;
        }

        public string getAccountCount()
        { 
            int Total = 0;
            foreach (Member person in Members)
            {
                Total = Total + person.memberAccountCount();
            }

            return "Number of Account: " + Total;   
        }

        public string getTransactionCount()
        {
            int Total = 0;
            foreach (Member person in Members)
            {
                Total = Total + person.getTransactionCount();
            }

            return "Number of Transactions: " + Total;
        }

        public double getBankBalance() 
        {
            Balance = 0;
            foreach (Member member in Members)
            {
                Balance = Balance + member.totalBalance();
            }
            return Balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Account> Member1Accounts = new List<Account>();
            Member1Accounts.Add(new Account("Checking", 300.00));
            Member1Accounts.Add(new Account("Savings", 2500.50));

            List<Account> Member2Accounts = new List<Account>();
            Member2Accounts.Add(new Account("Checking", 10.67));
            Member2Accounts.Add(new Account("Savings", 7150.70));

            List<Account> Member3Accounts = new List<Account>();
            Member3Accounts.Add(new Account("Checking", 1085.27));
            Member3Accounts.Add(new Account("Savings", 10680.21));
            Member3Accounts.Add(new Account("Investments", 10000000.00));

            List<Member> BankMembers = new List<Member>();
            BankMembers.Add(new Member("Allen Adams", Member1Accounts));
            BankMembers.Add(new Member("Glen Adams", Member2Accounts));
            BankMembers.Add(new Member("Kelly Adams", Member3Accounts));

            Bank AdamsBank = new Bank(BankMembers);

            Console.WriteLine("ADAMS BANK");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine(AdamsBank.listAllMembers());
            Console.WriteLine(AdamsBank.getAccountCount());
            Console.WriteLine(AdamsBank.getTransactionCount());
            Console.WriteLine("Current Bank Equity: $" + AdamsBank.getBankBalance());
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Member2Accounts[0].AddFunds(1000);
            Member3Accounts[1].RemoveFunds(2000);
            Member1Accounts[1].AddFunds(12000);
            BankMembers[2].CloseAccount("Investments");
            Console.WriteLine(BankMembers[1].getName() + " added $1000.00 to => "+Member2Accounts[0].getName());
            Console.WriteLine(BankMembers[2].getName() + " removed $2000.00 to => " + Member3Accounts[1].getName());
            Console.WriteLine(BankMembers[0].getName() + " added $12,000.00 to => " + Member2Accounts[1].getName());
            Console.WriteLine(BankMembers[2].getName() + " Closed Investments Account" );
            
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("ADAMS BANK");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine(AdamsBank.listAllMembers());
            Console.WriteLine(AdamsBank.getAccountCount());
            Console.WriteLine(AdamsBank.getTransactionCount());
            Console.WriteLine("Current Bank Equity: $" + AdamsBank.getBankBalance());
            Console.WriteLine("-------------------------");
            Console.WriteLine();






            Console.ReadKey();
        }
    }
}
