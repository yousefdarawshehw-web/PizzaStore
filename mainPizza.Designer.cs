namespace TryStoreAgainPizza
{
    partial class mainPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRadLarge = new System.Windows.Forms.RadioButton();
            this.BtmRadMed = new System.Windows.Forms.RadioButton();
            this.BtnRadSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRadThink = new System.Windows.Forms.RadioButton();
            this.BtnRadThin = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnRadEatOut = new System.Windows.Forms.RadioButton();
            this.BtnRadEatIn = new System.Windows.Forms.RadioButton();
            this.btnChExtraChees = new System.Windows.Forms.CheckBox();
            this.BtnChMushrooms = new System.Windows.Forms.CheckBox();
            this.BtnChTomatoes = new System.Windows.Forms.CheckBox();
            this.BtnChOnion = new System.Windows.Forms.CheckBox();
            this.BtnChOlives = new System.Windows.Forms.CheckBox();
            this.BtnChGreenPeppers = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labCrusst = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.LabSize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRadLarge);
            this.groupBox1.Controls.Add(this.BtmRadMed);
            this.groupBox1.Controls.Add(this.BtnRadSmall);
            this.groupBox1.Location = new System.Drawing.Point(47, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIZE";
            // 
            // BtnRadLarge
            // 
            this.BtnRadLarge.AutoSize = true;
            this.BtnRadLarge.Location = new System.Drawing.Point(24, 105);
            this.BtnRadLarge.Name = "BtnRadLarge";
            this.BtnRadLarge.Size = new System.Drawing.Size(52, 17);
            this.BtnRadLarge.TabIndex = 2;
            this.BtnRadLarge.Text = "Large";
            this.BtnRadLarge.UseVisualStyleBackColor = true;
            this.BtnRadLarge.CheckedChanged += new System.EventHandler(this.BtnRadLarge_CheckedChanged);
            // 
            // BtmRadMed
            // 
            this.BtmRadMed.AutoSize = true;
            this.BtmRadMed.Location = new System.Drawing.Point(24, 62);
            this.BtmRadMed.Name = "BtmRadMed";
            this.BtmRadMed.Size = new System.Drawing.Size(61, 17);
            this.BtmRadMed.TabIndex = 1;
            this.BtmRadMed.Text = "Meduim";
            this.BtmRadMed.UseVisualStyleBackColor = true;
            this.BtmRadMed.CheckedChanged += new System.EventHandler(this.BtmRadMed_CheckedChanged);
            // 
            // BtnRadSmall
            // 
            this.BtnRadSmall.AutoSize = true;
            this.BtnRadSmall.Location = new System.Drawing.Point(24, 19);
            this.BtnRadSmall.Name = "BtnRadSmall";
            this.BtnRadSmall.Size = new System.Drawing.Size(49, 17);
            this.BtnRadSmall.TabIndex = 0;
            this.BtnRadSmall.Text = "Small";
            this.BtnRadSmall.UseVisualStyleBackColor = true;
            this.BtnRadSmall.CheckedChanged += new System.EventHandler(this.BtnRadSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRadThink);
            this.groupBox2.Controls.Add(this.BtnRadThin);
            this.groupBox2.Location = new System.Drawing.Point(47, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // BtnRadThink
            // 
            this.BtnRadThink.AutoSize = true;
            this.BtnRadThink.Location = new System.Drawing.Point(24, 77);
            this.BtnRadThink.Name = "BtnRadThink";
            this.BtnRadThink.Size = new System.Drawing.Size(79, 17);
            this.BtnRadThink.TabIndex = 1;
            this.BtnRadThink.Text = "Think Crust";
            this.BtnRadThink.UseVisualStyleBackColor = true;
            this.BtnRadThink.CheckedChanged += new System.EventHandler(this.BtnRadThink_CheckedChanged);
            // 
            // BtnRadThin
            // 
            this.BtnRadThin.AutoSize = true;
            this.BtnRadThin.Location = new System.Drawing.Point(24, 35);
            this.BtnRadThin.Name = "BtnRadThin";
            this.BtnRadThin.Size = new System.Drawing.Size(74, 17);
            this.BtnRadThin.TabIndex = 0;
            this.BtnRadThin.Text = "Thin Crust";
            this.BtnRadThin.UseVisualStyleBackColor = true;
            this.BtnRadThin.CheckedChanged += new System.EventHandler(this.BtnRadThin_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnRadEatOut);
            this.groupBox5.Controls.Add(this.BtnRadEatIn);
            this.groupBox5.Location = new System.Drawing.Point(234, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Where To Eat";
            // 
            // BtnRadEatOut
            // 
            this.BtnRadEatOut.AutoSize = true;
            this.BtnRadEatOut.Location = new System.Drawing.Point(135, 35);
            this.BtnRadEatOut.Name = "BtnRadEatOut";
            this.BtnRadEatOut.Size = new System.Drawing.Size(69, 17);
            this.BtnRadEatOut.TabIndex = 1;
            this.BtnRadEatOut.TabStop = true;
            this.BtnRadEatOut.Text = "Take Out";
            this.BtnRadEatOut.UseVisualStyleBackColor = true;
            this.BtnRadEatOut.CheckedChanged += new System.EventHandler(this.BtnRadEatOut_CheckedChanged);
            // 
            // BtnRadEatIn
            // 
            this.BtnRadEatIn.AutoSize = true;
            this.BtnRadEatIn.Location = new System.Drawing.Point(22, 35);
            this.BtnRadEatIn.Name = "BtnRadEatIn";
            this.BtnRadEatIn.Size = new System.Drawing.Size(54, 17);
            this.BtnRadEatIn.TabIndex = 0;
            this.BtnRadEatIn.TabStop = true;
            this.BtnRadEatIn.Text = "Eat In";
            this.BtnRadEatIn.UseVisualStyleBackColor = true;
            this.BtnRadEatIn.CheckedChanged += new System.EventHandler(this.BtnRadEatIn_CheckedChanged);
            // 
            // btnChExtraChees
            // 
            this.btnChExtraChees.AutoSize = true;
            this.btnChExtraChees.Location = new System.Drawing.Point(21, 31);
            this.btnChExtraChees.Name = "btnChExtraChees";
            this.btnChExtraChees.Size = new System.Drawing.Size(85, 17);
            this.btnChExtraChees.TabIndex = 0;
            this.btnChExtraChees.Text = "Extra Chees";
            this.btnChExtraChees.UseVisualStyleBackColor = true;
            this.btnChExtraChees.CheckedChanged += new System.EventHandler(this.btnChExtraChees_CheckedChanged);
            // 
            // BtnChMushrooms
            // 
            this.BtnChMushrooms.AutoSize = true;
            this.BtnChMushrooms.Location = new System.Drawing.Point(21, 79);
            this.BtnChMushrooms.Name = "BtnChMushrooms";
            this.BtnChMushrooms.Size = new System.Drawing.Size(80, 17);
            this.BtnChMushrooms.TabIndex = 1;
            this.BtnChMushrooms.Text = "Mushrooms";
            this.BtnChMushrooms.UseVisualStyleBackColor = true;
            this.BtnChMushrooms.CheckedChanged += new System.EventHandler(this.BtnChMushrooms_CheckedChanged);
            // 
            // BtnChTomatoes
            // 
            this.BtnChTomatoes.AutoSize = true;
            this.BtnChTomatoes.Location = new System.Drawing.Point(21, 123);
            this.BtnChTomatoes.Name = "BtnChTomatoes";
            this.BtnChTomatoes.Size = new System.Drawing.Size(73, 17);
            this.BtnChTomatoes.TabIndex = 2;
            this.BtnChTomatoes.Text = "Tomatoes";
            this.BtnChTomatoes.UseVisualStyleBackColor = true;
            this.BtnChTomatoes.CheckedChanged += new System.EventHandler(this.BtnChTomatoes_CheckedChanged);
            // 
            // BtnChOnion
            // 
            this.BtnChOnion.AutoSize = true;
            this.BtnChOnion.Location = new System.Drawing.Point(134, 31);
            this.BtnChOnion.Name = "BtnChOnion";
            this.BtnChOnion.Size = new System.Drawing.Size(54, 17);
            this.BtnChOnion.TabIndex = 3;
            this.BtnChOnion.Text = "Onion";
            this.BtnChOnion.UseVisualStyleBackColor = true;
            this.BtnChOnion.CheckedChanged += new System.EventHandler(this.BtnChOnion_CheckedChanged);
            // 
            // BtnChOlives
            // 
            this.BtnChOlives.AutoSize = true;
            this.BtnChOlives.Location = new System.Drawing.Point(134, 79);
            this.BtnChOlives.Name = "BtnChOlives";
            this.BtnChOlives.Size = new System.Drawing.Size(55, 17);
            this.BtnChOlives.TabIndex = 4;
            this.BtnChOlives.Text = "Olives";
            this.BtnChOlives.UseVisualStyleBackColor = true;
            this.BtnChOlives.CheckedChanged += new System.EventHandler(this.BtnChOlives_CheckedChanged);
            // 
            // BtnChGreenPeppers
            // 
            this.BtnChGreenPeppers.AutoSize = true;
            this.BtnChGreenPeppers.Location = new System.Drawing.Point(134, 123);
            this.BtnChGreenPeppers.Name = "BtnChGreenPeppers";
            this.BtnChGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.BtnChGreenPeppers.TabIndex = 5;
            this.BtnChGreenPeppers.Text = "Green Peppers";
            this.BtnChGreenPeppers.UseVisualStyleBackColor = true;
            this.BtnChGreenPeppers.CheckedChanged += new System.EventHandler(this.BtnChGreenPeppers_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(11, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.BtnChGreenPeppers);
            this.groupBox3.Controls.Add(this.BtnChOlives);
            this.groupBox3.Controls.Add(this.BtnChOnion);
            this.groupBox3.Controls.Add(this.BtnChTomatoes);
            this.groupBox3.Controls.Add(this.BtnChMushrooms);
            this.groupBox3.Controls.Add(this.btnChExtraChees);
            this.groupBox3.Location = new System.Drawing.Point(245, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 140);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labTotalPrice);
            this.groupBox6.Controls.Add(this.labWhereToEat);
            this.groupBox6.Controls.Add(this.labCrusst);
            this.groupBox6.Controls.Add(this.labToppings);
            this.groupBox6.Controls.Add(this.LabSize);
            this.groupBox6.Location = new System.Drawing.Point(522, 144);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 259);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Order Summary";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Location = new System.Drawing.Point(38, 200);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(67, 13);
            this.labTotalPrice.TabIndex = 4;
            this.labTotalPrice.Text = "Total Price : ";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Location = new System.Drawing.Point(38, 165);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(83, 13);
            this.labWhereToEat.TabIndex = 3;
            this.labWhereToEat.Text = "Where To Eat : ";
            // 
            // labCrusst
            // 
            this.labCrusst.AutoSize = true;
            this.labCrusst.Location = new System.Drawing.Point(38, 126);
            this.labCrusst.Name = "labCrusst";
            this.labCrusst.Size = new System.Drawing.Size(67, 13);
            this.labCrusst.TabIndex = 2;
            this.labCrusst.Text = "Crust Type :";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Location = new System.Drawing.Point(38, 79);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(57, 13);
            this.labToppings.TabIndex = 1;
            this.labToppings.Text = "Toppings :";
            // 
            // LabSize
            // 
            this.LabSize.AutoSize = true;
            this.LabSize.Location = new System.Drawing.Point(35, 31);
            this.LabSize.Name = "LabSize";
            this.LabSize.Size = new System.Drawing.Size(36, 13);
            this.LabSize.TabIndex = 0;
            this.LabSize.Text = "Size : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Order Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "mainPizza";
            this.Text = "mainPizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BtnRadLarge;
        private System.Windows.Forms.RadioButton BtmRadMed;
        private System.Windows.Forms.RadioButton BtnRadSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BtnRadThink;
        private System.Windows.Forms.RadioButton BtnRadThin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton BtnRadEatOut;
        private System.Windows.Forms.RadioButton BtnRadEatIn;
        private System.Windows.Forms.CheckBox btnChExtraChees;
        private System.Windows.Forms.CheckBox BtnChMushrooms;
        private System.Windows.Forms.CheckBox BtnChTomatoes;
        private System.Windows.Forms.CheckBox BtnChOnion;
        private System.Windows.Forms.CheckBox BtnChOlives;
        private System.Windows.Forms.CheckBox BtnChGreenPeppers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labCrusst;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label LabSize;
        private System.Windows.Forms.Button button1;
    }
}