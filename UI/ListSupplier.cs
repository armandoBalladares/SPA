using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.UI
{
    public partial class ListSupplier : Form
    {
        public SPA.Application.ManageProvider? manageProvider;
        private bool isSelectedRow = false;
        private DataGridViewRow? selectedRow = null;

        public ListSupplier()
        {
            InitializeComponent();
            if (this.manageProvider == null)
                this.manageProvider = new SPA.Application.ManageProvider();
        }

        private void ListSupplier_Load(object sender, EventArgs e)
        {
            this.loadDataSource();
            this.initComponent();
        }

        private void loadDataSource()
        {
            var paramsQuery = new Dictionary<string, string>();
            //this.dgvProvider.DataSource = new List<object>();
            //this.dgvProvider.Refresh();
            this.dgvProvider.DataSource = this.manageProvider.list(paramsQuery);
            //this.providerBindingSource.DataSource = this.manageProvider.bindingList();
            this.dgvProvider.Refresh();
            Console.WriteLine( this.manageProvider.list(paramsQuery ) );
        }
        private void initComponent()
        {
            this.toolTipSearchButton.SetToolTip(this.btnSearch, "Busque un proveedor por su nombre.");
            this.toolTipAddAction.SetToolTip(this.pbAddAction, "Agregar proveedor");
            this.toolTipUpdateAction.SetToolTip(this.pbUpdateAction, "Actualizar proveedor");
            this.toolTipDeleteAction.SetToolTip(this.pbDeleteAction, "Eliminar proveedor");

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.searchBoxTerm();
        }

        // find a supplier
        private void searchBoxTerm() {

            if (this.ctSearchTerm.Text.Trim().Equals("") ) {
                MessageBox.Show("Debes introducir el nombre del proveedor a buscar.", "Notificación", MessageBoxButtons.OK);
                this.loadDataSource();
                return;
            }
            var paramsSearch = new Dictionary<string, string>()
            {
                {"Name", ctSearchTerm.Text.Trim() }
            };

            this.dgvProvider.DataSource = this.manageProvider.list( paramsSearch );
            this.dgvProvider.Update();
            this.dgvProvider.Refresh();
        }
        private void containerPanelActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ManageProvider manageProviderForm = new ManageProvider("add", 0);
            manageProviderForm.ShowDialog();
            this.loadDataSource();
        }

        private void toolTipAdd_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTipUpdateAction_Popup(object sender, PopupEventArgs e)
        {

        }


        private void pbDeleteAction_Click(object sender, EventArgs e)
        {
            if (!this.isSelectedRow || this.selectedRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla de proveedores.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            if (this.manageProvider.delete(int.Parse(this.selectedRow.Cells[0].Value.ToString())) > 0)
            {
                MessageBox.Show("El registro fue borrado correctamente.", "Notificación", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Algo no salió bien, inténtelo nuevamente.", "Notificación", MessageBoxButtons.OK );
            }
            this.loadDataSource();
            this.selectedRow = null;
            this.isSelectedRow = false;
        }

        private void pbUpdateAction_Click(object sender, EventArgs e)
        {
            if (!this.isSelectedRow || this.selectedRow == null)
            {
                MessageBox.Show("Debes seleccionar un registro a editar.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            
            ManageProvider manageProviderForm = new ManageProvider("edit", int.Parse( this.selectedRow.Cells[0].Value.ToString() ) );
            manageProviderForm.ShowDialog();

            this.loadDataSource();
            this.selectedRow = null;
            this.isSelectedRow = false;
        }

        private void pbSaveAction_Click(object sender, EventArgs e)
        {
            this.manageProvider.saveChange();
        }

        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.isSelectedRow = true;
                this.selectedRow = dgvProvider.Rows[e.RowIndex];
            }
        }

        private void dgvProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.isSelectedRow = true;
                this.selectedRow = dgvProvider.Rows[e.RowIndex];
            }
        }

        private void lbDescriptionSearch_Click(object sender, EventArgs e)
        {

        }

    }
}
