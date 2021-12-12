using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpoLoc
{
    class CompraOnline
    {
        static void Main(string[] args)
        {
            //Se implementa el método por  segregación para espeficicar cada función por variable .
            OnlineOrder order1 = new OnlineOrder();
            order1.Purchase();
            order1.ProcessCreditCard();
            //Se implementa el método por  segregación para espeficicar cada función por variable  .
            CashDeliveryOrder order = new CashDeliveryOrder();
            order.Purchase();
            order.PayMoney();
        }
    }
}
