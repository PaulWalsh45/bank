using System;
using System.Windows.Forms;
using BIZ;
using System.Xml;
using System.Xml.Serialization;

namespace DBSBank
{
    public partial class XmlSerialise : Form
    {

        CurrentAccount acc = new CurrentAccount();
        public XmlSerialise(int id)
        {

            ///assigning all text to class xmlSerialAcc's varriable
           // CurrentAccount acc = new CurrentAccount();
            InitializeComponent();
            txtAccId.Text = id.ToString();//
            XmlSerialAcc xmlSe = new XmlSerialAcc(); //assignning to xmlseraiacc class
            acc = xmlSe.RetrieveAccount(id);

            txtFName.Text = acc.FirstName;
            txtSurname.Text = acc.Surname;
            txtEmail.Text = acc.Email;
            txtPhone.Text = acc.Phone;
            txtAddress1.Text = acc.AddressLine1;
            txtAddress2.Text = acc.AddressLine2;
            txtCity.Text = acc.City;
            cbxCounty.Text = acc.Country;
            cbxAccountType.Text = acc.AccountType;
            txtAccountNumber.Text = acc.AccountNumber.ToString();
            txtSortCode.Text = "101010";
            txtOpeningBalance.Text = acc.InitialBalance.ToString();
            txtOverdraftLimit.Text = acc.OverdraftLimit.ToString();

        }

        private void txtAccId_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txtAccId.Text);

        }
        private void btnXmlSerialise_Click(object sender, EventArgs e)
        {
            //method to save account number as xml type
           
            XmlSerializer serialiser;
            XmlWriter xmlWriter;
            string filePath = string.Empty;

           

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                sfd.InitialDirectory = "C:\\";
                sfd.Filter = "xml files (*.xml)|*.xml";
                filePath = sfd.FileName;
                serialiser = new XmlSerializer(typeof(CurrentAccount));
                xmlWriter = XmlWriter.Create(filePath);
                serialiser.Serialize(xmlWriter, acc);
                MessageBox.Show("File has been saved as Xml type");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xml not Saved");
            }
        }       
    }
}
