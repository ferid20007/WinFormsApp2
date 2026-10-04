namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double firstNum = 0;
        string operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            BindEvents();
        }

        private void BindEvents()
        {
            // Rəqəm düymələrini bir hadisəyə bağlayırıq
            Button[] numButtons = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var btn in numButtons)
            {
                if (btn != null) btn.Click += NumButton_Click;
            }

            // Əməliyyat düymələri (+, -, *, /)
            if (btnAdd != null) btnAdd.Click += OpButton_Click;
            if (btnSub != null) btnSub.Click += OpButton_Click;
            if (btnMul != null) btnMul.Click += OpButton_Click;
            if (btnDiv != null) btnDiv.Click += OpButton_Click;

            // Digər düymələr
            if (btnEquals != null) btnEquals.Click += BtnEquals_Click;
            if (btnClear != null) btnClear.Click += BtnClear_Click;
            if (btnDel != null) btnDel.Click += BtnDel_Click;
            if (btnSqrt != null) btnSqrt.Click += BtnSqrt_Click;
            if (btnSquare != null) btnSquare.Click += BtnSquare_Click;
        }

        // Rəqəmlərə basıldıqda
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0" || isOperationPerformed)
                txtDisplay.Clear();

            isOperationPerformed = false;
            txtDisplay.Text += btn.Text;
        }

        // Əməliyyat düymələrinə (+, -, *, /) basıldıqda
        private void OpButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (double.TryParse(txtDisplay.Text, out firstNum))
            {
                operation = btn.Text;
                isOperationPerformed = true;
            }
        }

        // Bərabərdir (=) düyməsi və Tarixçəyə yazmaq
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double secondNum))
            {
                double result = 0;
                bool valid = true;

                switch (operation)
                {
                    case "+": result = firstNum + secondNum; break;
                    case "-": result = firstNum - secondNum; break;
                    case "*": result = firstNum * secondNum; break;
                    case "/":
                        if (secondNum != 0) result = firstNum / secondNum;
                        else { MessageBox.Show("Sıfıra bölmək olmaz!"); valid = false; }
                        break;
                    default: valid = false; break;
                }

                if (valid)
                {
                    string historyEntry = $"{firstNum} {operation} {secondNum} = {result}\n";
                    txtDisplay.Text = result.ToString();

                    // Sağ ağ panelə tarixçəni əlavə edirik
                    if (rtbHistory != null)
                    {
                        rtbHistory.AppendText(historyEntry);
                    }
                }
            }
        }

        // Təmizləmə (C)
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNum = 0;
            operation = "";
        }

        // Bir simvol silmə (Del)
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        // Kvadrat kök (Sqrt)
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val))
            {
                double res = Math.Sqrt(val);
                if (rtbHistory != null) rtbHistory.AppendText($"√({val}) = {res}\n");
                txtDisplay.Text = res.ToString();
            }
        }

        // Kvadratı (X^2)
        private void BtnSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val))
            {
                double res = Math.Pow(val, 2);
                if (rtbHistory != null) rtbHistory.AppendText($"{val}^2 = {res}\n");
                txtDisplay.Text = res.ToString();
            }
        }
    }
}