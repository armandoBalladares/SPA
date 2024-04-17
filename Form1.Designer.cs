namespace SPA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbTitle = new Label();
            lbName = new Label();
            ctName = new TextBox();
            lbPhone = new Label();
            ctPhone = new TextBox();
            btAdd = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(286, 61);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(533, 71);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Agregar Proveedor";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.Location = new Point(107, 185);
            lbName.Name = "lbName";
            lbName.Size = new Size(153, 47);
            lbName.TabIndex = 1;
            lbName.Text = "Nombre";
            // 
            // ctName
            // 
            ctName.Location = new Point(107, 251);
            ctName.Name = "ctName";
            ctName.Size = new Size(496, 39);
            ctName.TabIndex = 2;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.BackColor = Color.Transparent;
            lbPhone.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(672, 171);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(324, 47);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Numero telefonico";
            // 
            // ctPhone
            // 
            ctPhone.Location = new Point(642, 251);
            ctPhone.Name = "ctPhone";
            ctPhone.Size = new Size(500, 39);
            ctPhone.TabIndex = 4;
            // 
            // btAdd
            // 
            btAdd.Cursor = Cursors.Hand;
            btAdd.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdd.Location = new Point(107, 384);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(285, 78);
            btAdd.TabIndex = 5;
            btAdd.Text = "Agregar";
            btAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(494, 384);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(285, 78);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(857, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(285, 78);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1243, 612);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btAdd);
            Controls.Add(ctPhone);
            Controls.Add(lbPhone);
            Controls.Add(ctName);
            Controls.Add(lbName);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbName;
        private TextBox ctName;
        private Label lbPhone;
        private TextBox ctPhone;
        private Button btAdd;
        private Button btnClear;
        private Button btnCancel;
    }
}
