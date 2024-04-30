using System.Collections.ObjectModel;

namespace SPA.UI
{
    public partial class ManageProvider : Form
    {
        private string action = "add";
        private int identifier = 0;
        public SPA.Application.ManageProvider? manageProvider;
        public ManageProvider()
        {
            InitializeComponent();
            if (this.manageProvider == null)
                this.manageProvider = new SPA.Application.ManageProvider();
        }
        public ManageProvider(string action, int identifier )
        {
            InitializeComponent();
            if (this.manageProvider == null)
                this.manageProvider = new SPA.Application.ManageProvider();
            this.action = action;
            this.identifier = identifier;

            if ( this.action == "edit") {
                this.lbTitle.Text = "Editar Proveedor";
                this.btnAdd.Text = "Guardar";
                this.getProvider();
            }
        }

        private void ManageProvider_Load(object sender, EventArgs e)
        {

        }

        private void getProvider() {
            var foundSupplier = this.manageProvider.show( this.identifier );
            if ( foundSupplier != null ) {
                ctName.Text = foundSupplier.Name;
                ctPhone.Text = foundSupplier.Phone;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (ctName.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            if (ctPhone.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debe ingresar el número telefónico.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            this.disableControls();
            Collection<Object> data = new Collection<Object>();
            if ( this.action == "add" ) {
                data.Add(ctName.Text.ToString().Trim());
                data.Add(ctPhone.Text.ToString().Trim());
                if (this.manageProvider.add(data) > 0)
                {
                    MessageBox.Show("El proveedor se agregó correctamente..", "Notificación", MessageBoxButtons.OK);
                }
                this.ctName.Clear();
                this.ctPhone.Clear();
            }

            if ( this.action == "edit" ) {
                data.Add( this.identifier );
                data.Add(ctName.Text.ToString().Trim());
                data.Add(ctPhone.Text.ToString().Trim());
                if (this.manageProvider.update(data) > 0)
                {
                    MessageBox.Show("El proveedor se actualizo correctamente.", "Notificación", MessageBoxButtons.OK);
                }
            }
            this.enableControls();
        }
        private void disableControls()
        {
            this.mainContainerPanel.Enabled = false;
        }
        private void enableControls()
        {
            this.mainContainerPanel.Enabled = true;
        }
        private void ctPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o BackSpace, ignora la tecla presionada estableciendo Handled a true
                e.Handled = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ctName.Clear();
            this.ctPhone.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.manageProvider = null;
            this.Close();
        }

        private void mainContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
