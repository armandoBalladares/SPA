namespace SPA.UI
{
    partial class ListSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSupplier));
            lbTitle = new Label();
            dgvProvider = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            pbAddAction = new PictureBox();
            pbUpdateAction = new PictureBox();
            pbDeleteAction = new PictureBox();
            ctSearchTerm = new TextBox();
            lbDescriptionSearch = new Label();
            btnSearch = new Button();
            containerPanelActions = new Panel();
            pbSaveAction = new PictureBox();
            toolTipSearchButton = new ToolTip(components);
            toolTipAddAction = new ToolTip(components);
            toolTipUpdateAction = new ToolTip(components);
            toolTipDeleteAction = new ToolTip(components);
            toolTipSaveAction = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddAction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAction).BeginInit();
            containerPanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSaveAction).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(130, 28);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(576, 71);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Lista de proveedores";
            // 
            // dgvProvider
            // 
            dgvProvider.AllowUserToAddRows = false;
            dgvProvider.AllowUserToDeleteRows = false;
            dgvProvider.AutoGenerateColumns = false;
            dgvProvider.BackgroundColor = Color.LightPink;
            dgvProvider.BorderStyle = BorderStyle.Fixed3D;
            dgvProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvider.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            dgvProvider.DataSource = providerBindingSource;
            dgvProvider.GridColor = SystemColors.WindowText;
            dgvProvider.Location = new Point(130, 228);
            dgvProvider.Name = "dgvProvider";
            dgvProvider.ReadOnly = true;
            dgvProvider.RowHeadersWidth = 82;
            dgvProvider.Size = new Size(691, 551);
            dgvProvider.TabIndex = 10;
            dgvProvider.CellClick += dgvProvider_CellClick;
            dgvProvider.CellDoubleClick += dgvProvider_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 10;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            phoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // providerBindingSource
            // 
            providerBindingSource.DataSource = typeof(Domain.Entity.Provider);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, -244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pbAddAction
            // 
            pbAddAction.BackColor = Color.Transparent;
            pbAddAction.BackgroundImage = (Image)resources.GetObject("pbAddAction.BackgroundImage");
            pbAddAction.BackgroundImageLayout = ImageLayout.Stretch;
            pbAddAction.Cursor = Cursors.Hand;
            pbAddAction.Location = new Point(122, 18);
            pbAddAction.Name = "pbAddAction";
            pbAddAction.Size = new Size(138, 110);
            pbAddAction.TabIndex = 13;
            pbAddAction.TabStop = false;
            pbAddAction.Click += pbAdd_Click;
            // 
            // pbUpdateAction
            // 
            pbUpdateAction.BackColor = Color.Transparent;
            pbUpdateAction.BackgroundImage = (Image)resources.GetObject("pbUpdateAction.BackgroundImage");
            pbUpdateAction.BackgroundImageLayout = ImageLayout.Stretch;
            pbUpdateAction.Cursor = Cursors.Hand;
            pbUpdateAction.Location = new Point(122, 160);
            pbUpdateAction.Name = "pbUpdateAction";
            pbUpdateAction.Size = new Size(138, 110);
            pbUpdateAction.TabIndex = 14;
            pbUpdateAction.TabStop = false;
            pbUpdateAction.Click += pbUpdateAction_Click;
            // 
            // pbDeleteAction
            // 
            pbDeleteAction.BackColor = Color.Transparent;
            pbDeleteAction.BackgroundImage = (Image)resources.GetObject("pbDeleteAction.BackgroundImage");
            pbDeleteAction.BackgroundImageLayout = ImageLayout.Stretch;
            pbDeleteAction.Cursor = Cursors.Hand;
            pbDeleteAction.Location = new Point(122, 300);
            pbDeleteAction.Name = "pbDeleteAction";
            pbDeleteAction.Size = new Size(138, 137);
            pbDeleteAction.TabIndex = 15;
            pbDeleteAction.TabStop = false;
            pbDeleteAction.Click += pbDeleteAction_Click;
            // 
            // ctSearchTerm
            // 
            ctSearchTerm.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctSearchTerm.Location = new Point(130, 122);
            ctSearchTerm.Name = "ctSearchTerm";
            ctSearchTerm.Size = new Size(691, 57);
            ctSearchTerm.TabIndex = 18;
            // 
            // lbDescriptionSearch
            // 
            lbDescriptionSearch.AutoSize = true;
            lbDescriptionSearch.BackColor = Color.Transparent;
            lbDescriptionSearch.Location = new Point(137, 182);
            lbDescriptionSearch.Name = "lbDescriptionSearch";
            lbDescriptionSearch.Size = new Size(1021, 32);
            lbDescriptionSearch.TabIndex = 19;
            lbDescriptionSearch.Text = "Usted puede buscar un determinado proveedor para ver sus datos, buscándolo por su nombre";
            lbDescriptionSearch.Click += lbDescriptionSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(869, 101);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(285, 78);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // containerPanelActions
            // 
            containerPanelActions.BackColor = Color.Transparent;
            containerPanelActions.Controls.Add(pbSaveAction);
            containerPanelActions.Controls.Add(pbAddAction);
            containerPanelActions.Controls.Add(pbUpdateAction);
            containerPanelActions.Controls.Add(pbDeleteAction);
            containerPanelActions.Location = new Point(869, 228);
            containerPanelActions.Name = "containerPanelActions";
            containerPanelActions.Size = new Size(400, 610);
            containerPanelActions.TabIndex = 21;
            containerPanelActions.Paint += containerPanelActions_Paint;
            // 
            // pbSaveAction
            // 
            pbSaveAction.BackColor = Color.Transparent;
            pbSaveAction.BackgroundImage = (Image)resources.GetObject("pbSaveAction.BackgroundImage");
            pbSaveAction.BackgroundImageLayout = ImageLayout.Stretch;
            pbSaveAction.Cursor = Cursors.Hand;
            pbSaveAction.Location = new Point(128, 461);
            pbSaveAction.Name = "pbSaveAction";
            pbSaveAction.Size = new Size(132, 121);
            pbSaveAction.TabIndex = 16;
            pbSaveAction.TabStop = false;
            pbSaveAction.Click += pbSaveAction_Click;
            // 
            // toolTipSearchButton
            // 
            toolTipSearchButton.ShowAlways = true;
            toolTipSearchButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipSearchButton.UseFading = false;
            // 
            // toolTipAddAction
            // 
            toolTipAddAction.Popup += toolTipAdd_Popup;
            // 
            // toolTipUpdateAction
            // 
            toolTipUpdateAction.Popup += toolTipUpdateAction_Popup;
            // 
            // ListSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 850);
            Controls.Add(containerPanelActions);
            Controls.Add(btnSearch);
            Controls.Add(lbDescriptionSearch);
            Controls.Add(ctSearchTerm);
            Controls.Add(pictureBox1);
            Controls.Add(dgvProvider);
            Controls.Add(lbTitle);
            Name = "ListSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Proveedor";
            Load += ListSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddAction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAction).EndInit();
            containerPanelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSaveAction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private DataGridView dgvProvider;
        private BindingSource providerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private PictureBox pbAddAction;
        private PictureBox pbUpdateAction;
        private PictureBox pbDeleteAction;
        private TextBox ctSearchTerm;
        private Label lbDescriptionSearch;
        private Button btnSearch;
        private Panel containerPanelActions;
        private PictureBox pbSaveAction;
        public ToolTip toolTipSearchButton;
        private ToolTip toolTipAddAction;
        private ToolTip toolTipUpdateAction;
        private ToolTip toolTipDeleteAction;
        private ToolTip toolTipSaveAction;
    }
}