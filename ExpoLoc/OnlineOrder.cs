using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoLoc
{
    //Se crea una clase de orden onlune y se hace el llamado de las interfaces segregadas

    class OnlineOrder : IOrder , IOnlineCard
    {
      //Los métodos de las interfaces Orde y OnlineCard ejecutandose con segregación// 
        public void Purchase()
        {
            //Método de la interfaz Order
            Console.WriteLine(" Compra online iniciada ");
        }

        public void ProcessCreditCard()
        {
            //Método de la interfaz  OnlineCard
            Console.WriteLine(" Procesamiento de tarjeta de crédito ");
        }

    }
}
