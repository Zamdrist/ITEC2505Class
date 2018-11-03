using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LunchOrderApp
{
    public class Lunch
    {
        private static readonly decimal[] MainCoursePrice = {6.95m, 5.95m, 4.95m};
        private static readonly decimal[] AddOnPrice = { 0.75m, 0.50m, 0.25m };
        private const decimal TaxRate = 0.0775m;


        public enum LunchOrderItem
        {
            Hamburger,
            Pizza,
            Salad
        }

        public enum OrderSelectionType
        {
            MainCourse,
            AddOn
        }

        public decimal SubTotal { get; private set; }
        public decimal Tax { get; private set; }
        public decimal Total { get; private set; }


        public List<OrderSummary> OrderSummary(
            DataGridViewRow selectedMainCourseRow,
            DataGridViewSelectedRowCollection selectedAddOnRows)
        {
            var mainCourse = new OrderSummary
            {
                Item = selectedMainCourseRow
                    .Cells["MainCourseItem"].Value.ToString(),
                OrderType = OrderSelectionType.MainCourse,
                Price = (decimal)selectedMainCourseRow.Cells["MainCoursePrice"].Value
            };

            var orderSummary = new List<OrderSummary> { mainCourse };

            foreach (DataGridViewRow selectedRow in selectedAddOnRows)
            {
                var addOn = new OrderSummary
                {
                    Item = selectedRow.Cells["AddOnItem"].Value.ToString(),
                    OrderType = OrderSelectionType.AddOn,
                    Price = (decimal)selectedRow.Cells["AddOnPrice"].Value
                };
                orderSummary.Add(addOn);
            }

            this.SubTotal = orderSummary.Sum(p => p.Price);
            this.Tax = this.SubTotal * Lunch.TaxRate;
            this.Total = this.SubTotal + this.Tax;

            return orderSummary;
        }

        public List<MainCourseItem> MainCourse { get; set; } =
            new List<MainCourseItem>
            {
                new MainCourseItem()
                {
                    Image = Properties.Resources.hamburger_color,
                    Item = LunchOrderItem.Hamburger,
                    Price = Lunch.MainCoursePrice[0]
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
                    Image = Properties.Resources.lettuce_color,
                    MainCourseItem = LunchOrderItem.Hamburger,
                    Item = "Lettuce, Tomato, Onions",
                    Price = Lunch.AddOnPrice[0]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.condiments_color,
                    MainCourseItem = LunchOrderItem.Hamburger,
                    Item = "Ketchup, Mustard, Mayo",
                    Price = Lunch.AddOnPrice[0]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.frenchfries_color,
                    MainCourseItem = LunchOrderItem.Hamburger,
                    Item = "French Fries",
                    Price = Lunch.AddOnPrice[0]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.pepperoni_color,
                    MainCourseItem = LunchOrderItem.Pizza,
                    Item = "Pepperoni",
                    Price = Lunch.AddOnPrice[1]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.sausage_color,
                    MainCourseItem = LunchOrderItem.Pizza,
                    Item = "Sausage",
                    Price = Lunch.AddOnPrice[1]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.olives_color,
                    MainCourseItem = LunchOrderItem.Pizza,
                    Item = "Olives",
                    Price = Lunch.AddOnPrice[1]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.croutons_color,
                    MainCourseItem = LunchOrderItem.Salad,
                    Item = "Croutons",
                    Price = Lunch.AddOnPrice[2]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.bacon_color,
                    MainCourseItem = LunchOrderItem.Salad,
                    Item = "Bacon bits",
                    Price = Lunch.AddOnPrice[2]
                },
                new AddOnItem()
                {
                    Image = Properties.Resources.bread_color,
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
    }

    public struct AddOnItem
    {
        public Bitmap Image { get; set; }
        public Lunch.LunchOrderItem MainCourseItem { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }

    }

    public struct OrderSummary
    {
        public string Item { get; set; }
        public Lunch.OrderSelectionType OrderType { get; set; }
        public decimal Price { get; set; }

    }

}
