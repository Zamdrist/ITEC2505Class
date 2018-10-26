using System.Collections.Generic;
using System.Drawing;

namespace LunchOrderApp
{
    public class Lunch
    {
        private static readonly decimal[] MainCoursePrice = { 6.95m, 5.95m, 4.95m };
        private static readonly decimal[] AddOnPrice = { 0.75m, 0.50m, 0.25m };

        public enum LunchOrderItem
        {
            Hamburger,
            Pizza,
            Salad
        }


        public MainCourseItem[] MainCourse { get; set; } =
            new []
            {
                new MainCourseItem()
                {
	                Image = Properties.Resources.hamburger_color,
			Item = LunchOrderItem.Hamburger,
			Price = Lunch.MainCoursePrice[0],
			AddOnItems = new[] {
				new AddOnItem()
				{
				    Item = "Lettuce, Tomato, Onions",
				    Price = Lunch.AddOnPrice[0]
				},
				new AddOnItem()
				{
				    Item = "Ketchup, Mustard, Mayo",
				    Price = Lunch.AddOnPrice[0]
				},
				new AddOnItem()
				{
				    Item = "French Fries",
				    Price = Lunch.AddOnPrice[0]
				}
			}
                },
                new MainCourseItem()
                {
	                Image = Properties.Resources.pizza_color,
			Item = LunchOrderItem.Pizza,
			Price = Lunch.MainCoursePrice[1]
                },
                new MainCourseItem()
                {
	                Image = Properties.Resources.salad_color,
                    Item = LunchOrderItem.Salad,
                    Price = Lunch.MainCoursePrice[2]
                }
            };

        public List<AddOnItem> AddOn { get; set; } =
            new List<AddOnItem>
            {
                new AddOnItem()
                {
                    MainCourseItem = LunchOrderItem.Pizza,
                    Item = "Pepperoni",
                    Price = Lunch.AddOnPrice[1]
                },
                new AddOnItem()
                {
                    MainCourseItem = LunchOrderItem.Pizza,
                    Item = "Sausage",
                    Price = Lunch.AddOnPrice[1]
                },
                new AddOnItem()
                {
                    MainCourseItem = LunchOrderItem.Pizza,
                    Item = "Olives",
                    Price = Lunch.AddOnPrice[1]
                },
                new AddOnItem()
                {
                    MainCourseItem = LunchOrderItem.Salad,
                    Item = "Croutons",
                    Price = Lunch.AddOnPrice[2]
                },
                new AddOnItem()
                {
                    MainCourseItem = LunchOrderItem.Salad,
                    Item = "Bacon bits",
                    Price = Lunch.AddOnPrice[2]
                },
                new AddOnItem()
                {
                    MainCourseItem = LunchOrderItem.Salad,
                    Item = "Bread sticks",
                    Price = Lunch.AddOnPrice[2]
                }
            };


    }

    public struct MainCourseItem
    {
	public Bitmap Image { get; set; }
	public Lunch.LunchOrderItem Item { get; set; }
	public decimal Price { get; set; }
	public AddOnItem[] Addons;
    }

    public struct AddOnItem
    {
        public Lunch.LunchOrderItem MainCourseItem { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
    }
}
