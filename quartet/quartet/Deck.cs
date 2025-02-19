using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace quartet
{
    internal class Deck
    {
        List<CarCard> carCards;

        public Deck(List<CarCard> cards)
        {
            this.carCards = cards;
        }

        public void shuffle()
        { 
        
        }

        public CarCard GetCard(int index)
        {
            return carCards[index];
        }

        public override string ToString()
        {
            string retVal = "Deck: \n";
            foreach (CarCard card in carCards)
            {
                retVal += card.ToString();
            }
            return retVal;
        }
    }
}
