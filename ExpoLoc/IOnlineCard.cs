using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Segregación de la interfaz OnlyCard 
namespace ExpoLoc
{
    interface IOnlineCard
    {
        //Método de pago con tarjeta
        void ProcessCreditCard();
    }
}
