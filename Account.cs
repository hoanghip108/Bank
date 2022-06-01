namespace Bank
{
    public class Account
    {
        protected int id;
        public int ID 
        {
            get
            {
                return id;
            }
        }
        public string Name {get;set;}
        public string Password {get;set;}
        protected double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        protected static int count = 0;

        public Account()
        {

        }
        public Account(string name,string password, double balance)
        {
            id = count++;
            Name = name;
            Password = password;
            this.balance = balance;
        }
        public  virtual void ShowInfo()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Username:{0}",Name);
            Console.WriteLine("Balance: {0}",balance);
        }

        public void WithDraw(double amount)
        {
            if(amount > balance)
            
                Console.WriteLine("Not enough money");

            else if (amount<=0)
            Console.WriteLine("Invalid amount!");
            else
            {
                balance -= amount;
                Console.WriteLine("Withdraw success");
                Console.WriteLine("New balance is: {0}", balance);
            
            }
            
        }

        public void Deposit( double amount)
        {
            if(amount <=0)
            
                Console.WriteLine("Invalid amount!");
            else
            {
                balance += amount;
                Console.WriteLine("Deposit success, new balace: {0}", balance);
            }
        }
        
    }
}