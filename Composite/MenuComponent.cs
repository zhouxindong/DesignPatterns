using System;
using System.Collections.Generic;

namespace Composite
{
    /// To present Parent-Child Recur relation

    /// <summary>
    /// 基本元素组件
    /// </summary>
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menu)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(MenuComponent menu)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public virtual string GetName()
        {
            throw new InvalidOperationException();
        }

        public virtual string GetDescription()
        {
            throw new InvalidOperationException();
        }

        public virtual double GetPrice()
        {
            throw new InvalidOperationException();
        }

        public virtual bool IsVegetarian()
        {
            throw new InvalidOperationException();
        }

        public virtual void Print()
        {
            throw new InvalidOperationException();
        }
    }

    /// <summary>
    /// 叶节点元素
    /// </summary>
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _is_vegetarian;
        private readonly double _price;

        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        double price)
        {
            _name = name;
            _description = description;
            _is_vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _is_vegetarian;
        }

        public override void Print()
        {
            Console.Write(" " + GetName());
            if (_is_vegetarian)
                Console.Write("(v)");

            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("   -- " + GetDescription());
        }
    }

    /// <summary>
    /// 组合节点元素
    /// </summary>
    public class Menu : MenuComponent
    {
        private readonly IList<MenuComponent> _components = new List<MenuComponent>();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menu)
        {
            _components.Add(menu);
        }

        public override void Remove(MenuComponent menu)
        {
            _components.Remove(menu);
        }

        public override MenuComponent GetChild(int index)
        {
            return _components[index];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("-------------------------------");

            foreach (var item in _components)
            {
                item.Print();
            }
        }
    }
}