using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.UI
{
    public partial class ManageProvider : Form
    {
        public SPA.Application.ManageProvider? manageProvider;
        public ManageProvider()
        {
            InitializeComponent();
            if (this.manageProvider == null)
                this.manageProvider = new SPA.Application.ManageProvider();
        }
        private void ManageProvider_Load(object sender, EventArgs e)
        {

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
            data.Add( ctName.Text.ToString().Trim() );
            data.Add( ctPhone.Text.ToString().Trim() );   
            if ( this.manageProvider.add(data) > 0 )
            {
                MessageBox.Show("El proveedor se agregó correctamente..", "Notificación", MessageBoxButtons.OK);
            }
            this.enableControls();
        }
        private void disableControls() { 
            this.mainContainerPanel.Enabled = false;
        }
        private void enableControls() {
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
    }
}
