namespace WinCalc
{
    partial class Calculator
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
            Number7 = new Button();
            Number8 = new Button();
            Number9 = new Button();
            Number4 = new Button();
            Number5 = new Button();
            Number6 = new Button();
            Number1 = new Button();
            Number2 = new Button();
            Number3 = new Button();
            Number0 = new Button();
            MinusButton = new Button();
            DivisionButton = new Button();
            MultButton = new Button();
            PlusButton = new Button();
            Point = new Button();
            button16 = new Button();
            EqualsButton = new Button();
            Field = new TextBox();
            button1 = new Button();
            HistoryBox = new ListBox();
            SuspendLayout();
            // 
            // Number7
            // 
            Number7.Location = new Point(44, 189);
            Number7.Name = "Number7";
            Number7.Size = new Size(56, 39);
            Number7.TabIndex = 0;
            Number7.Text = "7";
            Number7.UseVisualStyleBackColor = true;
            Number7.Click += Input;
            // 
            // Number8
            // 
            Number8.Location = new Point(117, 189);
            Number8.Name = "Number8";
            Number8.Size = new Size(56, 39);
            Number8.TabIndex = 1;
            Number8.Text = "8";
            Number8.UseVisualStyleBackColor = true;
            Number8.Click += Input;
            // 
            // Number9
            // 
            Number9.Location = new Point(196, 189);
            Number9.Name = "Number9";
            Number9.Size = new Size(56, 39);
            Number9.TabIndex = 2;
            Number9.Text = "9";
            Number9.UseVisualStyleBackColor = true;
            Number9.Click += Input;
            // 
            // Number4
            // 
            Number4.Location = new Point(44, 244);
            Number4.Name = "Number4";
            Number4.Size = new Size(56, 39);
            Number4.TabIndex = 3;
            Number4.Text = "4";
            Number4.UseVisualStyleBackColor = true;
            Number4.Click += Input;
            // 
            // Number5
            // 
            Number5.Location = new Point(117, 244);
            Number5.Name = "Number5";
            Number5.Size = new Size(56, 39);
            Number5.TabIndex = 4;
            Number5.Text = "5";
            Number5.UseVisualStyleBackColor = true;
            Number5.Click += Input;
            // 
            // Number6
            // 
            Number6.Location = new Point(196, 244);
            Number6.Name = "Number6";
            Number6.Size = new Size(56, 39);
            Number6.TabIndex = 5;
            Number6.Text = "6";
            Number6.UseVisualStyleBackColor = true;
            Number6.Click += Input;
            // 
            // Number1
            // 
            Number1.Location = new Point(44, 299);
            Number1.Name = "Number1";
            Number1.Size = new Size(56, 39);
            Number1.TabIndex = 6;
            Number1.Text = "1";
            Number1.UseVisualStyleBackColor = true;
            Number1.Click += Input;
            // 
            // Number2
            // 
            Number2.Location = new Point(117, 299);
            Number2.Name = "Number2";
            Number2.Size = new Size(56, 39);
            Number2.TabIndex = 7;
            Number2.Text = "2";
            Number2.UseVisualStyleBackColor = true;
            Number2.Click += Input;
            // 
            // Number3
            // 
            Number3.Location = new Point(196, 299);
            Number3.Name = "Number3";
            Number3.Size = new Size(56, 39);
            Number3.TabIndex = 8;
            Number3.Text = "3";
            Number3.UseVisualStyleBackColor = true;
            Number3.Click += Input;
            // 
            // Number0
            // 
            Number0.Location = new Point(44, 361);
            Number0.Name = "Number0";
            Number0.Size = new Size(56, 39);
            Number0.TabIndex = 9;
            Number0.Text = "0";
            Number0.UseVisualStyleBackColor = true;
            Number0.Click += Input;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(284, 299);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(56, 39);
            MinusButton.TabIndex = 10;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += Input;
            // 
            // DivisionButton
            // 
            DivisionButton.Location = new Point(284, 189);
            DivisionButton.Name = "DivisionButton";
            DivisionButton.Size = new Size(56, 39);
            DivisionButton.TabIndex = 11;
            DivisionButton.Text = "/";
            DivisionButton.UseVisualStyleBackColor = true;
            DivisionButton.Click += Input;
            // 
            // MultButton
            // 
            MultButton.Location = new Point(284, 244);
            MultButton.Name = "MultButton";
            MultButton.Size = new Size(56, 39);
            MultButton.TabIndex = 12;
            MultButton.Text = "*";
            MultButton.UseVisualStyleBackColor = true;
            MultButton.Click += Input;
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(284, 361);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(56, 39);
            PlusButton.TabIndex = 13;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += Input;
            // 
            // Point
            // 
            Point.Location = new Point(117, 361);
            Point.Name = "Point";
            Point.Size = new Size(56, 39);
            Point.TabIndex = 14;
            Point.Text = ",";
            Point.UseVisualStyleBackColor = true;
            Point.Click += Input;
            // 
            // button16
            // 
            button16.Location = new Point(196, 361);
            button16.Name = "button16";
            button16.Size = new Size(56, 39);
            button16.TabIndex = 15;
            button16.Text = "C";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Clear;
            // 
            // EqualsButton
            // 
            EqualsButton.Location = new Point(362, 361);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(56, 39);
            EqualsButton.TabIndex = 16;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.Click += EqualsButton_Click;
            // 
            // Field
            // 
            Field.Enabled = false;
            Field.Location = new Point(44, 134);
            Field.Name = "Field";
            Field.Size = new Size(296, 23);
            Field.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(362, 189);
            button1.Name = "button1";
            button1.Size = new Size(56, 39);
            button1.TabIndex = 18;
            button1.Text = "<=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Backspace;
            // 
            // HistoryBox
            // 
            HistoryBox.FormattingEnabled = true;
            HistoryBox.ItemHeight = 15;
            HistoryBox.Location = new Point(44, 12);
            HistoryBox.Name = "HistoryBox";
            HistoryBox.Size = new Size(120, 94);
            HistoryBox.TabIndex = 19;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 542);
            Controls.Add(HistoryBox);
            Controls.Add(button1);
            Controls.Add(Field);
            Controls.Add(EqualsButton);
            Controls.Add(button16);
            Controls.Add(Point);
            Controls.Add(PlusButton);
            Controls.Add(MultButton);
            Controls.Add(DivisionButton);
            Controls.Add(MinusButton);
            Controls.Add(Number0);
            Controls.Add(Number3);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(Number6);
            Controls.Add(Number5);
            Controls.Add(Number4);
            Controls.Add(Number9);
            Controls.Add(Number8);
            Controls.Add(Number7);
            Name = "Calculator";
            Text = "Calculator";
            TopMost = true;
            FormClosed += Calculator_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Number7;
        private Button Number8;
        private Button Number9;
        private Button Number4;
        private Button Number5;
        private Button Number6;
        private Button Number1;
        private Button Number2;
        private Button Number3;
        private Button Number0;
        private Button MinusButton;
        private Button DivisionButton;
        private Button MultButton;
        private Button PlusButton;
        private Button Point;
        private Button button16;
        private Button EqualsButton;
        private TextBox Field;
        private Button button1;
        private ListBox HistoryBox;
    }
}