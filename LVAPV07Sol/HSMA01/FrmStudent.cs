using HSMA01.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSMA01
{
    public partial class FrmStudent : MetroFramework.Forms.MetroForm
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            using(DataContext dataContext=new DataContext())
            {
                studentBindingSource.DataSource = dataContext.Students.ToList();
            }
            pnlDatos.Enabled = false;
            Student student = studentBindingSource.Current as Student;
            if ( student !=null && student, Photo !=null ) 
                pctPhoto.Image = Image.FromFile(student.Photo);
            else
                pctPhoto.Image = null;
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
