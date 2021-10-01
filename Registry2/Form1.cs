using Registry2.Services;
using Registry2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbGender.SelectedIndex = 0;
           UserService.PopulateDGV(dgvDash);
            UpdateReportComboBoxes();
            cmbAge0.SelectedIndex = 0;
            cmbAge1.SelectedIndex = 0;
            cmbYear0.SelectedIndex = 0;
            cmbYear1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Firstname = tbFname.Text;
            user.Lastname = tbLname.Text;
            user.Email = tbEmail.Text;
            user.Gender = cmbGender.SelectedItem.ToString();
            user.DateOfBirth = dtp1.Value;
            UserService service = new UserService(user);
            service.AddUser(user);
            UserService.PopulateDGV(dgvDash);
            UpdateReportComboBoxes();

        }

        private void dgvDash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            UserService.PopulateDGV(dgvDash);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Firstname = tbSearch.Text
            };
            
             UserService service = new UserService(user);
            service.FindUser(user, dgvSearchResults);
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        public bool ValidName(string name, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (name.Length == 0)
            {
                errorMessage = "name is required.";
                return false;
            }

            for(int i=0;i<name.Length;i++)
            {
                if (Char.IsLetter(name[i]))
                {
                        errorMessage = "";
                        return true;
                }
            }

            errorMessage = "Name must not contain any digit";
            return false;
        }

        private void dgvSearchResults_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedRecord;
            //if (e.Button == MouseButtons.Right)
            //{
            try
            {
                dgvSearchResults.CurrentCell = dgvSearchResults.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvSearchResults.Rows[e.RowIndex].Selected = true;
                dgvSearchResults.Focus();

                selectedRecord = dgvSearchResults.Rows[e.RowIndex].Cells[0].Value.ToString();

                User user = new User();
                UserService service = new UserService(user);
                user = service.FindByID(Convert.ToInt32(selectedRecord));

                
                user.Id = Convert.ToInt32(selectedRecord);
                tbID.Text = user.Id.ToString();
                tbEditEmail.Text = user.Email;
                tbEditFname.Text = user.Firstname;
                tbEditLname.Text = user.Lastname;
                cmbEditGender.Text = user.Gender;
                dtpEditDOB.Value = Convert.ToDateTime(user.DateOfBirth).Date;
                var temp = DateTime.Today.Year - user.DateOfBirth.Year;
                tbAge.Text = temp.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dgvSearchResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            //}
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(tbEmail.Text, out errorMsg))
            {
                e.Cancel = true;
                tbEmail.Select(0, tbEmail.Text.Length);

                this.errorProvider1.SetError(tbEmail, errorMsg);
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEmail, "");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(tbID.Text);
            user.Firstname = tbEditFname.Text;
            user.Lastname = tbEditLname.Text;
            user.Email = tbEditEmail.Text;
            user.Gender = cmbEditGender.Text.ToString();
            user.DateOfBirth = dtpEditDOB.Value;
            UserService service = new UserService(user);
            service.UpdateUser(user);
        }

        private void tbFname_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbFname, "");
        }

        private void tbLname_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbLname, "");

        }

        private void tbLname_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(tbLname.Text, out errorMsg))
            {
                e.Cancel = true;
                tbLname.Select(0, tbLname.Text.Length);

                this.errorProvider1.SetError(tbLname, errorMsg);
            }
        }

        private void tbEditFname_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEditFname, "");

        }

        private void tbEditFname_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(tbEditFname.Text, out errorMsg))
            {
                e.Cancel = true;
                tbEditFname.Select(0, tbEditFname.Text.Length);

                this.errorProvider1.SetError(tbEditFname, errorMsg);
            }
        }

        private void tbEditLname_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(tbEditLname, "");
        }

        private void tbEditLname_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(tbEditLname.Text, out errorMsg))
            {
                e.Cancel = true;
                tbEditLname.Select(0, tbEditLname.Text.Length);

                this.errorProvider1.SetError(tbEditLname, errorMsg);
            }
        }

        private void tbFname_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(tbFname.Text, out errorMsg))
            {
                e.Cancel = true;
                tbFname.Select(0, tbFname.Text.Length);

                this.errorProvider1.SetError(tbFname, errorMsg);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Id = Convert.ToInt32(tbID.Text)
            };

            UserService service = new UserService(user);

            
            service.DeleteUser(user);
            UserService.PopulateDGV(dgvDash);
            UpdateReportComboBoxes();

        }

        private void UpdateReportComboBoxes()
        {
            UserService.AgesOfEntries(cmbYear0, cmbYear1, cmbAge0, cmbAge1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateReportComboBoxes();
        }

        private void cmbYear0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void rbtnAge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAge.Checked == true)
            {
                rbtnYear.Checked = false;
                cmbYear0.Enabled = false;
                cmbYear1.Enabled = false;

                cmbAge0.Enabled = true;
                cmbAge1.Enabled = true;

            }
            else
            {
                rbtnYear.Checked = true;

                cmbAge0.Enabled = false;
                cmbAge1.Enabled = false;


                cmbYear0.Enabled = true;
                cmbYear1.Enabled = true;

            }
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYear.Checked == true)
            { 
                cmbYear0.Enabled = true;
                cmbYear1.Enabled = true;

                rbtnAge.Checked = false;
                cmbAge0.Enabled = false;
                cmbAge1.Enabled = false;

            }
            else
            {
                cmbAge0.Enabled = true;
                cmbAge1.Enabled = true;

                rbtnYear.Checked = false;
                cmbYear0.Enabled = false;
                cmbYear1.Enabled = false;


            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            User user = new User
            {
                Firstname = tbSearch.Text
            };

            UserService service = new UserService(user);
            service.FindUser(user, dgvSearchResults);
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();


                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Gender", typeof(string));
                dt.Columns.Add("First Name", typeof(string));
                dt.Columns.Add("Last Name", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Date of Birth", typeof(string));

            foreach (DataGridViewRow item in dgvSearchResults.Rows)
            {
                dt.Rows.Add(item.Cells[0].Value, item.Cells[3].Value, item.Cells[1].Value, item.Cells[2].Value,
                    item.Cells[4].Value, item.Cells[5].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("application.xml");
            userSearchList c1 = new userSearchList();
            c1.SetDataSource(ds);

            Reports form = new Reports();
            form.cryRep.ReportSource = c1;
            form.cryRep.Refresh();

            form.Show();
        }

        private void btnUserRep_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();

            //DataTable dt = new DataTable();


            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("Gender", typeof(string));
            //dt.Columns.Add("First Name", typeof(string));
            //dt.Columns.Add("Last Name", typeof(string));
            //dt.Columns.Add("Email", typeof(string));
            
            //dt.
        }

        private void btnGenByYearOrAge_Click(object sender, EventArgs e)
        {
            if (rbtnAge.Checked == true)
            {
                int age0 = Convert.ToInt32(cmbAge0.SelectedItem);
                int age1 = Convert.ToInt32(cmbAge1.SelectedItem);
                string temp = "age";
                UserService.QueryByYearOrAge(dgvSearchResults, temp, age0, age1);
            }
            else if(rbtnYear.Checked == true)
            {
                int year0 = (int)(cmbYear0.SelectedItem);
                int year1 = (int)(cmbYear1.SelectedItem);

                string temp = "dob";
                UserService.QueryByYearOrAge(dgvSearchResults, temp, year0, year1);

            }
        }
    }
}