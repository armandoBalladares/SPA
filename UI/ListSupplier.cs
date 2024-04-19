using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.UI
{
    public partial class ListSupplier : Form
    {
        public SPA.Application.ManageProvider? manageProvider;

        public ListSupplier()
        {
            InitializeComponent();
            if (this.manageProvider == null)
                this.manageProvider = new SPA.Application.ManageProvider();
        }

        private void ListSupplier_Load(object sender, EventArgs e)
        {
            this.loadDataSource();
        }

        private void loadDataSource() {
            var paramsQuery = new Dictionary<string, object>();
            // this.dgvProvider.DataSource = this.manageProvider.list(paramsQuery);
            this.providerBindingSource.DataSource = this.manageProvider.bindingList();
        }
    }
}
