namespace SPA.Application
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnClear = new Button();
            btAdd = new Button();
            ctPhone = new TextBox();
            lbPhone = new Label();
            ctName = new TextBox();
            lbName = new Label();
            lbTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btAdd);
            panel1.Controls.Add(ctPhone);
            panel1.Controls.Add(lbPhone);
            panel1.Controls.Add(ctName);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(lbTitle);
            panel1.Location = new Point(31, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 495);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(885, 344);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(285, 78);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(522, 344);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(285, 78);
            btnClear.TabIndex = 13;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            btAdd.Cursor = Cursors.Hand;
            btAdd.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdd.Location = new Point(135, 344);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(285, 78);
            btAdd.TabIndex = 12;
            btAdd.Text = "Agregar";
            btAdd.UseVisualStyleBackColor = true;
            // 
            // ctPhone
            // 
            ctPhone.Location = new Point(670, 211);
            ctPhone.Name = "ctPhone";
            ctPhone.Size = new Size(500, 39);
            ctPhone.TabIndex = 11;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(700, 131);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(324, 47);
            lbPhone.TabIndex = 10;
            lbPhone.Text = "Numero telefónico";
            // 
            // ctName
            // 
            ctName.Location = new Point(135, 211);
            ctName.Name = "ctName";
            ctName.Size = new Size(500, 39);
            ctName.TabIndex = 9;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.Location = new Point(135, 145);
            lbName.Name = "lbName";
            lbName.Size = new Size(153, 47);
            lbName.TabIndex = 8;
            lbName.Text = "Nombre";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(332, 21);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(533, 71);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Agregar Proveedor";
            // 
            // ManageProvider
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1349, 628);
            Controls.Add(panel1);
            Name = "ManageProvider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Provider";
            Load += ManageProvider_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTitle;
        private Button btnCancel;
        private Button btnClear;
        private Button btAdd;
        private TextBox ctPhone;
        private Label lbPhone;
        private TextBox ctName;
        private Label lbName;
    }
}