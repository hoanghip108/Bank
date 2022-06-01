using System;
using System.Collections.Generic;
namespace Bank
{
    public class AdminProgram
    {
        private List<Account> accounts;
        public AdminProgram()
        {
            accounts = new List<Account>();
        }
        public void Run()
        {
            bool running = true;
            while(running)
            {
                menu();
                int choice = GetUserChoice();
                DoTask(choice);
                running = IsContinues();
            }
        }
        private void menu()
        {
            Console.WriteLine("1.Add account ");   
            Console.WriteLine("2.List account ");
        }
        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddUser();
                break;
                case 2: ShowUsers();
                break;
                default:Console.WriteLine("Invalid Choice");
                break;
            }
        }
        private int GetUserChoice()
        {
                Console.WriteLine("Enter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                return option;
        }
        private bool IsContinues()
        {
            Console.WriteLine("Enter your choice: (y/n)");
            string choice =  Console.ReadLine();
            return choice=="y";
        }
        private void AddUser()
        {
            Console.WriteLine("Choose type of account");
            Console.WriteLine("1. Debit");
            Console.WriteLine("2. Normal");
            Account acc = CreateAccount(choice);
            accounts.Add(acc);
        }
        private Account CreateAccount(int choice)
        {

            Console.WriteLine("Enter account");
            string usr = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pwd = Console.ReadLine();
            Console.WriteLine("Enter balance");
            double bl = double.Parse(Console.ReadLine());

            if(choice ==2)
            return new Account(usr,pwd,bl);
            Console.WriteLine("Enter threshold: ");
            double threshold = double.Parse(Console.ReadLine());
            return new DebitAccount(usr,pwd,bl,threshold);
            
        }
        private void ShowUsers()
        {
            foreach(Account acc in accounts)
            {
                acc.ShowInfo();
            }
        }
        public  Account SeachAccount(int id,string password)
        {
            foreach (Account acc in accounts)
            {
                if(acc.ID == id && acc.Password ==password)
                {
                    return acc;
                }
            }
            return null;
        }
    }
}