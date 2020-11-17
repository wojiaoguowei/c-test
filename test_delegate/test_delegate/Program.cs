using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace test_delegate
{

    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    public class IPhone6
    {
        decimal price;
        public event PriceChangedHandler PriceChanged;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                // 如果调用列表不为空，则触发。
                if (PriceChanged != null)
                    PriceChanged(oldPrice, price);
            }
        }
    }


    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            IPhone6 iphone6 = new IPhone6() { Price = 5288 };
            // 订阅事件
            iphone6.PriceChanged += iphone6_PriceChanged;

            // 调整价格（事件发生）
            iphone6.Price = 3999;

            Console.ReadKey();

        }
        static void iphone6_PriceChanged(decimal oldPrice, decimal price)
        {
            Console.WriteLine("年终大促销，iPhone 6 只卖 " + price + " 元， 原价 " + oldPrice + " 元，快来抢！");
        }
    }
}
