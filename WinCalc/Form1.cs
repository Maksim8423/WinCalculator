namespace WinCalc
{
    public partial class Calculator : Form
    {
        bool flag = false;
        double a, b;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Input(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if(btn == null )
                {
                    Point.Enabled = false;
                }

                if (btn == Point)
                {
                    flag = true;
                    Point.Enabled = false;
                }
                this.Field.Text += btn.Text;
                a = Convert.ToDouble(btn.Text);
            }
        }

        private void Clear(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {

        }

        private void MultButton_Click(object sender, EventArgs e)
        {

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {

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


    }
}