using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode: IOfferItem
    {
        //private string code {get;set;}
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value>0)
                {
                    throw new ArgumentException(); 
                }
            }
        }

        public PromoCode(int amount)
        {
            this.SubTotal = amount;
        }
    }
}