namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((textBox.Text == "0") || (isOperationPerformed))
                textBox.Clear();
            isOperationPerformed= false;

            if (button.Text == ".")
            { 
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + button.Text;
            }
            else
                textBox.Text = textBox.Text + button.Text;
        }

        private void opBtn(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            if (resultValue != 0)
            {
                equalBtn.PerformClick();
                isOperationPerformed = true;
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox.Text);
            }
            else 
            { 
                isOperationPerformed = true;
                operationPerformed= button.Text;
                resultValue = Double.Parse(textBox.Text);
            }
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString(); 
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}