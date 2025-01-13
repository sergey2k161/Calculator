namespace Calculator;

public partial class Form1 : Form
{
    double FirstValue;
    string arithmetic;
    public Form1()
    {
        InitializeComponent();
        n1.Click += NumberButton_Click;
        n2.Click += NumberButton_Click;
        n3.Click += NumberButton_Click;
        n4.Click += NumberButton_Click;
        n5.Click += NumberButton_Click;
        n6.Click += NumberButton_Click;
        n7.Click += NumberButton_Click;
        n8.Click += NumberButton_Click;
        n9.Click += NumberButton_Click;
        n0.Click += NumberButton_Click;

    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void NumberButton_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        if (button != null)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = button.Text;
            }
            else
            {
                TextBox1.Text += button.Text;
            }
        }
    }


    private void n1_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "1";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "1";
        //}
    }

    private void n2_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "2";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "2";
        //}
    }

    private void n3_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "3";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "3";
        //}
    }

    private void n4_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "4";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "4";
        //}
    }

    private void n5_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "5";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "5";
        //}
    }

    private void n6_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "6";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "6";
        //}
    }

    private void n7_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "7";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "7";
        //}
    }

    private void n8_Click(object sender, EventArgs e)
    {
    //    if (TextBox1.Text == "0")
    //    {
    //        TextBox1.Text = "8";
    //    }
    //    else
    //    {
    //        TextBox1.Text = TextBox1.Text + "8";
    //    }
    }

    private void n9_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "9";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "9";
        //}
    }

    private void n0_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "0")
        //{
        //    TextBox1.Text = "0";
        //}
        //else
        //{
        //    TextBox1.Text = TextBox1.Text + "0";
        //}
    }

    private void add_Click(object sender, EventArgs e)
    {
        FirstValue = Convert.ToDouble(TextBox1.Text);
        TextBox1.Text = "0";
        arithmetic = "+";
    }

    private void sub_Click(object sender, EventArgs e)
    {
        FirstValue = Convert.ToDouble(TextBox1.Text);
        TextBox1.Text = "0";
        arithmetic = "-";
    }

    private void mult_Click(object sender, EventArgs e)
    {
        FirstValue = Convert.ToDouble(TextBox1.Text);
        TextBox1.Text = "0";
        arithmetic = "*";
    }

    private void div_Click(object sender, EventArgs e)
    {
        FirstValue = Convert.ToDouble(TextBox1.Text);
        TextBox1.Text = "0";
        arithmetic = "/";
    }

    private void equal_Click(object sender, EventArgs e)
    {
        double SecondValue;
        double outcome;

        SecondValue = Convert.ToDouble(TextBox1.Text);

        if(arithmetic == "+")
        {
            outcome = (FirstValue +  SecondValue);
            TextBox1.Text = Convert.ToString(outcome);
            FirstValue = outcome;
        }
        if (arithmetic == "-")
        {
            outcome = (FirstValue - SecondValue);
            TextBox1.Text = Convert.ToString(outcome);
            FirstValue = outcome;
        }
        if (arithmetic == "*")
        {
            outcome = (FirstValue * SecondValue);
            TextBox1.Text = Convert.ToString(outcome);
            FirstValue = outcome;
        }
        if (arithmetic == "/")
        {
            if (SecondValue == 0)
            {
                MessageBox.Show("не допустимое деление на 0");
            }
            else
            {
                outcome = FirstValue / SecondValue;
                TextBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
        }

    }

    private void clear_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "0";
    }

    private void dot_Click(object sender, EventArgs e)
    {
        if (!TextBox1.Text.Contains(","))
        {
            TextBox1.Text += ",";
        }
    }
}
