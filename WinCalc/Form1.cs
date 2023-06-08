using System.Text.Json;
namespace WinCalc
{
    enum ButtonPressed
    {
        Plus = 0,
        Minus = 1,
        Mult = 2,
        Division = 3
    }
    public partial class Calculator : Form
    {
        bool flag = false;
        double value, value2;
        int button;

        ButtonPressed buttonPressed = default;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Input(object sender, EventArgs e)
        {
            
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (btn == null)
                {
                    Point.Enabled = false;
                }

                if (btn == Point)
                {
                    flag = true;
                    Point.Enabled = false;
                }
                if (btn == PlusButton)
                {
                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Plus;
                    return;
                }
                if (btn == MinusButton)
                {
                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Minus;
                    return;
                }
                if (btn == MultButton)
                {
                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Mult;
                    return;
                }
                if (btn == DivisionButton)
                {
                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Division;
                    return;
                }

                this.Field.Text += btn.Text;
                if(btn != Point)
                    value = Convert.ToDouble(this.Field.Text);

            }
        }

        private void Clear(object sender, EventArgs e)
        {
            this.Field.Text = null;
            value = default;
            value2 = default;

            flag = false;
        }



        private void Backspace(object sender, EventArgs e)
        {
            if (this.Field.Text.Length == 0)
            {
                return;
            }

            this.Field.Text = this.Field.Text.Remove(this.Field.Text.Length - 1);
            return;
        }



        private void EqualsButton_Click(object sender, EventArgs e)
        {
            switch (button)
            {
                case 0:
                    this.Field.Text = (value2 + value).ToString();
                    break;
                case 1:
                    this.Field.Text = (value2 - value).ToString();
                    break;
                case 2:
                    this.Field.Text = (value2 * value).ToString();
                    break;
                case 3:
                    if (value == 0 || value2 == 0)
                        throw new DivideByZeroException();
                    this.Field.Text = (value2 / value).ToString();
                    break;
            }
        }
    }
}