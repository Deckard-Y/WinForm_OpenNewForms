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
            var Form2 = new Form2(textBox1.Text);    // Form2�N���X�̃C���X�^���X�𐶐����ɁAtextBox1�̃e�L�X�g��n��
            Form2.Show();                            // Form2��\������
        }
    }
}