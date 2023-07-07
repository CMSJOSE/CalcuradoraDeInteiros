namespace CalcuradoraDeInteiros
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
            Display = new TextBox();
            btn_0 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // Display
            // 
            Display.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Display.Location = new Point(12, 88);
            Display.Name = "Display";
            Display.Size = new Size(221, 31);
            Display.TabIndex = 3;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(123, 306);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(47, 34);
            btn_0.TabIndex = 5;
            btn_0.Text = "1";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 306);
            button2.Name = "button2";
            button2.Size = new Size(44, 34);
            button2.TabIndex = 6;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(73, 226);
            button4.Name = "button4";
            button4.Size = new Size(44, 34);
            button4.TabIndex = 8;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(24, 306);
            button5.Name = "button5";
            button5.Size = new Size(41, 34);
            button5.TabIndex = 9;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(24, 266);
            button6.Name = "button6";
            button6.Size = new Size(43, 34);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(125, 266);
            button7.Name = "button7";
            button7.Size = new Size(45, 34);
            button7.TabIndex = 11;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(73, 266);
            button8.Name = "button8";
            button8.Size = new Size(44, 34);
            button8.TabIndex = 12;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(125, 226);
            button9.Name = "button9";
            button9.Size = new Size(45, 34);
            button9.TabIndex = 13;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(24, 226);
            button10.Name = "button10";
            button10.Size = new Size(43, 34);
            button10.TabIndex = 14;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(24, 346);
            button11.Name = "button11";
            button11.Size = new Size(41, 34);
            button11.TabIndex = 15;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(73, 346);
            button12.Name = "button12";
            button12.Size = new Size(97, 34);
            button12.TabIndex = 16;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(176, 226);
            button13.Name = "button13";
            button13.Size = new Size(57, 34);
            button13.TabIndex = 17;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(176, 306);
            button14.Name = "button14";
            button14.Size = new Size(57, 34);
            button14.TabIndex = 18;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(176, 266);
            button15.Name = "button15";
            button15.Size = new Size(57, 34);
            button15.TabIndex = 19;
            button15.TabStop = false;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(176, 346);
            button16.Name = "button16";
            button16.Size = new Size(57, 34);
            button16.TabIndex = 20;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 450);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(btn_0);
            Controls.Add(Display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Display;
        private Button btn_0;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}