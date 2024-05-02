namespace SPA.UI
{
    partial class ListPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPerson));
            lbTitle = new Label();
            dgvPerson = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            pbAddAction = new PictureBox();
            pbUpdateAction = new PictureBox();
            pbDeleteAction = new PictureBox();
            ctSearchTerm = new TextBox();
            lbDescriptionSearch = new Label();
            btnSearch = new Button();
            containerPanelActions = new Panel();
            toolTipSearchButton = new ToolTip(components);
            toolTipAddAction = new ToolTip(components);
            toolTipUpdateAction = new ToolTip(components);
            toolTipDeleteAction = new ToolTip(components);
            toolTipSaveAction = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddAction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAction).BeginInit();
            containerPanelActions.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(130, 28);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(483, 71);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Lista de personas";
            // 
            // dgvPerson
            // 
            dgvPerson.AllowUserToAddRows = false;
            dgvPerson.AllowUserToDeleteRows = false;
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.BackgroundColor = Color.LightPink;
            dgvPerson.BorderStyle = BorderStyle.Fixed3D;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dgvPerson.DataSource = personBindingSource;
            dgvPerson.GridColor = SystemColors.WindowText;
            dgvPerson.Location = new Point(130, 228);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.ReadOnly = true;
            dgvPerson.RowHeadersWidth = 82;
            dgvPerson.Size = new Size(1085, 551);
            dgvPerson.TabIndex = 10;
            dgvPerson.CellClick += dgvProvider_CellClick;
            dgvPerson.CellDoubleClick += dgvProvider_CellDoubleClick;
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
            nameDataGridViewTextBoxColumn.HeaderText = "Nombres";
            nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "Cedula";
            dNIDataGridViewTextBoxColumn.MinimumWidth = 10;
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            dNIDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Domain.Entity.Person);
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
            ctSearchTerm.Enter += ctSearchTerm_Enter;
            ctSearchTerm.KeyPress += ctSearchTerm_KeyPress;
            // 
            // lbDescriptionSearch
            // 
            lbDescriptionSearch.AutoSize = true;
            lbDescriptionSearch.BackColor = Color.Transparent;
            lbDescriptionSearch.Location = new Point(137, 182);
            lbDescriptionSearch.Name = "lbDescriptionSearch";
            lbDescriptionSearch.Size = new Size(1015, 32);
            lbDescriptionSearch.TabIndex = 19;
            lbDescriptionSearch.Text = "Usted puede buscar una determinada persona, para ver sus datos, buscándola por su apellido.";
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
            containerPanelActions.Controls.Add(pbAddAction);
            containerPanelActions.Controls.Add(pbUpdateAction);
            containerPanelActions.Controls.Add(pbDeleteAction);
            containerPanelActions.Location = new Point(1282, 216);
            containerPanelActions.Name = "containerPanelActions";
            containerPanelActions.Size = new Size(400, 610);
            containerPanelActions.TabIndex = 21;
            containerPanelActions.Paint += containerPanelActions_Paint;
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
            // ListPerson
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1730, 850);
            Controls.Add(containerPanelActions);
            Controls.Add(btnSearch);
            Controls.Add(lbDescriptionSearch);
            Controls.Add(ctSearchTerm);
            Controls.Add(pictureBox1);
            Controls.Add(dgvPerson);
            Controls.Add(lbTitle);
            Name = "ListPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Persona";
            Load += ListPerson_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddAction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAction).EndInit();
            containerPanelActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private DataGridView dgvPerson;
        private PictureBox pictureBox1;
        private PictureBox pbAddAction;
        private PictureBox pbUpdateAction;
        private PictureBox pbDeleteAction;
        private TextBox ctSearchTerm;
        private Label lbDescriptionSearch;
        private Button btnSearch;
        private Panel containerPanelActions;
        public ToolTip toolTipSearchButton;
        private ToolTip toolTipAddAction;
        private ToolTip toolTipUpdateAction;
        private ToolTip toolTipDeleteAction;
        private ToolTip toolTipSaveAction;
        private BindingSource personBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}