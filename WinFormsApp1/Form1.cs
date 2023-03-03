namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(string cognome, string nome,DateTime data,List comune )
        {
            InitializeComponent();
            tbx_Cognome.Text = cognome;
            tbx_Nome.Text = nome;
            dateTimePicker1 = data;
            comboBox1 = comune;


        }
        private void (object sender, EventArgs e)
        {

        }


    }
}