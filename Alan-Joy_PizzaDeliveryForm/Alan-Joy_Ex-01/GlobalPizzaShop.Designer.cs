namespace Alan_Joy_Ex_01
{
    partial class GlobalPizzaShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.labelDeliveryAddress = new System.Windows.Forms.Label();
            this.textBoxDeliveryAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.groupBoxPizzaSelection = new System.Windows.Forms.GroupBox();
            this.textBoxSelectedCost = new System.Windows.Forms.TextBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonClearOrder = new System.Windows.Forms.Button();
            this.checkBoxCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxOlive = new System.Windows.Forms.CheckBox();
            this.checkBoxPepper = new System.Windows.Forms.CheckBox();
            this.checkBoxPineapple = new System.Windows.Forms.CheckBox();
            this.checkBoxMushroom = new System.Windows.Forms.CheckBox();
            this.checkBoxSausage = new System.Windows.Forms.CheckBox();
            this.checkBoxHam = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.labelExtraToppings = new System.Windows.Forms.Label();
            this.comboBoxPizzaType = new System.Windows.Forms.ComboBox();
            this.labelPizzaType = new System.Windows.Forms.Label();
            this.comboBoxPizzaSize = new System.Windows.Forms.ComboBox();
            this.labelPizzaSize = new System.Windows.Forms.Label();
            this.labelOrdersSummary = new System.Windows.Forms.Label();
            this.buttonClearInfo = new System.Windows.Forms.Button();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.textBoxLabelGrandTotal = new System.Windows.Forms.TextBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxOrderSummary = new System.Windows.Forms.TextBox();
            this.textBoxPizzaOrder = new System.Windows.Forms.TextBox();
            this.labelOrderSummary = new System.Windows.Forms.Label();
            this.groupBoxCustomerInfo.SuspendLayout();
            this.groupBoxPizzaSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Controls.Add(this.buttonUpdateInfo);
            this.groupBoxCustomerInfo.Controls.Add(this.labelDeliveryAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxDeliveryAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.labelPhoneNumber);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxCustomerInfo.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomerInfo.Controls.Add(this.labelOrderNumber);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxOrderNumber);
            this.groupBoxCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(12, 24);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(354, 311);
            this.groupBoxCustomerInfo.TabIndex = 0;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(91, 241);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(158, 29);
            this.buttonUpdateInfo.TabIndex = 8;
            this.buttonUpdateInfo.Text = "Update Information";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.buttonUpdateInfo_Click);
            // 
            // labelDeliveryAddress
            // 
            this.labelDeliveryAddress.AutoSize = true;
            this.labelDeliveryAddress.Location = new System.Drawing.Point(23, 176);
            this.labelDeliveryAddress.Name = "labelDeliveryAddress";
            this.labelDeliveryAddress.Size = new System.Drawing.Size(127, 20);
            this.labelDeliveryAddress.TabIndex = 7;
            this.labelDeliveryAddress.Text = "Delivery Address :";
            // 
            // textBoxDeliveryAddress
            // 
            this.textBoxDeliveryAddress.Location = new System.Drawing.Point(173, 173);
            this.textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            this.textBoxDeliveryAddress.Size = new System.Drawing.Size(143, 27);
            this.textBoxDeliveryAddress.TabIndex = 6;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(35, 129);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Phone Number :";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(173, 126);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(143, 27);
            this.textBoxPhoneNumber.TabIndex = 4;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(27, 81);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(123, 20);
            this.labelCustomerName.TabIndex = 3;
            this.labelCustomerName.Text = "Customer Name :";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(173, 78);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(143, 27);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(38, 36);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(112, 20);
            this.labelOrderNumber.TabIndex = 1;
            this.labelOrderNumber.Text = "Order Number :";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOrderNumber.Location = new System.Drawing.Point(173, 33);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(143, 27);
            this.textBoxOrderNumber.TabIndex = 0;
            // 
            // groupBoxPizzaSelection
            // 
            this.groupBoxPizzaSelection.Controls.Add(this.textBoxSelectedCost);
            this.groupBoxPizzaSelection.Controls.Add(this.buttonAddOrder);
            this.groupBoxPizzaSelection.Controls.Add(this.buttonClearOrder);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxCheese);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxOnion);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxOlive);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxPepper);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxPineapple);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxMushroom);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxSausage);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxHam);
            this.groupBoxPizzaSelection.Controls.Add(this.checkBoxPepperoni);
            this.groupBoxPizzaSelection.Controls.Add(this.labelExtraToppings);
            this.groupBoxPizzaSelection.Controls.Add(this.comboBoxPizzaType);
            this.groupBoxPizzaSelection.Controls.Add(this.labelPizzaType);
            this.groupBoxPizzaSelection.Controls.Add(this.comboBoxPizzaSize);
            this.groupBoxPizzaSelection.Controls.Add(this.labelPizzaSize);
            this.groupBoxPizzaSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPizzaSelection.Location = new System.Drawing.Point(372, 24);
            this.groupBoxPizzaSelection.Name = "groupBoxPizzaSelection";
            this.groupBoxPizzaSelection.Size = new System.Drawing.Size(518, 311);
            this.groupBoxPizzaSelection.TabIndex = 1;
            this.groupBoxPizzaSelection.TabStop = false;
            this.groupBoxPizzaSelection.Text = "Pizza Selection";
            // 
            // textBoxSelectedCost
            // 
            this.textBoxSelectedCost.BackColor = System.Drawing.Color.White;
            this.textBoxSelectedCost.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSelectedCost.Location = new System.Drawing.Point(351, 38);
            this.textBoxSelectedCost.Name = "textBoxSelectedCost";
            this.textBoxSelectedCost.ReadOnly = true;
            this.textBoxSelectedCost.Size = new System.Drawing.Size(125, 70);
            this.textBoxSelectedCost.TabIndex = 18;
            this.textBoxSelectedCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(318, 265);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(136, 29);
            this.buttonAddOrder.TabIndex = 17;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.Location = new System.Drawing.Point(71, 265);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(136, 29);
            this.buttonClearOrder.TabIndex = 16;
            this.buttonClearOrder.Text = "Clear Order";
            this.buttonClearOrder.UseVisualStyleBackColor = true;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // checkBoxCheese
            // 
            this.checkBoxCheese.AutoSize = true;
            this.checkBoxCheese.Location = new System.Drawing.Point(342, 218);
            this.checkBoxCheese.Name = "checkBoxCheese";
            this.checkBoxCheese.Size = new System.Drawing.Size(78, 24);
            this.checkBoxCheese.TabIndex = 15;
            this.checkBoxCheese.Text = "Cheese";
            this.checkBoxCheese.UseVisualStyleBackColor = true;
            this.checkBoxCheese.Click += new System.EventHandler(this.checkBoxNonVegToppings_CheckedChanged);
            // 
            // checkBoxOnion
            // 
            this.checkBoxOnion.AutoSize = true;
            this.checkBoxOnion.Location = new System.Drawing.Point(342, 188);
            this.checkBoxOnion.Name = "checkBoxOnion";
            this.checkBoxOnion.Size = new System.Drawing.Size(77, 24);
            this.checkBoxOnion.TabIndex = 14;
            this.checkBoxOnion.Text = "Onions";
            this.checkBoxOnion.UseVisualStyleBackColor = true;
            this.checkBoxOnion.Click += new System.EventHandler(this.checkBoxVegToppings_CheckedChanged);
            // 
            // checkBoxOlive
            // 
            this.checkBoxOlive.AutoSize = true;
            this.checkBoxOlive.Location = new System.Drawing.Point(342, 158);
            this.checkBoxOlive.Name = "checkBoxOlive";
            this.checkBoxOlive.Size = new System.Drawing.Size(71, 24);
            this.checkBoxOlive.TabIndex = 13;
            this.checkBoxOlive.Text = "Olives";
            this.checkBoxOlive.UseVisualStyleBackColor = true;
            this.checkBoxOlive.Click += new System.EventHandler(this.checkBoxVegToppings_CheckedChanged);
            // 
            // checkBoxPepper
            // 
            this.checkBoxPepper.AutoSize = true;
            this.checkBoxPepper.Location = new System.Drawing.Point(181, 218);
            this.checkBoxPepper.Name = "checkBoxPepper";
            this.checkBoxPepper.Size = new System.Drawing.Size(83, 24);
            this.checkBoxPepper.TabIndex = 12;
            this.checkBoxPepper.Text = "Peppers";
            this.checkBoxPepper.UseVisualStyleBackColor = true;
            this.checkBoxPepper.Click += new System.EventHandler(this.checkBoxVegToppings_CheckedChanged);
            // 
            // checkBoxPineapple
            // 
            this.checkBoxPineapple.AutoSize = true;
            this.checkBoxPineapple.Location = new System.Drawing.Point(181, 188);
            this.checkBoxPineapple.Name = "checkBoxPineapple";
            this.checkBoxPineapple.Size = new System.Drawing.Size(97, 24);
            this.checkBoxPineapple.TabIndex = 11;
            this.checkBoxPineapple.Text = "Pineapple";
            this.checkBoxPineapple.UseVisualStyleBackColor = true;
            this.checkBoxPineapple.Click += new System.EventHandler(this.checkBoxVegToppings_CheckedChanged);
            // 
            // checkBoxMushroom
            // 
            this.checkBoxMushroom.AutoSize = true;
            this.checkBoxMushroom.Location = new System.Drawing.Point(181, 158);
            this.checkBoxMushroom.Name = "checkBoxMushroom";
            this.checkBoxMushroom.Size = new System.Drawing.Size(108, 24);
            this.checkBoxMushroom.TabIndex = 10;
            this.checkBoxMushroom.Text = "Mushrooms";
            this.checkBoxMushroom.UseVisualStyleBackColor = true;
            this.checkBoxMushroom.Click += new System.EventHandler(this.checkBoxVegToppings_CheckedChanged);
            // 
            // checkBoxSausage
            // 
            this.checkBoxSausage.AutoSize = true;
            this.checkBoxSausage.Location = new System.Drawing.Point(24, 218);
            this.checkBoxSausage.Name = "checkBoxSausage";
            this.checkBoxSausage.Size = new System.Drawing.Size(86, 24);
            this.checkBoxSausage.TabIndex = 9;
            this.checkBoxSausage.Text = "Sausage";
            this.checkBoxSausage.UseVisualStyleBackColor = true;
            this.checkBoxSausage.Click += new System.EventHandler(this.checkBoxNonVegToppings_CheckedChanged);
            // 
            // checkBoxHam
            // 
            this.checkBoxHam.AutoSize = true;
            this.checkBoxHam.Location = new System.Drawing.Point(24, 188);
            this.checkBoxHam.Name = "checkBoxHam";
            this.checkBoxHam.Size = new System.Drawing.Size(63, 24);
            this.checkBoxHam.TabIndex = 8;
            this.checkBoxHam.Text = "Ham";
            this.checkBoxHam.UseVisualStyleBackColor = true;
            this.checkBoxHam.Click += new System.EventHandler(this.checkBoxNonVegToppings_CheckedChanged);
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(24, 158);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(98, 24);
            this.checkBoxPepperoni.TabIndex = 2;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            this.checkBoxPepperoni.Click += new System.EventHandler(this.checkBoxNonVegToppings_CheckedChanged);
            // 
            // labelExtraToppings
            // 
            this.labelExtraToppings.AutoSize = true;
            this.labelExtraToppings.Location = new System.Drawing.Point(24, 126);
            this.labelExtraToppings.Name = "labelExtraToppings";
            this.labelExtraToppings.Size = new System.Drawing.Size(114, 20);
            this.labelExtraToppings.TabIndex = 7;
            this.labelExtraToppings.Text = "Extra Toppings :";
            // 
            // comboBoxPizzaType
            // 
            this.comboBoxPizzaType.FormattingEnabled = true;
            this.comboBoxPizzaType.Location = new System.Drawing.Point(131, 78);
            this.comboBoxPizzaType.Name = "comboBoxPizzaType";
            this.comboBoxPizzaType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPizzaType.TabIndex = 4;
            // 
            // labelPizzaType
            // 
            this.labelPizzaType.AutoSize = true;
            this.labelPizzaType.Location = new System.Drawing.Point(24, 85);
            this.labelPizzaType.Name = "labelPizzaType";
            this.labelPizzaType.Size = new System.Drawing.Size(85, 20);
            this.labelPizzaType.TabIndex = 5;
            this.labelPizzaType.Text = "Pizza Type :";
            // 
            // comboBoxPizzaSize
            // 
            this.comboBoxPizzaSize.FormattingEnabled = true;
            this.comboBoxPizzaSize.Location = new System.Drawing.Point(131, 33);
            this.comboBoxPizzaSize.Name = "comboBoxPizzaSize";
            this.comboBoxPizzaSize.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPizzaSize.TabIndex = 2;
            this.comboBoxPizzaSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxPizzaSize_SelectedIndexChanged);
            // 
            // labelPizzaSize
            // 
            this.labelPizzaSize.AutoSize = true;
            this.labelPizzaSize.Location = new System.Drawing.Point(24, 40);
            this.labelPizzaSize.Name = "labelPizzaSize";
            this.labelPizzaSize.Size = new System.Drawing.Size(81, 20);
            this.labelPizzaSize.TabIndex = 3;
            this.labelPizzaSize.Text = "Pizza Size :";
            // 
            // labelOrdersSummary
            // 
            this.labelOrdersSummary.AutoSize = true;
            this.labelOrdersSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrdersSummary.Location = new System.Drawing.Point(12, 338);
            this.labelOrdersSummary.Name = "labelOrdersSummary";
            this.labelOrdersSummary.Size = new System.Drawing.Size(162, 25);
            this.labelOrdersSummary.TabIndex = 3;
            this.labelOrdersSummary.Text = "Orders Summary :";
            // 
            // buttonClearInfo
            // 
            this.buttonClearInfo.Location = new System.Drawing.Point(88, 552);
            this.buttonClearInfo.Name = "buttonClearInfo";
            this.buttonClearInfo.Size = new System.Drawing.Size(189, 29);
            this.buttonClearInfo.TabIndex = 4;
            this.buttonClearInfo.Text = "Clear Information";
            this.buttonClearInfo.UseVisualStyleBackColor = true;
            this.buttonClearInfo.Click += new System.EventHandler(this.buttonClearInfo_Click);
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGrandTotal.Location = new System.Drawing.Point(491, 510);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new System.Drawing.Size(399, 30);
            this.textBoxGrandTotal.TabIndex = 5;
            // 
            // textBoxLabelGrandTotal
            // 
            this.textBoxLabelGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLabelGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLabelGrandTotal.Location = new System.Drawing.Point(372, 510);
            this.textBoxLabelGrandTotal.Name = "textBoxLabelGrandTotal";
            this.textBoxLabelGrandTotal.Size = new System.Drawing.Size(122, 30);
            this.textBoxLabelGrandTotal.TabIndex = 6;
            this.textBoxLabelGrandTotal.Text = "Grand Total :";
            this.textBoxLabelGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(443, 552);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(158, 29);
            this.buttonClearAll.TabIndex = 7;
            this.buttonClearAll.Text = "Clear All Orders";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(668, 552);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(158, 29);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxOrderSummary
            // 
            this.textBoxOrderSummary.BackColor = System.Drawing.Color.White;
            this.textBoxOrderSummary.Location = new System.Drawing.Point(12, 389);
            this.textBoxOrderSummary.Multiline = true;
            this.textBoxOrderSummary.Name = "textBoxOrderSummary";
            this.textBoxOrderSummary.ReadOnly = true;
            this.textBoxOrderSummary.Size = new System.Drawing.Size(354, 151);
            this.textBoxOrderSummary.TabIndex = 9;
            // 
            // textBoxPizzaOrder
            // 
            this.textBoxPizzaOrder.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPizzaOrder.Location = new System.Drawing.Point(372, 373);
            this.textBoxPizzaOrder.Multiline = true;
            this.textBoxPizzaOrder.Name = "textBoxPizzaOrder";
            this.textBoxPizzaOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPizzaOrder.Size = new System.Drawing.Size(518, 138);
            this.textBoxPizzaOrder.TabIndex = 10;
            // 
            // labelOrderSummary
            // 
            this.labelOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrderSummary.Location = new System.Drawing.Point(12, 364);
            this.labelOrderSummary.Name = "labelOrderSummary";
            this.labelOrderSummary.Size = new System.Drawing.Size(354, 25);
            this.labelOrderSummary.TabIndex = 12;
            this.labelOrderSummary.Text = "Order No  |  Customer Name  |  Price";
            // 
            // GlobalPizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 593);
            this.Controls.Add(this.labelOrderSummary);
            this.Controls.Add(this.textBoxPizzaOrder);
            this.Controls.Add(this.textBoxOrderSummary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.textBoxLabelGrandTotal);
            this.Controls.Add(this.textBoxGrandTotal);
            this.Controls.Add(this.buttonClearInfo);
            this.Controls.Add(this.labelOrdersSummary);
            this.Controls.Add(this.groupBoxPizzaSelection);
            this.Controls.Add(this.groupBoxCustomerInfo);
            this.Name = "GlobalPizzaShop";
            this.Text = "Global Pizza Shop";
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            this.groupBoxPizzaSelection.ResumeLayout(false);
            this.groupBoxPizzaSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxCustomerInfo;
        private GroupBox groupBoxPizzaSelection;
        private Label labelOrderNumber;
        private Label labelCustomerName;
        private TextBox textBoxCustomerName;
        private Label labelDeliveryAddress;
        private TextBox textBoxDeliveryAddress;
        private Label labelPhoneNumber;
        private TextBox textBoxPhoneNumber;
        private Button buttonUpdateInfo;
        private Label labelPizzaSize;
        private Button buttonAddOrder;
        private Button buttonClearOrder;
        private CheckBox checkBoxCheese;
        private CheckBox checkBoxOnion;
        private CheckBox checkBoxOlive;
        private CheckBox checkBoxPepper;
        private CheckBox checkBoxPineapple;
        private CheckBox checkBoxMushroom;
        private CheckBox checkBoxSausage;
        private CheckBox checkBoxHam;
        private CheckBox checkBoxPepperoni;
        private Label labelExtraToppings;
        private ComboBox comboBoxPizzaType;
        private Label labelPizzaType;
        private ComboBox comboBoxPizzaSize;
        private Label labelOrdersSummary;
        private Button buttonClearInfo;
        private TextBox textBoxGrandTotal;
        private TextBox textBoxLabelGrandTotal;
        private TextBox textBoxSelectedCost;
        private Button buttonClearAll;
        private Button buttonExit;
        private TextBox textBoxOrderNumber;
        private TextBox textBoxOrderSummary;
        private TextBox textBoxPizzaOrder;
        private Label labelOrderSummary;
    }
}