using System;
using System.IO;
using System.Windows.Forms;

namespace Lab_09B
{
    public partial class signUp : Form
    {


        public signUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = usernameBox.Text;
            string name = nameBox.Text;
            string pass = fpassbox.Text;
            string path = $@"C:\Users\mhsia\Desktop\New folder\lab9a\lab9a\{userName}.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("Username not available!");
            }
            else if (fpassbox.Text != spassbox.Text)
            {
                MessageBox.Show("Password didn't Match!");
            }
            else
            {
                MessageBox.Show("Account Created!");
                FileStream nFile = new FileStream($"C:\\Users\\mhsia\\Desktop\\New folder\\lab9a\\lab9a\\{userName}.txt", FileMode.OpenOrCreate);
                string info = $"pass:{pass}\n{name}";
                StreamWriter sw = new StreamWriter(nFile);
                sw.WriteLine(info);
                sw.Close();
                nFile.Close();
                Form1 logIn = new Form1();
                logIn.Show();
                this.Hide();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.Show();
            this.Hide();
        }
    }
}
