using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteSQL
{
    public partial class Form1 : Form
    {
        static string connectString = System.Configuration.ConfigurationManager
                                    .ConnectionStrings["ExecuteSQL.Properties.Settings.TestConnectionString"]
                                    .ToString();
        LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

        public Form1()
        {
            InitializeComponent();
            ShowWholeTable();
        }

        // Checking NameID form and parsing it into int type.
        private void ParseNameID(TestTable person, string txtBoxText)
        {
            var flag = int.TryParse(txtBoxText, out int ID);
            if (flag == true)
            {
                person.NameID = ID;
            }
            else
            {
                ShowOKPopUp("Input integer ID", "Caution");
            }
        }

        // PopUp method to tell users something goes wrong and confirm it.
        private void ShowOKPopUp(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                return;
            }
        }

        // This method shows information which match given conditions.
        private void ShowPartTable(IQueryable people)
        {
            StringBuilder info = new StringBuilder();
            info.Append("NameID,    Name,   Email Adress\n");
            foreach (TestTable person in people)
            {
                var id = person.NameID;
                var name = person.Name;
                var eMailAddress = person.EmailAddress;
                info.Append($"{id}   {name}  {eMailAddress}\n");
            }
            rtxtTableView.Text = info.ToString();
        }

        // Yes/No popup method to tell users some change is going to be done.
        // As I cannot do well, I make this method return value.
        /* This doesn't work.
        private bool ShowYesNoPopUp(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/

        // This method shows the whole table.
        private void ShowWholeTable()
        {
            // Use TestTable type well. Here, IQueryable object "all" contains each TestTable object.
            var all = db.TestTables;
            StringBuilder info = new StringBuilder();
            info.Append("NameID,    Name,   Email Adress\n");
            // Here
            foreach (TestTable person in all)
            {
                var id = person.NameID;
                var name = person.Name;
                var eMailAddress = person.EmailAddress;
                info.Append($"{id}   {name}  {eMailAddress}\n");
            }
            rtxtTableView.Text = info.ToString();
        }

        private void rtxtTableView_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReviewTable_Click(object sender, EventArgs e)
        {
            ShowWholeTable();
        }

        private void btnInsertApply_Click(object sender, EventArgs e)
        {
            TestTable newPerson = new TestTable();
            ParseNameID(newPerson, txtInsertNameID.Text);
            newPerson.Name = txtInsertName.Text;
            newPerson.EmailAddress = txtInsertEmail.Text;
            db.TestTables.InsertOnSubmit(newPerson);
            try
            {
                db.SubmitChanges();
            }
            catch (DuplicateKeyException)
            {
                ShowOKPopUp("The NameID already exists. Change it.", "Caution");
            }
            ShowWholeTable();
        }

        private void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            TestTable candidatePerson = new TestTable();

            // Inspecting input NameIDs
            if (txtUpdateNameID.Text == "")
            {
            }
            if (txtUpdateNameID.Text != "")
            {
                ParseNameID(candidatePerson, txtUpdateNameID.Text);
            }

            candidatePerson.Name = txtUpdateName.Text;
            candidatePerson.EmailAddress = txtUpdateEmail.Text;
            var updatePeople = db.TestTables.Where(p => p.NameID == candidatePerson.NameID
                                || p.Name == candidatePerson.Name
                                || p.EmailAddress == candidatePerson.EmailAddress);
            /* Partial match doesn't work. Why?
            var updatePeople = db.TestTables.Where(p => p.NameID == candidatePerson.NameID
                                || p.Name.Contains(candidatePerson.Name)
                                || p.EmailAddress.Contains(candidatePerson.EmailAddress));
            */
            ShowPartTable(updatePeople);
        }

        private void btnUpdateApply_Click(object sender, EventArgs e)
        {
            // int -> string is easier than string -> int
            TestTable updatePerson = db.TestTables.FirstOrDefault(p => p.NameID.ToString() == txtUpdateNameID.Text);
            if (updatePerson == null)
            {
                ShowOKPopUp("The NameID does not exist.", "Caution");
                return;
            }

            ParseNameID(updatePerson, txtUpdateNameID.Text);
            updatePerson.Name = txtUpdateName.Text;
            updatePerson.EmailAddress = txtUpdateEmail.Text;

            try
            {
                db.SubmitChanges();
            }
            catch (DuplicateKeyException)
            {
                ShowOKPopUp("The new NameID already exists. Change it.", "Caution");
                return;
            }
            catch (InvalidOperationException)
            {
                ShowOKPopUp("The new NameID already exists. Change it.", "Caution");
                return;
            }
            ShowWholeTable();

        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {
            TestTable candidatePerson = new TestTable();

            // Inspecting input NameIDs
            if (txtDeleteNameID.Text == "")
            {
            }
            if (txtDeleteNameID.Text != "")
            {
                ParseNameID(candidatePerson, txtDeleteNameID.Text);
            }

            candidatePerson.Name = txtDeleteName.Text;
            candidatePerson.EmailAddress = txtDeleteEmail.Text;
            var deletePeople = db.TestTables.Where(p => p.NameID == candidatePerson.NameID
                                || p.Name == candidatePerson.Name
                                || p.EmailAddress == candidatePerson.EmailAddress);
            ShowPartTable(deletePeople);
        }

        private void btnDeleteApply_Click(object sender, EventArgs e)
        {
            TestTable deletePerson = db.TestTables.FirstOrDefault(p => p.NameID.ToString() == txtDeleteNameID.Text
                                    && p.Name == txtDeleteName.Text && p.EmailAddress == txtDeleteEmail.Text);
            if (deletePerson == null)
            {
                ShowOKPopUp("You must fill all forms correctly to delete.", "Caution");
                return;
            }

            db.TestTables.DeleteOnSubmit(deletePerson);
            db.SubmitChanges();

            ShowWholeTable();
        }

        private void txtInsertNameID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInsertName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInsertEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteNameID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
