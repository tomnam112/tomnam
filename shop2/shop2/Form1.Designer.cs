namespace shop2
{
    partial class Form1
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            CoffeePrice = new TextBox();
            GreenTeaPrice = new TextBox();
            CoffeeQuantity = new TextBox();
            GreenTeaQuntity = new TextBox();
            tbtotal = new TextBox();
            ddddddd = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AccessibleDescription = "tbcoffee";
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "coffee";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 74);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "green tea";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Location = new Point(177, 32);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(125, 27);
            CoffeePrice.TabIndex = 2;
            // 
            // GreenTeaPrice
            // 
            GreenTeaPrice.Location = new Point(177, 76);
            GreenTeaPrice.Name = "GreenTeaPrice";
            GreenTeaPrice.Size = new Size(125, 27);
            GreenTeaPrice.TabIndex = 3;
            // 
            // CoffeeQuantity
            // 
            CoffeeQuantity.Location = new Point(345, 29);
            CoffeeQuantity.Name = "CoffeeQuantity";
            CoffeeQuantity.Size = new Size(125, 27);
            CoffeeQuantity.TabIndex = 4;
            // 
            // GreenTeaQuntity
            // 
            GreenTeaQuntity.Location = new Point(345, 76);
            GreenTeaQuntity.Name = "GreenTeaQuntity";
            GreenTeaQuntity.Size = new Size(125, 27);
            GreenTeaQuntity.TabIndex = 5;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(345, 182);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(125, 27);
            tbtotal.TabIndex = 6;
            // 
            // ddddddd
            // 
            ddddddd.AutoSize = true;
            ddddddd.Location = new Point(252, 182);
            ddddddd.Name = "ddddddd";
            ddddddd.Size = new Size(30, 20);
            ddddddd.TabIndex = 7;
            ddddddd.Text = "รวม";
            // 
            // button1
            // 
            button1.Location = new Point(511, 29);
            button1.Name = "button1";
            button1.Size = new Size(196, 184);
            button1.TabIndex = 8;
            button1.Text = "check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ddddddd);
            Controls.Add(tbtotal);
            Controls.Add(GreenTeaQuntity);
            Controls.Add(CoffeeQuantity);
            Controls.Add(GreenTeaPrice);
            Controls.Add(CoffeePrice);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox CoffeePrice;
        private TextBox GreenTeaPrice;
        private TextBox CoffeeQuantity;
        private TextBox GreenTeaQuntity;
        private TextBox tbtotal;
        private Label ddddddd;
        private Button button1;
    }
}
