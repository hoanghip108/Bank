namespace Bank
{
    public class InterestAccount:Account
    {
        public double Interest {get;set;}

        public InterestAccount():base()
        {
            Interest = 0.05;
        }
        public InterestAccount(string usr,string pwd,double bl,double interest) : base(usr,pwd,bl)
        {
            Interest = interest;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Interest: {0}",Interest);
        }
        public void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Console.WriteLine("Interest: {0}",Interest);
        }
    }
}