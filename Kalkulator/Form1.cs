using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        //input and output data
        string first = "";
        string second = "";
        double result = 0.0;
        string userInput = "";
        string history = "";
        double rad;

        //logic data
        char operation;
        bool checkOperation = false;
        string sign = "";
        int number = 0;
        bool commaCheck = false;
        string commaString = "";

        public Form1()
        {
            InitializeComponent();
        }
       
        private void onebutton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "1";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "2";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "3";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "4";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "5";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "6";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "7";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "8";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "9";
            Display.Text += userInput;
            equalLabel.Focus();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "0";
            char firstSign = userInput[0];
            if (firstSign == '0')
            {
                userInput += ",";
                Display.Text += userInput;
            }
            else
            {
                Display.Text += userInput;
            }
            equalLabel.Focus();
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            if (commaCheck == false)
            {
                if (userInput == "")
                {
                    userInput = "0";
                }
                Display.Text = "";
                userInput += ",";
                Display.Text += userInput;
                equalLabel.Focus();
                commaCheck = true;
                commaString += ',';
            }
            else
            {
                Display.Text = userInput;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        { //error while pressing = after no operation
            if (checkOperation == false)
            {
                Display.Text = "";
                Display.Text += userInput;
            }
            //changing operation defense
            else if (checkOperation && userInput == "")
            {
                userInput = first;
                Display.Text = first;
            }
            else
            {
                second = userInput;
                history += second;
                historyDisplay.Text += history;
                historyDisplay.Text += " =";
                double firstNum,
                    secondNum;
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);
                //addition
                if (operation == '+')
                {
                    result = firstNum + secondNum;
                    Display.Text = result.ToString();
                    userInput = result.ToString();
                }
                //substraction
                else if (operation == '-')
                {
                    result = firstNum - secondNum;
                    Display.Text = result.ToString();
                    userInput = result.ToString();
                }
                //division
                else if (operation == '/')
                {
                    if (secondNum == 0)
                    {
                        Display.Text = "ERROR";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        Display.Text = result.ToString();
                        userInput = result.ToString();
                    }
                }
                //multiplication
                else if (operation == '*')
                {
                    result = firstNum * secondNum;
                    Display.Text = result.ToString();
                    userInput = result.ToString();
                }
                commaCheck = false;
                commaString = "";
            }
            sign = "";
            checkOperation = false;
            number = 0;
            history = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            history += userInput;
            history += " - ";
            historyDisplay.Text = history;
            history = "";
            //changing operation defense
            if (checkOperation && userInput == "")
            {
                if (operation == '/' || operation == '*')
                {
                    userInput = "1";
                }
                else
                {
                    userInput = "0";
                }
                second = userInput;
                double firstNum;
                firstNum = Convert.ToDouble(first);
                result = firstNum;
                Display.Text = result.ToString();
            } //no first number error
            if (!checkOperation && userInput == "")
            {
                operation = '-';
                first = "0";
                userInput = "";
                checkOperation = true;
            }
            //operations after last operation
            else if (checkOperation)
            {
                number++;
                char lastSign = sign[number - 1];
                if (lastSign == '-')
                {
                    second = userInput;
                    double firstNum;
                    firstNum = Convert.ToDouble(first);
                    result = firstNum;
                }
                if (lastSign == '*')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum * secondNum;
                }
                else if (lastSign == '/')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum / secondNum;
                }
                else if (lastSign == '+')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum + secondNum;
                }
                first = result.ToString();
                userInput = "";
                Display.Text = first;
                historyDisplay.Text = first + historyDisplay.Text[^3..];
                operation = '-';
            }
            else
            {
                operation = '-';
                first = userInput;
                userInput = "";
                checkOperation = true;
            }
            sign += operation;
            commaCheck = false;
            commaString = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            history += userInput;
            history += " + ";
            historyDisplay.Text = history;
            history = "";
            //changing operation defense
            if (checkOperation && userInput == "")
            {
                if (operation == '/' || operation == '*')
                {
                    userInput = "1";
                }
                else
                {
                    userInput = "0";
                }
                second = userInput;
                double firstNum;
                firstNum = Convert.ToDouble(first);
                result = firstNum;
                Display.Text = result.ToString();
            } //no first number error
            if (!checkOperation && userInput == "")
            {
                operation = '+';
                first = "0";
                userInput = "";
                checkOperation = true;
            }
            //operations after last operation
            else if (checkOperation)
            {
                number++;
                char lastSign = sign[number - 1];
                if (lastSign == '-')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum - secondNum;
                }
                if (lastSign == '*')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum * secondNum;
                }
                else if (lastSign == '/')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum / secondNum;
                }
                else if (lastSign == '+')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum + secondNum;
                }
                first = result.ToString();
                userInput = "";
                Display.Text = first;
                historyDisplay.Text = first + historyDisplay.Text[^3..];
                operation = '+';
            }
            else
            {
                operation = '+';
                first = userInput;
                userInput = "";
                checkOperation = true;
            }
            sign += operation;
            commaCheck = false;
            commaString = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            history += userInput;
            history += " * ";
            historyDisplay.Text = history;
            history = "";
            //changing operation defense
            if (checkOperation && userInput == "")
            {
                if (operation == '/' || operation == '*')
                {
                    userInput = "1";
                }
                else
                {
                    userInput = "0";
                }
                second = userInput;
                double firstNum;
                firstNum = Convert.ToDouble(first);
                result = firstNum;
                Display.Text = result.ToString();
            } //no first number error
            if (!checkOperation && userInput == "")
            {
                operation = '*';
                first = "0";
                userInput = "";
                checkOperation = true;
            }
            //operations after last operation
            else if (checkOperation)
            {
                number++;
                char lastSign = sign[number - 1];
                if (lastSign == '-')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum - secondNum;
                }
                if (lastSign == '*')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum * secondNum;
                }
                else if (lastSign == '/')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum / secondNum;
                }
                else if (lastSign == '+')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum + secondNum;
                }
                first = result.ToString();
                userInput = "";
                Display.Text = first;
                historyDisplay.Text = first + historyDisplay.Text[^3..];
                operation = '*';
            }
            else
            {
                operation = '*';
                first = userInput;
                userInput = "";
                checkOperation = true;
            }
            sign += operation;
            commaCheck = false;
            commaString = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            history += userInput;
            history += " : ";
            historyDisplay.Text = history;
            history = "";
            //changing operation defense
            if (checkOperation && userInput == "")
            {
                if (operation == '/' || operation == '*')
                {
                    userInput = "1";
                }
                else
                {
                    userInput = "0";
                }
                second = userInput;
                double firstNum;
                firstNum = Convert.ToDouble(first);
                result = firstNum;
                Display.Text = result.ToString();
            } //no first number error
            if (!checkOperation && userInput == "")
            {
                operation = '/';
                first = "0";
                userInput = "";
                checkOperation = true;
            }
            //operations after last operation
            else if (checkOperation)
            {
                number++;
                char lastSign = sign[number - 1];
                if (lastSign == '-')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum - secondNum;
                }
                if (lastSign == '*')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum * secondNum;
                }
                else if (lastSign == '/')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum / secondNum;
                }
                else if (lastSign == '+')
                {
                    second = userInput;
                    double firstNum,
                        secondNum;
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum + secondNum;
                }
                first = result.ToString();
                userInput = "";
                Display.Text = first;
                historyDisplay.Text = first + historyDisplay.Text[^3..];
                operation = '/';
            }
            else
            {
                operation = '/';
                first = userInput;
                userInput = "";
                checkOperation = true;
            }
            sign += operation;
            commaCheck = false;
            commaString = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            Display.Text = "0";
            history = "";
            historyDisplay.Text = "";
            sign = "";
            number = 0;
            checkOperation = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            commaString = userInput;
            char commaSign = commaString[commaString.Length - 1];
            if (commaCheck == true && commaSign == ',')
            {
                commaCheck = false;
                Display.Text = userInput.Remove(userInput.Length - 1);
                userInput = Display.Text;
            }
            else if (userInput.Length != 1)
            {
                Display.Text = userInput.Remove(userInput.Length - 1);
                userInput = Display.Text;
            }
            else if (userInput.Length == 1)
            {
                userInput = "";
                Display.Text = "0";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                zeroButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                oneButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                twoButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                threeButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                fourButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                fiveButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                sixButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                sevenButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                eightButton.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                nineButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                plusButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                multiplyButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                divideButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                clearButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                deleteButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                commaButton.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                commaButton.PerformClick();
            }
            else if (e.KeyChar == '-')
            {
                minusButton.PerformClick();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Display.Font = new Font("Segoe UI Light", panel1.Width / 8);
            Display.Font = new Font("Segoe UI Light", panel1.Height / 4);
        }

        private async void tanButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {   //userInput="0" 
                Display.Text = "Podaj liczbê";
            }
            while (userInput == "")
            {
                await Task.Delay(3000);
            }
            {
                rad = Convert.ToDouble(userInput);
                result = Math.Tan(rad * Math.PI / 180);
                Display.Text = result.ToString();
                sinButton.Visible = false;
                cosButton.Visible = false;
                tanButton.Visible = false;
                exitButton.Visible = false; 
                userInput = result.ToString();
                string trigonom = "tan";
                double inp = rad * Math.PI/180;
                double deg = result;
                Form2 obj = new Form2(trigonom,inp,deg);
                obj.Show();
            }
        }

        private async void cosButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {   //userInput="0" 
                Display.Text = "Podaj liczbê";
            }
            while (userInput == "")
            {
                await Task.Delay(3000);
            }
            rad = Convert.ToDouble(userInput);
            result = Math.Cos(rad * Math.PI / 180);
            Display.Text = result.ToString();
            sinButton.Visible = false;
            cosButton.Visible = false;
            tanButton.Visible = false;
            exitButton.Visible = false;
            userInput = result.ToString();
            string trigonom = "cos";
            double inp = rad * Math.PI/180;
            double deg = result;
            Form2 obj = new Form2(trigonom, inp, deg);
            obj.Show();
        }

        private async void sinButton_Click(object sender, EventArgs e)
        {
           
            if (userInput == "")
            {   //userInput="0" 
                Display.Text = "Podaj liczbê";
            }
            while (userInput == "")
            {
                await Task.Delay(3000);
            }
            rad = Convert.ToDouble(userInput);
            result = Math.Sin(rad *Math.PI/ 180);
            Display.Text = result.ToString();
            sinButton.Visible = false;
            cosButton.Visible = false;
            tanButton.Visible = false;
            exitButton.Visible = false;
            userInput = result.ToString();
            string trigonom = "sin";
            double inp = rad * Math.PI/180;
            double deg = result;
            Form2 obj = new Form2(trigonom, inp, deg);
            obj.Show();
        }

        private void functionButton_Click(object sender, EventArgs e)
        {
            sinButton.Visible = true;
            cosButton.Visible = true;
            tanButton.Visible = true;
            exitButton.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            sinButton.Visible = false;
            cosButton.Visible = false;
            tanButton.Visible = false;
            exitButton.Visible = false;
        }
        
    }
}
