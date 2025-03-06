namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()

        {
            InitializeComponent();
        }



        private void CreateAccountbtn(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            bankAccounts.Add(bankAccount);
            OwnerTxt.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bankAccounts;
        }
        public void refreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bankAccounts;
        }



        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && Amounttxt.Value > 0)
            {
                BankAccount selectedBankAccount = dataGridView1.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(Amounttxt.Value);
                Amounttxt.Value = 0;
                MessageBox.Show(message);
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && Amounttxt.Value > 0)
            {
                BankAccount selectedBankAccount = dataGridView1.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.WithDrawl(Amounttxt.Value);
                refreshGrid();
                Amounttxt.Value = 0;
                MessageBox.Show(message);

            } 
            
            
        }
    }
}
