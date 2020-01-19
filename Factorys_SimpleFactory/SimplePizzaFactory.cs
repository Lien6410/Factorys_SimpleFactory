using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_SimpleFactory
{
    public class SimplePizzaFactory
    {
        public IPizza GetPizza(string type)
        {
            IPizza pizza = null;
            if (type == "Cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "Ham")
            {
                pizza = new HamPizza();
            }
            return pizza;
        }
    }
}
