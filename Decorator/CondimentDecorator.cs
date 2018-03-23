namespace Decorator
{
    /// <summary>
    /// 具备调料的装饰器
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
    }

    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage; // 被装饰的对象
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }

    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage; // 被装饰的对象
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + ", Soy";
        }

        public override double Cost()
        {
            return .30 + _beverage.Cost();
        }
    }

    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage; // 被装饰的对象
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + ", Whip";
        }

        public override double Cost()
        {
            return .50 + _beverage.Cost();
        }
    }
}