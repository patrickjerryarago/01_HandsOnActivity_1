using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.LastName = tbLastName.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddle.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.Age = Int32.Parse(tbAge.Text);
            StudentInfoClass.ContactNo = long.Parse(tbContact.Text);
            StudentInfoClass.StudentNo = long.Parse(tbStudentNo.Text);
            Confirm con = new Confirm();
            con.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }
    }
}
