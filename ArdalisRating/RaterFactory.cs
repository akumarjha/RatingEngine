using System;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public IPolicyRater Create(Policy policy, RatingEngine engine)
        {
            //using reflection...
            try
            {
                return (IPolicyRater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                    new object[] { engine });
            }
            catch
            {
                return null;
            }
            //// using manual mapping..
            // IPolicyRater ratere = new LifePolicyRater(engine);
            // switch (policy.Type)
            // {
            //     case PolicyType.Auto:
            //         return new AutoPolicyRater(engine);

            //     case PolicyType.Land:
            //         return new LandPolicyRater(engine);

            //     case PolicyType.Life:
            //         return new LifePolicyRater(engine); 

            //     case PolicyType.Insurance:
            //         return new InsurancePolicyRater(engine);
            //     default:
            //     //nee to implement some other logic for default
            //         return null;
            // }
        }
    }
}