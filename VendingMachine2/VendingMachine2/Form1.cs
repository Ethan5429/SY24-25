using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine2
{
    public partial class Form1 : Form
    {
        private CoinSlot coinSlot;
        private Products products = new Products;

        public Form1()
        {
            InitializeComponent();
            coinSlot = new CoinSlot();
        }

        private void showProduct(string productName, double productPrice)
        {
            labelProductName.Text = productName;
            labelProductPrice.Text = productPrice.ToString("C2");
        }

        private void SnickersButton_Click(object sender, EventArgs e)
        {showProduct("Snickers", 1.50);}

        private void PepsiButton_Click(object sender, EventArgs e)
        {showProduct("Pepsi", 2.00);}

        private void LaysButton_Click(object sender, EventArgs e)
        {showProduct("Lays", 1.75);}

        private void DoritosButton_Click(object sender, EventArgs e)
        {showProduct("Doritos", 1.75);}

        private void PretzelsButton_Click(object sender, EventArgs e)
        {showProduct("Pretzels", 1.75);}

        private void PringlesButton_Click(object sender, EventArgs e)
        {showProduct("Pringles", 1.25);}

        private void CheetosButton_Click(object sender, EventArgs e)
        {showProduct("Cheetos", 1.75);}

        private void CheezitButton_Click(object sender, EventArgs e)
        {showProduct("Cheez-It", 1.25);}

        private void CokeButton_Click(object sender, EventArgs e)
        {showProduct("Coca-Cola", 2.00);}

        private void TwixButton_Click(object sender, EventArgs e)
        {showProduct("Twix", 1.50);}

        private void SpriteButton_Click(object sender, EventArgs e)
        {showProduct("Sprite", 2.00);}

        private void FantaButton_Click(object sender, EventArgs e)
        {showProduct("Fanta", 2.00);}

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("nickel");
            UpdateTotalLabel();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dime");
            UpdateTotalLabel();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("quarter");
            UpdateTotalLabel();
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dollar");
            UpdateTotalLabel();
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            coinSlot.CoinReturn();
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            labelTotal.Text = coinSlot.Total().ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //products.AddProduct();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(labelProductPrice.Text.Substring(1));
            products.Buy(labelProductName.Text, price);
        }
    }
}
