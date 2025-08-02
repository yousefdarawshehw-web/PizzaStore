using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryStoreAgainPizza
{



    public partial class mainPizza : Form
    {
        int CrustPrice = 0;      // سعر الكرست
        int ToppingsPrice = 0;   // سعر الإضافات

        public mainPizza()
        {
            InitializeComponent();
        }

        int totalPrice()
        {
            int pricePizza = 0;

            if (BtnRadSmall.Checked)
                pricePizza = 50;
            else if (BtmRadMed.Checked)
                pricePizza = 100;
            else if (BtnRadLarge.Checked)
                pricePizza = 150;

            return pricePizza + CrustPrice + ToppingsPrice;
        }

      
        (string Type, int Price) GET_Type_Price()
        {
            if (BtnRadThin.Checked)
                return ("Thin", 20);
            if (BtnRadThink.Checked)
                return ("Thick", 30);

            return ("", 0);
        }

     
        (string Type, int Price) AddToppings()
        {
            List<string> toppingNames = new List<string>();
            int totalToppingPrice = 0;

            if (btnChExtraChees.Checked) { toppingNames.Add("Extra Cheese"); totalToppingPrice += 20; }
            if (BtnChOnion.Checked) { toppingNames.Add("Onion"); totalToppingPrice += 20; }
            if (BtnChMushrooms.Checked) { toppingNames.Add("Mushrooms"); totalToppingPrice += 20; }
            if (BtnChTomatoes.Checked) { toppingNames.Add("Tomatoes"); totalToppingPrice += 20; }
            if (BtnChGreenPeppers.Checked) { toppingNames.Add("Green Peppers"); totalToppingPrice += 20; }
            if (BtnChOlives.Checked) { toppingNames.Add("Olives"); totalToppingPrice += 20; }

            return (string.Join(", ", toppingNames), totalToppingPrice);
        }


        void UpdateTotal()
        {
            labTotalPrice.Text = "Total Price: " + totalPrice();
        }

 
        private void BtnRadSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadSmall.Checked)
            {
                LabSize.Text = "Size : Small";
                UpdateTotal();
            }
        }

        private void BtmRadMed_CheckedChanged(object sender, EventArgs e)
        {
            if (BtmRadMed.Checked)
            {
                LabSize.Text = "Size : Medium";
                UpdateTotal();
            }
        }

        private void BtnRadLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadLarge.Checked)
            {
                LabSize.Text = "Size : Large";
                UpdateTotal();
            }
        }

  
        private void BtnRadThin_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadThin.Checked)
            {
                var Result = GET_Type_Price();
                CrustPrice = Result.Price;
                labCrusst.Text = "Crust : " + Result.Type;
                UpdateTotal();
            }
        }

        private void BtnRadThink_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadThink.Checked)
            {
                var Result = GET_Type_Price();
                CrustPrice = Result.Price;
                labCrusst.Text = "Crust : " + Result.Type;
                UpdateTotal();
            }
        }

        void UpdateToppings()
        {
            var Result = AddToppings();
            ToppingsPrice = Result.Price;
            labToppings.Text = "Toppings : " + (Result.Type == "" ? "None" : Result.Type);
            UpdateTotal();
        }

 
        private void btnChExtraChees_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void BtnChOnion_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void BtnChMushrooms_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void BtnChOlives_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void BtnChTomatoes_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void BtnChGreenPeppers_CheckedChanged(object sender, EventArgs e) => UpdateToppings();

        private void BtnRadEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if(BtnRadEatIn.Checked)
            {
                labWhereToEat.Text = "Where to Eat: Eat In";
            }
        }

        private void BtnRadEatOut_CheckedChanged(object sender, EventArgs e)
        {
            labWhereToEat.Text = "Where to Eat: EAT OUT ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button || c is RadioButton || c is CheckBox)
                    c.Enabled = false;
            }

        }
    }
}
