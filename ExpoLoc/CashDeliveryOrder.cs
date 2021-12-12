using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoLoc
{
    //Se crea una clase de repartidor y se hace el llamado de las interfaces segregadas
    class CashDeliveryOrder : IOrder, IPayMoney
    {
        //Los métodos de las interfaces Orde y PayMoney ejecutandose con segregación// 
        public void Purchase()
        {
            //Método de la interfaz Order
            Console.WriteLine(" Compra online iniciada ");
        }

        public void PayMoney()
        {
            //Método de la interfaz PayMoney
            Console.WriteLine(" Procesamiento de dinero en efectivo ");
        }

    }
}
