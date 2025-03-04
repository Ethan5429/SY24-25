using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace quartet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCard A1 = new CarCard("A1", "BMW z8", 250, 4.7, 400, 4941, 8, 6600);
            CarCard A3 = new CarCard("A3", "Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500);
            CarCard A4 = new CarCard("A4", "viper", 285, 4.6, 411, 7990, 10, 5100);
            CarCard B2 = new CarCard("B2", "TVR Sagaris", 300, 3.9, 3966, 8, 400, 7000);
            CarCard B3 = new CarCard("B3", "Range Rover Sport", 225, 7.6, 4197, 8, 390, 5750);
            CarCard C2 = new CarCard("C2", "Toyota Celica", 205, 8.7, 143, 1794, 4, 6400);
            CarCard C3 = new CarCard("C3", "Porsche 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
            CarCard C4 = new CarCard("C4", "Corvette Coupe", 281, 5.2, 344, 5665, 8, 5400);
            CarCard D1 = new CarCard("D1", "Audi RS4", 250, 4.8, 420, 4163, 8, 7800);
            CarCard D2 = new CarCard("D2", "AudiRs 6 Plus", 280, 4.6, 480, 4172, 8, 6400);
            CarCard D3 = new CarCard("D3", "Nissan 350 Z", 250, 5.9, 3498, 6, 280, 6300);
            CarCard E1 = new CarCard("E1", "Aston Martin V8 Vantage", 280, 5.0, 4282, 8, 385, 7000);
            CarCard E2 = new CarCard("E2", "Ferrari F50", 325, 3.9, 521, 4700, 12, 8500);
            CarCard E3 = new CarCard("E3", "BMW 645 Ci", 250, 5.6, 333, 4398, 8, 6100);
            CarCard E4 = new CarCard("E4", "Bentley Azure", 241, 6.7, 6750, 8, 388, 4000);
            CarCard F1 = new CarCard("F1", "Opel Astra Coupe 2.0", 245, 7.5, 192, 1988, 4, 5400);
            CarCard F2 = new CarCard("F2", "VW Golf R32", 248, 6.2, 250, 3189, 6, 6300);
            CarCard F4 = new CarCard("F4", "Fisker Tramonto", 325, 3.6, 610, 5439, 8, 6100);
            CarCard G1 = new CarCard("G1", "Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750);
            CarCard G2 = new CarCard("G2", "Mercedes-Benz SL 500", 250, 6.3, 306, 4966, 8, 5600);
            CarCard G3 = new CarCard("G3", "Alfa Romeo Brera", 248, 6.3, 260, 3195, 6, 6200);
            CarCard G4 = new CarCard("G4", "Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250);
            CarCard H1 = new CarCard("H1", "BMW Z4 3.0i", 250, 5.9, 231, 2979, 6, 5900);
            CarCard H3 = new CarCard("H3", "Pontiac GTO", 280, 5.7, 5970, 8, 400, 5200);
            CarCard H4 = new CarCard("H4", "BMW m5", 250, 4.7, 507, 4999, 10, 7750);
            CarCard I3 = new CarCard("I3", "Audi RS 6 Plus", 280, 5.2, 480, 4172, 8, 6400);

            List<CarCard> list = new List<CarCard>();
            list.Add(A1);
            list.Add(A3);
            list.Add(A4);
            list.Add(B2);
            list.Add(B3);
            list.Add(C2);
            list.Add(C3);
            list.Add(C4);
            list.Add(D1);
            list.Add(D2);
            list.Add(D3);
            list.Add(E1);
            list.Add(E2);
            list.Add(E3);
            list.Add(E4);
            list.Add(F1);
            list.Add(F2);
            list.Add(F4); 
            list.Add(G1);
            list.Add(G2);
            list.Add(G3);
            list.Add(G4);
            list.Add(H1);
            list.Add(H3);
            list.Add(H4);
            list.Add(I3);
            Deck d = new Deck(list);
            d.shuffle();
            Hand h1 = new Hand();
            Hand h2 = new Hand();
            Hand h3 = new Hand();
            foreach (CarCard card in list)
                WriteLine(card);
            ReadLine();
        }
    }
}
