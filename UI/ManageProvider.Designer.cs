namespace SPA.UI
{
    partial class ManageProvider
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
            mainContainerPanel = new Panel();
            btnCancel = new Button();
            btnClear = new Button();
            btAdd = new Button();
            ctPhone = new TextBox();
            lbPhone = new Label();
            ctName = new TextBox();
            lbName = new Label();
            lbTitle = new Label();
            mainContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.Controls.Add(btnCancel);
            mainContainerPanel.Controls.Add(btnClear);
            mainContainerPanel.Controls.Add(btAdd);
            mainContainerPanel.Controls.Add(ctPhone);
            mainContainerPanel.Controls.Add(lbPhone);
            mainContainerPanel.Controls.Add(ctName);
            mainContainerPanel.Controls.Add(lbName);
            mainContainerPanel.Controls.Add(lbTitle);
            mainContainerPanel.Location = new Point(38, 29);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.Size = new Size(1256, 539);
            mainContainerPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(861, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(285, 78);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(498, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(285, 78);
            btnClear.TabIndex = 14;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btAdd
            // 
            btAdd.Cursor = Cursors.Hand;
            btAdd.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdd.Location = new Point(111, 392);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(285, 78);
            btAdd.TabIndex = 13;
            btAdd.Text = "Agregar";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // ctPhone
            // 
            ctPhone.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctPhone.Location = new Point(646, 259);
            ctPhone.Name = "ctPhone";
            ctPhone.Size = new Size(500, 57);
            ctPhone.TabIndex = 12;
            ctPhone.KeyPress += ctPhone_KeyPress;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.BackColor = Color.Transparent;
            lbPhone.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(676, 179);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(332, 47);
            lbPhone.TabIndex = 11;
            lbPhone.Text = "Numero Telefónico";
            // 
            // ctName
            // 
            ctName.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctName.Location = new Point(111, 259);
            ctName.Name = "ctName";
            ctName.Size = new Size(496, 57);
            ctName.TabIndex = 10;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.Location = new Point(111, 193);
            lbName.Name = "lbName";
            lbName.Size = new Size(153, 47);
            lbName.TabIndex = 9;
            lbName.Text = "Nombre";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(290, 69);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(533, 71);
            lbTitle.TabIndex = 8;
            lbTitle.Text = "Agregar Proveedor";
            // 
            // ManageProvider
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1333, 600);
            Controls.Add(mainContainerPanel);
            Name = "ManageProvider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Provider";
            Load += ManageProvider_Load;
            mainContainerPanel.ResumeLayout(false);
            mainContainerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainContainerPanel;
        private Button btnCancel;
        private Button btnClear;
        private Button btAdd;
        private TextBox ctPhone;
        private Label lbPhone;
        private TextBox ctName;
        private Label lbName;
        private Label lbTitle;
    }
}