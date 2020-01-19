using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //簡單工廠模式，讓我們把 pizza 的創造和 pizza 的使用分開了，減少了 client 對於實作的依賴。

            //我們成功的判斷出 orderPizza 這個函數裡面會變動的部分，分離出一個工廠，去處理他。
            //如果你今天要改變處理方式，你去改那個工廠或是給我一個新工廠就可以。
            //我不管你怎麼創造的，我只在乎你回傳給我的 object 的 class 是 Pizza 的 subclass。
        }
    }
}
