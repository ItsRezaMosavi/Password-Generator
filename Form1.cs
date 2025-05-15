namespace Password_Generator
{
    public partial class Form1 : Form
    {
        int length = 0;

        string[] password;

        int i;

        bool A1_Check, A2_Check, A3_Check, A4_Check;

        //1
        string small_alphabat = "abcdefghijklmnopqrstuvwxyz";
        //2
        string captal_alphabat = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //3
        string Special_Char = @"~!@#$%^&*()_+/|\{}[]';`";


        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            length = 8;
            btn8.BackColor = Color.Blue;
            btn9.BackColor = SystemColors.Control;
            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            length = 9;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = Color.Blue;
            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            length = 10;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;
            btn10.BackColor = Color.Blue;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            length = 11;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;
            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = Color.Blue;
            btn12.BackColor = SystemColors.Control;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            length = 12;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;
            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = Color.Blue;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            A1_Check = false;
            A2_Check = false;
            A3_Check = false;
            A4_Check = false;
            txtPassword.Text = "";
            if (length != 0)
            {
                password = new string[length];

                for (i = 0; i < length; i++)
                {
                    btnChar_Click(null, null);
                }

                if (A1_Check && A2_Check && A3_Check && A4_Check)
                {
                    // txtPassword.Text = Convert.ToString(password);
                   // MessageBox.Show(Convert.ToString(password));
                   for(int j =0;j< length; j++)
                    {
                        txtPassword.Text += password[j];
                    }

                }
                else
                {
                    btnGenerate_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("select the length of password");
            }

        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            int A = rnd.Next(1, 5);
            if (A == 1)
            {
                int A1 = rnd.Next(0, small_alphabat.Length);
                password[i] = small_alphabat.Substring(A1, 1);
                A1_Check = true;
            }
            else if (A == 2)
            {
                int A2 = rnd.Next(0, captal_alphabat.Length);
                password[i] = captal_alphabat.Substring(A2, 1);
                A2_Check = true;
            }
            else if (A == 3)
            {
                int A3 = rnd.Next(0, Special_Char.Length);
                password[i] = Special_Char.Substring(A3, 1);
                A3_Check = true;
            }
            else if (A == 4)
            {
                int A4 = rnd.Next(0, 10);
                password[i] = Convert.ToString(A4);
                A4_Check = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
