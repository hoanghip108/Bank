using System;
namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Account john = new Account("John","123",1000);
            // NormalAccProgram program = new NormalAccProgram(john);
            // program.Run();
            // AdminProgram  admin = new AdminProgram();
            // admin.Run();
            int adminID  = -1;
            string adminPass = "abc";
            AdminProgram admin = new AdminProgram();
            while(true)
            {
                Console.WriteLine("Enter ID");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter password");
                string pass = Console.ReadLine();
                if(id==adminID && pass == adminPass)
                admin.Run();
                else
                {
                    Account acc = admin.SeachAccount(id,pass);
                    if(acc == null)
                    Console.WriteLine("Invalid ID or Password");
                    else
                    {
                        NormalAccProgram client = new NormalAccProgram(acc);
                        client.Run();
                    }
                }
            }
        }
    }
}