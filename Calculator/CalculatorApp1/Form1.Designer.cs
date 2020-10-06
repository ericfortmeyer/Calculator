using System.Windows.Forms;

namespace CalculatorApp1
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
            this.clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.DecimalPoint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkGray;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.Location = new System.Drawing.Point(0, 182);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(150, 100);
            this.clear.TabIndex = 0;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(150, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 100);
            this.button2.TabIndex = 0;
            this.button2.Text = "\r\n\r\n";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(300, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.DarkOrange;
            this.Divide.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Divide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Divide.Location = new System.Drawing.Point(450, 182);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(150, 100);
            this.Divide.TabIndex = 2;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.DarkOrange;
            this.Multiply.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Multiply.Location = new System.Drawing.Point(450, 282);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(150, 100);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.DarkOrange;
            this.Subtract.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Subtract.Location = new System.Drawing.Point(450, 382);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(150, 100);
            this.Subtract.TabIndex = 2;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkOrange;
            this.Add.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(450, 482);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 100);
            this.Add.TabIndex = 2;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.DarkOrange;
            this.equals.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equals.Location = new System.Drawing.Point(450, 582);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(150, 100);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(0, 282);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(150, 100);
            this.Seven.TabIndex = 3;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(150, 282);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(150, 100);
            this.Eight.TabIndex = 3;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(300, 282);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(150, 100);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(0, 382);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(150, 100);
            this.Four.TabIndex = 3;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(150, 382);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(150, 100);
            this.Five.TabIndex = 3;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(300, 382);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(150, 100);
            this.Six.TabIndex = 3;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(0, 482);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(150, 100);
            this.One.TabIndex = 3;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(150, 482);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(150, 100);
            this.Two.TabIndex = 3;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(300, 482);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(150, 100);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(0, 582);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(300, 100);
            this.Zero.TabIndex = 4;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // DecimalPoint
            // 
            this.DecimalPoint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecimalPoint.Location = new System.Drawing.Point(300, 582);
            this.DecimalPoint.Name = "DecimalPoint";
            this.DecimalPoint.Size = new System.Drawing.Size(150, 100);
            this.DecimalPoint.TabIndex = 3;
            this.DecimalPoint.Text = ".";
            this.DecimalPoint.UseVisualStyleBackColor = true;
            this.DecimalPoint.Click += new System.EventHandler(this.Decimal_Point_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 24, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(603, 179);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(603, 684);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DecimalPoint);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clear);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button DecimalPoint;
        private System.Windows.Forms.TextBox textBox1;
    }
}

