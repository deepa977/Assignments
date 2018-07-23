using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstExample
{
    public partial class Form1 : Form
    {
        TrainingDBEntities db = new TrainingDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //form data
            string name = txtname.Text;
            //combobox
            string gender = cbgender.SelectedItem.ToString();
            //radiobutton
            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            //checkedlistbox
            string shopping = "";
            foreach (var d in clbshop.CheckedItems)
            {
                shopping += d + ",";
            }
            //checkbox
            string cod = "";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "No";

            string pass = txtpassword.Text;
            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + shopping + "\n" + cod + "\n" + pass);
            //insert data to DB through Entity Framework
            RegisterShopping rs = new RegisterShopping();
            rs.Name = name;
            rs.Gender = gender;
            rs.Membership = membership;
            rs.ShoppingPreference = shopping;
            rs.COD = cod;
            rs.Password = pass;
            db.RegisterShoppings.Add(rs);
            var res=db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data inserted");
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
         }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();
            foreach(var t in db.RegisterShoppings)
            {
                lbselect.Items.Add(t.Id);
                lbselect.Items.Add(t.Name);
                lbselect.Items.Add(t.Gender);
                lbselect.Items.Add(t.Membership);
                lbselect.Items.Add(t.ShoppingPreference);
                lbselect.Items.Add(t.COD);
                lbselect.Items.Add(t.Password);
                lbselect.Items.Add("**********");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)cbID.SelectedValue;

            var del = (from t in db.RegisterShoppings
                       where t.Id == id
                       select t).SingleOrDefault();
            var del1 = db.RegisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            db.RegisterShoppings.Remove(del);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Deleted");
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cod = "";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "No";

            string shopping = "";
            foreach (var d in clbshop.CheckedItems)
            {
                shopping += d + ",";
            }

            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;

            string pass = txtpassword.Text;
            int id = (int)cbID.SelectedValue;
            var olddata = db.RegisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            olddata.Membership = membership;
            olddata.ShoppingPreference = shopping;
            olddata.COD = cod;
            olddata.Password = pass;
            olddata.Id = id;
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Updated");

























        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            int id = (int)cbID.SelectedValue;
            lbselect.Items.Clear();
            var res = db.sp_SelectRegisterShopping(id);
            foreach (var r in res)
            {
                lbselect.Items.Add(r.Id);
                lbselect.Items.Add(r.Name);
                lbselect.Items.Add(r.Gender);
                lbselect.Items.Add(r.ShoppingPreference);
                lbselect.Items.Add(r.Membership);
                lbselect.Items.Add(r.COD);
                lbselect.Items.Add(r.Password);
            }
        }
    }
}
