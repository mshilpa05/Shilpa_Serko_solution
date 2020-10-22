using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Till
    {

        private Dictionary<char, int> _items = new Dictionary<char, int>{
            {'A', 0},
            {'B', 0},
            {'C', 0},
            {'D', 0 }
        };

        public double Total()
        {

            double total = 0;
            foreach (var item in _items)
            {
                if (item.Key.Equals('A'))
                {
                    total += AddItemA(item);
                }
                else if (item.Key.Equals('B'))
                {
                    total += AddItemB(item);
                }
                else if (item.Key.Equals('C'))
                {
                    total += AddItemC(item);
                }
                else total += item.Value * 15;
            }
            return total;
        }

        private double AddItemA(KeyValuePair<char, int> item)
        {
            if (item.Value < 3)
                return item.Value * 50;
            else
            {
                int special_package = item.Value / 3;
                int remaining = item.Value % 3;
                return special_package * 130 + remaining * 50;
            }
        }

        private double AddItemB(KeyValuePair<char, int> item)
        {
            if (item.Value < 2)
                return item.Value * 30;
            else
            {
                int special_package = item.Value / 2;
                int remaining = item.Value % 2;
                return special_package * 45 + remaining * 30;
            }
        }
        private double AddItemC(KeyValuePair<char, int> item)
        {
            if (item.Value < 6)
                return item.Value * 20;
            else
            {
                return 6 * 20;
            }
        }


        public void Scan(string items)
        {
            foreach (var item in items)
            {
                _items[item]++;
            }
        }
    }
}