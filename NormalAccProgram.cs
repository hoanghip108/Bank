namespace Bank
{
    public class NormalAccProgram
    {
        private Account acc;
        public void Run()
        {
            bool running = true;
            while(running)
            {
                menu();
                int choice = GetUserChoice() ;
                DoTask(choice);
                running = IsContinues();
            }
        }
        public NormalAccProgram(Account acc)
        {
           this.acc= acc;

        }
        private void menu()
        {
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Show info");
                
               
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
        private void DoTask(int option)
        {
            switch(option)
            {
                case 1: WithDraw(); break;
                case 2: Deposit(); break;
                case 3: ShowInfo(); break;
                default: Console.WriteLine("Invalid"); break;     
            }
        }
        private void WithDraw()
        {
            Console.WriteLine("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            acc.WithDraw(amount);
        }
        private void Deposit()
        {
            Console.WriteLine("Enter amount to Deposit: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        private void ShowInfo()
        {
            acc.ShowInfo();
        }
        

    
    }
}