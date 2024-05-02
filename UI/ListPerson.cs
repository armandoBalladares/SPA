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
    public partial class ListPerson : Form
    {
        public SPA.Application.ManagePerson? managePerson;
        private bool isSelectedRow = false;
        private DataGridViewRow? selectedRow = null;

        public ListPerson()
        {
            InitializeComponent();
            if (this.managePerson == null)
                this.managePerson = new SPA.Application.ManagePerson();
        }

        private void ListPerson_Load(object sender, EventArgs e)
        {
            this.loadDataSource();
            this.initComponent();
        }

        private void loadDataSource()
        {
            var paramsQuery = new Dictionary<string, string>();
            this.dgvPerson.DataSource = this.managePerson.list(paramsQuery);
            //this.providerBindingSource.DataSource = this.managePerson.bindingList();
            this.dgvPerson.Refresh();
            this.dgvPerson.RefreshEdit();
        }
        private void initComponent()
        {
            this.toolTipSearchButton.SetToolTip(this.btnSearch, "Busque una persona por su nombre.");
            this.toolTipAddAction.SetToolTip(this.pbAddAction, "Agregar persona");
            this.toolTipUpdateAction.SetToolTip(this.pbUpdateAction, "Actualizar persona");
            this.toolTipDeleteAction.SetToolTip(this.pbDeleteAction, "Eliminar persona");

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            validateSearch();
        }
        private void ctSearchTerm_Enter(object sender, EventArgs e)
        {
            validateSearch();
        }
        private void validateSearch() {
            if (this.ctSearchTerm.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debes introducir el nombre de la persona a buscar.", "Notificación", MessageBoxButtons.OK);
                this.loadDataSource();
                return;
            }
            this.searchBoxTerm();
        }
        // find a supplier
        private void searchBoxTerm()
        {
            var paramsSearch = new Dictionary<string, string>()
            {
                {"LastName", ctSearchTerm.Text.Trim() }
            };

            this.dgvPerson.DataSource = this.managePerson.list(paramsSearch);
            this.dgvPerson.Refresh();
            this.dgvPerson.RefreshEdit();
        }
        private void ctSearchTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchBoxTerm();
        }

        private void containerPanelActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ManagePerson managePersonForm = new ManagePerson("add", 0);
            managePersonForm.ShowDialog();
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
                MessageBox.Show("Debe seleccionar un registro de la tabla de personas.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            if (this.managePerson.delete(int.Parse(this.selectedRow.Cells[0].Value.ToString())) > 0)
            {
                MessageBox.Show("El registro fue borrado correctamente.", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Algo no salió bien, inténtelo nuevamente.", "Notificación", MessageBoxButtons.OK);
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

            ManagePerson managePersonForm = new ManagePerson("edit", int.Parse(this.selectedRow.Cells[0].Value.ToString()));
            managePersonForm.ShowDialog();

            this.loadDataSource();
            this.selectedRow = null;
            this.isSelectedRow = false;
        }

        private void pbSaveAction_Click(object sender, EventArgs e)
        {
            this.managePerson.saveChange();
        }

        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.isSelectedRow = true;
                this.selectedRow = dgvPerson.Rows[e.RowIndex];
            }
        }

        private void dgvProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.isSelectedRow = true;
                this.selectedRow = dgvPerson.Rows[e.RowIndex];
            }
        }

        private void lbDescriptionSearch_Click(object sender, EventArgs e)
        {

        }

    }
}
