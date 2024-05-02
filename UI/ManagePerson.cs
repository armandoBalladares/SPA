using System.Collections.ObjectModel;

namespace SPA.UI
{
    public partial class ManagePerson : Form
    {
        private string action = "add";
        private int identifier = 0;
        public SPA.Application.ManagePerson? managePerson;
        public ManagePerson()
        {
            InitializeComponent();
            if (this.managePerson == null)
                this.managePerson = new SPA.Application.ManagePerson();
        }
        public ManagePerson(string action, int identifier)
        {
            InitializeComponent();
            if (this.managePerson == null)
                this.managePerson = new SPA.Application.ManagePerson();
            this.action = action;
            this.identifier = identifier;

            if (this.action == "edit")
            {
                this.lbTitle.Text = "Editar Persona";
                this.btnAdd.Text = "Guardar";
                this.getPersona();
            }
        }
        private void ManagePerson_Load(object sender, EventArgs e)
        {

        }

        private void getPersona()
        {
            var foundPerson = this.managePerson.show(this.identifier);
            if (foundPerson != null)
            {
                ctName.Text = foundPerson.Name;
                ctLastName.Text = foundPerson.LastName;
                ctDNI.Text = foundPerson.DNI;
                ctEmail.Text = foundPerson.Email;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (ctName.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            if (ctLastName.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debes ingresar el apellido de la persona.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            if (ctDNI.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debes ingresar la cedula de identificación de la persona.", "Notificación", MessageBoxButtons.OK);
                return;
            }
            if (ctEmail.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debes ingresar el correo electrónico de la persona.", "Notificación", MessageBoxButtons.OK);
                return;
            }

            this.disableControls();
            Collection<Object> data = new Collection<Object>();
            if (this.action == "add")
            {
                data.Add(ctName.Text.ToString().Trim());
                data.Add(ctLastName.Text.ToString().Trim());
                data.Add( ctDNI.Text.ToString().Trim() );
                data.Add(ctEmail.Text.ToString().Trim());
                if (this.managePerson.add(data) > 0)
                {
                    MessageBox.Show("La persona se agregó correctamente..", "Notificación", MessageBoxButtons.OK);
                }
                this.clearFields();
            }

            if (this.action == "edit")
            {
                data.Add(this.identifier);
                data.Add(ctName.Text.ToString().Trim());
                data.Add(ctLastName.Text.ToString().Trim());
                data.Add(this.ctDNI.Text.ToString().Trim());
                data.Add(this.ctEmail.Text.ToString().Trim());
                if (this.managePerson.update(data) > 0)
                {
                    MessageBox.Show("Los datos se actualizaron correctamente.", "Notificación", MessageBoxButtons.OK);
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
            /*
            // Verifica si la tecla presionada no es un número o la tecla BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o BackSpace, ignora la tecla presionada estableciendo Handled a true
                e.Handled = true;
            }
            */
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.managePerson = null;
            this.Close();
        }

        private void mainContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clearFields()
        {
            this.ctName.Clear();
            this.ctLastName.Clear();
            this.ctDNI.Clear();
            this.ctEmail.Clear();
        }
    }
}
