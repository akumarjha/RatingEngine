using System;

namespace ArdalisRating
{
    public class LandPolicyRater : IPolicyRater
    {
        private readonly RatingEngine _engine;
        // private ConsoleLogger _logger; //future logging Support

        public LandPolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }
        public void Rate(Policy policy)
        {
            Console.WriteLine("Rating LAND policy...");
            Console.WriteLine("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return;
            }
            _engine.Rating = policy.BondAmount * 0.05m;
        }
    }
}