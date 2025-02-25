using businessDisks;
using Disks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IndexProgram
{

    public partial class Form1 : Form
    {
        private List<domDisks> principaldominio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();
        }
        private void dgvDisks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                domDisks cds = (domDisks)dgvDisks.CurrentRow.DataBoundItem;
                pvDiks.Load(cds.URLdisks);
            }
            catch (Exception)
            {
                pvDiks.Load("https://www.precintia.com/wp-content/uploads/2019/08/etiquetas-void.jpg");

            }

        }
        private void cargar()
        {
            bnsDisk bsnDiskEdicion = new bnsDisk();

            try
            {
                principaldominio = bsnDiskEdicion.listar();
                dgvDisks.DataSource = principaldominio;
                pvDiks.Load(principaldominio[0].URLdisks);
                dgvDisks.Columns["URLdisks"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCd add = new frmAddCd();
            add.ShowDialog();
            cargar();
        }

    }

}
