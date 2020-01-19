using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_SimpleFactory
{
    public class PuizzaStore
    {
        SimplePizzaFactory factory;

        public PuizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza = factory.GetPizza(type);
            pizza.Prepare();
            pizza.Cook();
            return pizza;
        }
    }
}
