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
    public partial class frmAddCd : Form
    {
        public frmAddCd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            domDisks disks = new domDisks();
            bnsDisk negocio = new bnsDisk();
            try
            {

                disks.Title = txtitle.Text;
                disks.release = DateTime.Parse(txrelease.Text);
                disks.mount = int.Parse(txmount.Text);
                disks.URLdisks = txurl.Text;
                disks.Descripcion = (diskEdicion)comboStyle.SelectedItem;
                negocio.add(disks);
                MessageBox.Show("It was succesfully");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAddCd_Load(object sender, EventArgs e)
        {
            bsnDiskEdicion styles = new bsnDiskEdicion();
            try
            {
                comboStyle.DataSource = styles.Listaedicion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
