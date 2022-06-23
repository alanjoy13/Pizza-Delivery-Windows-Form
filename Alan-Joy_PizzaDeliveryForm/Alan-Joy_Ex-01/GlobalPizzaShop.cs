// Alan Joy
// Pizza Delivery Form

namespace Alan_Joy_Ex_01
{
    public partial class GlobalPizzaShop : Form
    {
        // Variables
        string customerName;            // To store the name of the customer.
        double amount;                  // To store the total cost of the pizza order(current order).
        int tempCost;                   // Variable to store temporary cost of current order(To update the price label automatically).
        double totalamount = 0;         // To store the total amount of all orders.
        Random rand = new Random();     // To store random integer.

        public GlobalPizzaShop()
        {
            InitializeComponent();

            textBoxOrderNumber.Text = Convert.ToString(rand.Next(101, 999));    // Displaying order number between 101 and 999.

            comboBoxPizzaSize.Items.Add("Small ($10.00)");
            comboBoxPizzaSize.Items.Add("Medium ($12.00)");     // Displaying to Pizza Sizes to combo box.            
            comboBoxPizzaSize.Items.Add("Large ($14.00)");

            comboBoxPizzaType.Items.Add("Whole");
            comboBoxPizzaType.Items.Add("Wheat");       // Displaying to Pizza Types to combo box.
            comboBoxPizzaType.Items.Add("Normal");
        }

        // Adding an order.
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            // Checking if pizza size and type are selected. If not, display a message.
            if (comboBoxPizzaSize.SelectedIndex == -1 || comboBoxPizzaType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Your Pizza Size and Type!");

            }

            // Checking if customer name is empty. If yes, display a message.
            else if (String.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please Update Your Contact Details!");
            }

            else
            {
                // Setting the amount as per the pizza size.
                if (comboBoxPizzaSize.SelectedIndex == 0)
                {
                    amount += 10;
                }
                if (comboBoxPizzaSize.SelectedIndex == 1)
                {
                    amount += 12;
                }
                if (comboBoxPizzaSize.SelectedIndex == 2)
                {
                    amount += 14;
                }

                // Setting the amount as per the toppings selected. $2 for Non-Veg and $1 for Veg toppings.
                if (checkBoxPepperoni.Checked == true)
                {
                    amount += 2;
                }
                if (checkBoxHam.Checked == true)
                {
                    amount += 2;
                }
                if (checkBoxSausage.Checked == true)
                {
                    amount += 2;
                }
                if (checkBoxMushroom.Checked == true)
                {
                    amount += 1;
                }
                if (checkBoxPineapple.Checked == true)
                {
                    amount += 1;
                }
                if (checkBoxPepper.Checked == true)
                {
                    amount += 1;
                }
                if (checkBoxOlive.Checked == true)
                {
                    amount += 1;
                }
                if (checkBoxOnion.Checked == true)
                {
                    amount += 1;
                }
                if (checkBoxCheese.Checked == true)
                {
                    amount += 2;
                }

                // Displaying order summary and current price to the respective textboxes.
                textBoxOrderSummary.Text += textBoxOrderNumber.Text + " \t|  " + customerName + "  \t|  $" + amount;
                textBoxOrderSummary.Text += Environment.NewLine;
                textBoxSelectedCost.Text = "$" + amount;
                totalamount += amount;      // Incrementing the total amount of all orders.

                double grandTotal = totalamount + totalamount * 0.13;     // 13% GST to the total amount. Displaying grand total.
                textBoxGrandTotal.Text = " Total: $" + totalamount + " + 13% GST : \t\t $" + grandTotal.ToString(".0");
                textBoxOrderNumber.Text = Convert.ToString(rand.Next(101, 999));
                amount = 0;

                // Displaying details of the current order.
                textBoxPizzaOrder.Text = "Order Number : " + textBoxOrderNumber.Text + Environment.NewLine +
                                         "Customer Name : " + customerName + Environment.NewLine +
                                         "Pizza Type : " + comboBoxPizzaType.Text + Environment.NewLine +
                                         "Pizza Size : " + comboBoxPizzaSize.Text + Environment.NewLine +
                                         "Phone Number : " + textBoxPhoneNumber.Text + Environment.NewLine +
                                         "Delivery Address : " + textBoxDeliveryAddress.Text + Environment.NewLine;
            }
        }

        // Updating customer information on Update Button Click.
        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            customerName = textBoxCustomerName.Text;
        }

        // To clear all of the selections made in the pizza seletion groupBox and textboxes.
        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            amount = 0;                             // Setting amount to 0.
            checkBoxPepperoni.Checked = false;      // Setting all the checkboxes to unchecked.
            checkBoxHam.Checked = false;
            checkBoxSausage.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxPineapple.Checked = false;
            checkBoxPepper.Checked = false;
            checkBoxOlive.Checked = false;
            checkBoxOnion.Checked = false;
            checkBoxCheese.Checked = false;

            comboBoxPizzaSize.SelectedIndex = -1;   // Setting the combo box selected item to null.
            comboBoxPizzaType.SelectedIndex = -1;

            textBoxSelectedCost.Clear();            // Clearing text boxes.
            textBoxPizzaOrder.Clear();
        }

        // Clearing order summary of all orders entered.
        private void buttonClearInfo_Click(object sender, EventArgs e)
        {
            textBoxOrderSummary.Clear();
            textBoxGrandTotal.Clear();
            textBoxPizzaOrder.Clear();
        }

        // Clear all the orders made
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            buttonClearInfo_Click(sender, e);
            buttonClearOrder_Click(sender, e);

            textBoxOrderNumber.Text = Convert.ToString(rand.Next(101, 999));
        }

        // Exit/Close the Application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Updating/Dislaying the current cost of pizza to the price label as per the selectios made.
        // Displaying the current cost of pizza as per the size selected.
        private void comboBoxPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPizzaSize.SelectedIndex == 0)
                tempCost = 10;
            if (comboBoxPizzaSize.SelectedIndex == 1)
                tempCost = 12;
            if (comboBoxPizzaSize.SelectedIndex == 2)
                tempCost = 14;
            textBoxSelectedCost.Text = "$" + tempCost.ToString();
        }

        // Displaying the current cost of pizza as toppings selected. 
        // The following both handlers are added to the topping checkbox on mouse click event as per the type of topping..
        // Add or subtract $2 for non-veg toppings.
        private void checkBoxNonVegToppings_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;       // New object for checkbox
            if (checkbox.Checked == true && tempCost < 27 && tempCost > -1)
                tempCost += 2;
            else
                tempCost -= 2;
            textBoxSelectedCost.Text = "$" + tempCost.ToString();
        }

        // Add or subtract $1 for non-veg toppings.
        private void checkBoxVegToppings_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;       // New object for checkbox
            if (checkbox.Checked == true && tempCost < 27 && tempCost > -1)
                tempCost += 1;
            else
                tempCost -= 1;
            textBoxSelectedCost.Text = "$" + tempCost.ToString();
        }
    }
}