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
        Log log = new Log();
        string json;

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
                    Point.Enabled = true;

                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Plus;
                    return;
                }
                if (btn == MinusButton)
                {
                    Point.Enabled = true;

                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Minus;
                    return;
                }
                if (btn == MultButton)
                {
                    Point.Enabled = true;

                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Mult;
                    return;
                }
                if (btn == DivisionButton)
                {
                    Point.Enabled = true;

                    this.Field.Text = null;
                    value2 = value;
                    button = (int)ButtonPressed.Division;
                    return;
                }

                this.Field.Text += btn.Text;
                if (btn != Point)
                    value = Convert.ToDouble(this.Field.Text);

            }

        }

        private void Clear(object sender, EventArgs e)
        {
            this.Field.Text = null;
            value = default;
            value2 = default;
            HistoryBox.Items.Clear();
            Log.ClearJson();

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
            Point.Enabled = true;
            switch (button)
            {
                case 0:
                    this.Field.Text = (value2 + value).ToString();
                    log.SaveJson(value2.ToString() + " + " + value.ToString() + " = " + (value2 + value).ToString() + "\n");

                    break;
                case 1:
                    this.Field.Text = (value2 - value).ToString();
                    log.SaveJson(value2.ToString() + " - " + value.ToString() + " = " + (value2 - value).ToString() + "\n");

                    break;
                case 2:
                    this.Field.Text = (value2 * value).ToString();
                    log.SaveJson(value2.ToString() + " * " + value.ToString() + " = " + (value2 * value).ToString() + "\n");

                    break;
                case 3:
                    if (value == 0 || value2 == 0)
                        throw new DivideByZeroException();
                    this.Field.Text = (value2 / value).ToString();
                    log.SaveJson(value2.ToString() + " / " + value.ToString() + " = " + (value2 / value).ToString() + "\n");

                    break;
            }
            HistoryBox.Items.Add(Log.LoadJson());
            this.Field.Text = null;
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.ClearJson();
        }
    }
}