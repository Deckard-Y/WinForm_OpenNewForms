namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2(textBox1.Text);    // Form2クラスのインスタンスを生成時に、textBox1のテキストを渡す
            Form2.Show();                            // Form2を表示する
        }
    }
}