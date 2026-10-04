namespace WinFormsApp1
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
            btn1 = new Button();
            txtDisplay = new RichTextBox();
            rtbHistory = new RichTextBox();
            btn4 = new Button();
            btn7 = new Button();
            button4 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnEquals = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnDel = new Button();
            btnClear = new Button();
            btnSqrt = new Button();
            btnSquare = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.Location = new Point(12, 116);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // txtDisplay
            // 
            txtDisplay.AccessibleRole = AccessibleRole.Grip;
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Location = new Point(0, 0);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.RightToLeft = RightToLeft.Yes;
            txtDisplay.ScrollBars = RichTextBoxScrollBars.None;
            txtDisplay.Size = new Size(685, 99);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "";
            // 
            // rtbHistory
            // 
            rtbHistory.Dock = DockStyle.Right;
            rtbHistory.Location = new Point(539, 99);
            rtbHistory.Name = "rtbHistory";
            rtbHistory.Size = new Size(146, 415);
            rtbHistory.TabIndex = 2;
            rtbHistory.Text = "";
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaption;
            btn4.Location = new Point(12, 221);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaption;
            btn7.Location = new Point(12, 335);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(12, 442);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 5;
            button4.Text = ".";
            button4.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaption;
            btn2.Location = new Point(134, 116);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ActiveCaption;
            btn5.Location = new Point(134, 221);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaption;
            btn8.Location = new Point(134, 335);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaption;
            btn0.Location = new Point(134, 442);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 60);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaption;
            btn3.Location = new Point(254, 116);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ActiveCaption;
            btn6.Location = new Point(254, 221);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaption;
            btn9.Location = new Point(254, 335);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Green;
            btnEquals.ForeColor = SystemColors.ButtonFace;
            btnEquals.Location = new Point(254, 442);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(60, 60);
            btnEquals.TabIndex = 13;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(368, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 60);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Blue;
            btnSub.ForeColor = SystemColors.ButtonFace;
            btnSub.Location = new Point(368, 221);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(60, 60);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.Blue;
            btnMul.ForeColor = SystemColors.ButtonFace;
            btnMul.Location = new Point(368, 335);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(60, 60);
            btnMul.TabIndex = 16;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Blue;
            btnDiv.ForeColor = SystemColors.ButtonFace;
            btnDiv.Location = new Point(368, 442);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(60, 60);
            btnDiv.TabIndex = 17;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(192, 0, 0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(473, 116);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(60, 60);
            btnDel.TabIndex = 18;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 0, 0);
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(473, 221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 19;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Green;
            btnSqrt.ForeColor = SystemColors.ButtonFace;
            btnSqrt.Location = new Point(473, 335);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(60, 60);
            btnSqrt.TabIndex = 20;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.Green;
            btnSquare.ForeColor = SystemColors.ButtonFace;
            btnSquare.Location = new Point(473, 442);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(60, 60);
            btnSquare.TabIndex = 21;
            btnSquare.Text = "X^2";
            btnSquare.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(685, 514);
            Controls.Add(btnSquare);
            Controls.Add(btnSqrt);
            Controls.Add(btnClear);
            Controls.Add(btnDel);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(button4);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(rtbHistory);
            Controls.Add(txtDisplay);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private RichTextBox txtDisplay;
        private RichTextBox rtbHistory;
        private Button btn4;
        private Button btn7;
        private Button button4;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn0;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnEquals;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnDel;
        private Button btnClear;
        private Button btnSqrt;
        private Button btnSquare;
    }
}
