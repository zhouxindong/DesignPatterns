using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle1 = new Circle();
            IShape triangle1 = new Triangle();
            var composite = new CompositeShape();
            composite.Add(circle1);
            composite.Add(triangle1);

            List<IShape> shapes = new List<IShape> {circle1, triangle1, composite};

            shapes.ForEach(shape => shape.Draw());
            Console.ReadKey();

            var menu_hot = new Menu("Hot", "hot meal");
            var menu_meat = new Menu("Meat", "meat");
            var menu_beef = new MenuItem("Beef", "beef", false, 32.89);
            var menu_proch = new MenuItem("Porch", "porch", false, 20.32);
            menu_meat.Add(menu_beef);
            menu_meat.Add(menu_proch);
            menu_hot.Add(menu_meat);

            var menu_veg = new Menu("Veg", "veg");
            var menu_omio = new MenuItem("Omio", "omio", true, 3.84);
            var menu_tomato = new MenuItem("Tomato", "tomato", true, 5.33);
            var menu_potato = new MenuItem("Potato", "potato", true, 2.12);
            menu_veg.Add(menu_omio);
            menu_veg.Add(menu_tomato);
            menu_veg.Add(menu_potato);
            menu_hot.Add(menu_veg);

            menu_hot.Print();
            Console.ReadKey();
        }
    }
}
