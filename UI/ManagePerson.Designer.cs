namespace SPA.UI
{
    partial class ManagePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePerson));
            mainContainerPanel = new Panel();
            ctEmail = new TextBox();
            lbEmail = new Label();
            ctDNI = new TextBox();
            lbDNI = new Label();
            btnCancel = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            ctLastName = new TextBox();
            lbLastName = new Label();
            ctName = new TextBox();
            lbName = new Label();
            lbTitle = new Label();
            mainContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.BackColor = Color.Transparent;
            mainContainerPanel.BorderStyle = BorderStyle.FixedSingle;
            mainContainerPanel.Controls.Add(ctEmail);
            mainContainerPanel.Controls.Add(lbEmail);
            mainContainerPanel.Controls.Add(ctDNI);
            mainContainerPanel.Controls.Add(lbDNI);
            mainContainerPanel.Controls.Add(btnCancel);
            mainContainerPanel.Controls.Add(btnClear);
            mainContainerPanel.Controls.Add(btnAdd);
            mainContainerPanel.Controls.Add(ctLastName);
            mainContainerPanel.Controls.Add(lbLastName);
            mainContainerPanel.Controls.Add(ctName);
            mainContainerPanel.Controls.Add(lbName);
            mainContainerPanel.Controls.Add(lbTitle);
            mainContainerPanel.Location = new Point(38, 29);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.Size = new Size(1256, 710);
            mainContainerPanel.TabIndex = 1;
            mainContainerPanel.Paint += mainContainerPanel_Paint;
            // 
            // ctEmail
            // 
            ctEmail.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctEmail.Location = new Point(646, 434);
            ctEmail.Name = "ctEmail";
            ctEmail.Size = new Size(496, 57);
            ctEmail.TabIndex = 6;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Transparent;
            lbEmail.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(646, 368);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(317, 47);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Correo Electrónico";
            // 
            // ctDNI
            // 
            ctDNI.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctDNI.Location = new Point(111, 434);
            ctDNI.Name = "ctDNI";
            ctDNI.Size = new Size(496, 57);
            ctDNI.TabIndex = 5;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.BackColor = Color.Transparent;
            lbDNI.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbDNI.Location = new Point(111, 368);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(351, 47);
            lbDNI.TabIndex = 5;
            lbDNI.Text = "Cedula de Identidad";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(861, 578);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(285, 78);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(498, 578);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(285, 78);
            btnClear.TabIndex = 8;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(111, 578);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(285, 78);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btAdd_Click;
            // 
            // ctLastName
            // 
            ctLastName.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctLastName.Location = new Point(646, 259);
            ctLastName.Name = "ctLastName";
            ctLastName.Size = new Size(500, 57);
            ctLastName.TabIndex = 4;
            ctLastName.KeyPress += ctPhone_KeyPress;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.BackColor = Color.Transparent;
            lbLastName.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbLastName.Location = new Point(676, 179);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(173, 47);
            lbLastName.TabIndex = 3;
            lbLastName.Text = "Apellidos";
            // 
            // ctName
            // 
            ctName.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctName.Location = new Point(111, 259);
            ctName.Name = "ctName";
            ctName.Size = new Size(496, 57);
            ctName.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.Location = new Point(111, 193);
            lbName.Name = "lbName";
            lbName.Size = new Size(168, 47);
            lbName.TabIndex = 1;
            lbName.Text = "Nombres";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(290, 69);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(470, 71);
            lbTitle.TabIndex = 8;
            lbTitle.Text = "Agregar Persona";
            // 
            // ManagePerson
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1333, 777);
            Controls.Add(mainContainerPanel);
            Name = "ManagePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Person";
            Load += ManagePerson_Load;
            mainContainerPanel.ResumeLayout(false);
            mainContainerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainContainerPanel;
        private Button btnCancel;
        private Button btnClear;
        private Button btnAdd;
        private TextBox ctLastName;
        private Label lbLastName;
        private TextBox ctName;
        private Label lbName;
        private Label lbTitle;
        private TextBox ctEmail;
        private Label lbEmail;
        private TextBox ctDNI;
        private Label lbDNI;
    }
}