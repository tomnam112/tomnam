namespace shop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputnum1 = CoffeePrice.Text;
            string inputnum2 = CoffeeQuantity.Text;
            float input1, input2;

            bool isvalidCoffeePrice = float.TryParse(inputnum1, out input1);
            bool isvalidCoffeeQuantity = float.TryParse(inputnum2, out input2);

            string inputnum3 = GreenTeaPrice.Text;
            string inputnum4 = GreenTeaQuntity.Text;
            float input3, input4;

            bool isvalidGreenTeaPrice = float.TryParse(inputnum3, out input3);
            bool isvalidGreenTeaQuantity = float.TryParse(inputnum4, out input4);

            if (isvalidGreenTeaPrice && isvalidGreenTeaQuantity && isvalidGreenTeaPrice && isvalidGreenTeaQuantity)
            {
                float result1 = input1 * input2;
                float result2 = input3 * input4;
                float total = result1 + result2;

                tbtotal.Text = "กรุณาใส่ข้อมูลให้ถูกต้อง";
            }
        }
    }
}
