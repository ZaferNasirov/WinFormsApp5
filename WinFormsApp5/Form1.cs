namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 class1 = new Class1();
        Class2 class2 = new Class2();

        private void button1_Click(object sender, EventArgs e)
        {

            class1.Name = textBox1.Text;
            listBox1.Items.Add(class1.Name);
            //class1.Mesaj();
            class1.Mesajj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            class1.Description = textBox1.Text;
            listBox1.Items.Add(class1.Description);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            class1.Type = textBox1.Text;
            listBox1.Items.Add(class1.Type);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            class2.Name = textBox2.Text;
            listBox2.Items.Add(class2.Name);
            class2.Mesaj();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            class2.Description = textBox2.Text;
            listBox2.Items.Add(class2.Description);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            class2.Type = textBox2.Text;
            listBox2.Items.Add(class2.Type);
        }
    }
}