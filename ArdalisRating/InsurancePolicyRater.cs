using System;

namespace ArdalisRating
{
    public class InsurancePolicyRater : IPolicyRater
    {
        private readonly RatingEngine _engine;
        // private ConsoleLogger _logger; //future logging Support

        public InsurancePolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }
        public void Rate( Policy policy)
        {
                Console.WriteLine("Insurance Policy.. Started..");
                if(policy.StartDate == DateTime.Now)
                {
                    Console.WriteLine("Looks like incurance policy taken today");
                }
                if(policy.Cost >= 5000)
                {
                    Console.WriteLine("bronz policy..");
                }
                if(policy.TotalCover >= 1000000)
                {
                    Console.WriteLine("Gold polict");
                }
        }
    }
}