namespace Decorator
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        protected Beverage()
        {
            Description = "Unknown Beverage";
        }

        public abstract double Cost();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}