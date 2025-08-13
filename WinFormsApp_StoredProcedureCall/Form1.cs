using BusinessLogicLayer;

namespace WinFormsApp_StoredProcedureCall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnewSupplier_Click(object sender, EventArgs e)
        {

            SupplierBAL bal = new SupplierBAL();

            try
            {

            
            bal.CompanyName = txtCompanyName.Text.Trim();
            bal.ContactTitle = txtcontactTitle.Text.Trim();
            bal.ContactName = txtContactName.Text.Trim();
            bal.Address = txtaddress.Text.Trim();
            bal.City = txtCity.Text.Trim();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
