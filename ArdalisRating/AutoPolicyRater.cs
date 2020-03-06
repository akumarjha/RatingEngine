using System;

namespace ArdalisRating
{
    public class AutoPolicyRater:IPolicyRater
    {
        private readonly RatingEngine _engine;
        // private ConsoleLogger _logger; //future logging Support

        public AutoPolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }
        public void Rate( Policy policy)
        {
            Console.WriteLine("Rating AUTO policy...");
            Console.WriteLine("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _engine.Rating = 1000m;
                }
                _engine.Rating = 900m;
            }
        }
    }
}