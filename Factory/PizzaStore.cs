namespace Factory
{
    /// <summary>
    /// PizzaStore就象一个抽象工厂，具体对象的实例化由具体工厂完成
    /// 定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个。
    /// 工厂方法让类把实例化推迟到子类
    /// </summary>
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected abstract Pizza CreatePizza(string type);
    }

    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza = new NYStyleCheesePizza();
                    break;

                case "Pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;

                case "Clam":
                    pizza = new NYStyleClamPizza();
                    break;

                case "Veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }

    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;

                case "Pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;

                case "Clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;

                case "Veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }

    /// <summary>
    /// 抽象工厂模式：提供一个接口，用于创建相关或依赖对象的家庭，而不需要明确指定具体类
    /// 抽象工厂相当于一组工厂方法的集合
    /// </summary>
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
    }

    public abstract class Dough { }
    public abstract class Sauce { }
}