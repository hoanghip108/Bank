namespace Bank
{
    public class DebitAccount: Account
    {
        public double Threshold{get;set;}

        public DebitAccount() : base()
        {
            Threshold = 100;
        }

        public DebitAccount(string name,string password, double balance,double threshold) : base(name,password,balance)
        {
            Threshold = threshold;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Threshold: {0}",Threshold);
        }
        public void Withdraw(double amount)
        {
            if(amount > balance +Threshold)
            Console.WriteLine("Not enough money!");
            else if (amount <=0)
            Console.WriteLine("Invalid amount!");
            else
            {
                balance -=amount;
                Console.WriteLine("Withdraw success! New balance: {0}",balance);
            }
        }
    }
}
    