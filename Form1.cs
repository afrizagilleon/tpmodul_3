namespace tpmodul3_103022300154
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onSubmit(object sender, EventArgs e)
        {
            if (TextInput.Text != "")
            { // Jika input tidak kosong
                ouput.Text = "Halo, " + TextInput.Text + " !";
            }
            else
            { // Jika input kosong, tanyakan kembali namanya
                ouput.Text = "Kamu Siapa?";
            }

        }
    }
}