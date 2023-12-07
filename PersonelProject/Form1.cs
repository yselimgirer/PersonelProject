using PersonelProject.DataAccessLayer;
using PersonelProject.Entities;
using System;
using System.Windows.Forms;

namespace PersonelProject
{
    public partial class Form1 : Form
    {
        ViewPersonelUnitDal vpudal = new ViewPersonelUnitDal();
        Personeller p = new Personeller();
        PersonelDal pdal = new PersonelDal();
        ModelPersonelEntity db = new ModelPersonelEntity();
        

        public Form1()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            //dataGridView1.DataSource = vpudal.GetList();
            dataGridView1.DataSource = pdal.GetPersonel(db, x => x.Name.Contains(txtSearch.Text));
            cmbUnit.DataSource = vpudal.GetList();  
        }
        void ClearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_binding(Personeller person) 
        {
            ClearDataBinding();
            this.p = person;
            txtPersonelID.DataBindings.Add("text", p, "PersonelD");
            cmbUnit.DataBindings.Add("SelectedValue", p, "UnitID",true);
            txtName.DataBindings.Add("text", p, "Name");
            txtLastName.DataBindings.Add("text", p, "LastName");
            msdPhone.DataBindings.Add("text", p, "Phone");
            txtEmail.DataBindings.Add("text", p, "Email");
            dtpDate.DataBindings.Add("text", p, "Date", true);
            txtAddress.DataBindings.Add("text", p, "Address");
            chckIA.DataBindings.Add("CheckState", p, "IsActive",true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
            Data_binding(new Personeller());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = vpudal.GetList(x=>x.Name.Contains(txtSearch.Text));
            dataGridView1.DataSource = pdal.GetPersonel(db,x => x.Name.Contains(txtSearch.Text));
        }
            
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            Data_binding(pdal.GetByFilter(x=>x.PersonelD==personelid));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Data_binding(new Personeller());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pdal.AddorUpdate(p);
            pdal.Save();
            GetData();
            Data_binding(new Personeller());
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            pdal.Delete(p => p.PersonelD == personelid);
            pdal.Save();
            GetData();
            Data_binding(new Personeller());
        }
    }
}   
