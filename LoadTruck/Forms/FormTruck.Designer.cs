namespace LoadTruck
{
    partial class FormTruck
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
            gbName = new GroupBox();
            lblNameError = new Label();
            tbName = new TextBox();
            gbTruckNumber = new GroupBox();
            lblNumberError = new Label();
            tbTruckNumber = new TextBox();
            gbTruckStatus = new GroupBox();
            cbStatus = new ComboBox();
            lblStatusError = new Label();
            gbTruck = new GroupBox();
            lblTruckErrors = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            gbName.SuspendLayout();
            gbTruckNumber.SuspendLayout();
            gbTruckStatus.SuspendLayout();
            gbTruck.SuspendLayout();
            SuspendLayout();
            // 
            // gbName
            // 
            gbName.Controls.Add(lblNameError);
            gbName.Controls.Add(tbName);
            gbName.Location = new Point(19, 32);
            gbName.Name = "gbName";
            gbName.Size = new Size(334, 84);
            gbName.TabIndex = 0;
            gbName.TabStop = false;
            gbName.Text = "Name";
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.ForeColor = Color.FromArgb(192, 0, 0);
            lblNameError.Location = new Point(12, 57);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(56, 15);
            lblNameError.TabIndex = 1;
            lblNameError.Text = "Error Text";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(316, 23);
            tbName.TabIndex = 0;
            // 
            // gbTruckNumber
            // 
            gbTruckNumber.Controls.Add(lblNumberError);
            gbTruckNumber.Controls.Add(tbTruckNumber);
            gbTruckNumber.Location = new Point(19, 122);
            gbTruckNumber.Name = "gbTruckNumber";
            gbTruckNumber.Size = new Size(334, 84);
            gbTruckNumber.TabIndex = 1;
            gbTruckNumber.TabStop = false;
            gbTruckNumber.Text = "Number";
            // 
            // lblNumberError
            // 
            lblNumberError.AutoSize = true;
            lblNumberError.ForeColor = Color.FromArgb(192, 0, 0);
            lblNumberError.Location = new Point(12, 57);
            lblNumberError.Name = "lblNumberError";
            lblNumberError.Size = new Size(56, 15);
            lblNumberError.TabIndex = 1;
            lblNumberError.Text = "Error Text";
            // 
            // tbTruckNumber
            // 
            tbTruckNumber.Location = new Point(12, 22);
            tbTruckNumber.Name = "tbTruckNumber";
            tbTruckNumber.Size = new Size(316, 23);
            tbTruckNumber.TabIndex = 0;
            // 
            // gbTruckStatus
            // 
            gbTruckStatus.Controls.Add(cbStatus);
            gbTruckStatus.Controls.Add(lblStatusError);
            gbTruckStatus.Location = new Point(22, 215);
            gbTruckStatus.Name = "gbTruckStatus";
            gbTruckStatus.Size = new Size(334, 84);
            gbTruckStatus.TabIndex = 2;
            gbTruckStatus.TabStop = false;
            gbTruckStatus.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(9, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(316, 23);
            cbStatus.TabIndex = 6;
            // 
            // lblStatusError
            // 
            lblStatusError.AutoSize = true;
            lblStatusError.ForeColor = Color.FromArgb(192, 0, 0);
            lblStatusError.Location = new Point(12, 57);
            lblStatusError.Name = "lblStatusError";
            lblStatusError.Size = new Size(56, 15);
            lblStatusError.TabIndex = 1;
            lblStatusError.Text = "Error Text";
            // 
            // gbTruck
            // 
            gbTruck.Controls.Add(lblTruckErrors);
            gbTruck.Controls.Add(btnCancel);
            gbTruck.Controls.Add(btnSubmit);
            gbTruck.Controls.Add(gbName);
            gbTruck.Controls.Add(gbTruckStatus);
            gbTruck.Controls.Add(gbTruckNumber);
            gbTruck.Location = new Point(12, 12);
            gbTruck.Name = "gbTruck";
            gbTruck.Size = new Size(373, 399);
            gbTruck.TabIndex = 3;
            gbTruck.TabStop = false;
            gbTruck.Text = "Truck Details";
            // 
            // lblTruckErrors
            // 
            lblTruckErrors.AutoSize = true;
            lblTruckErrors.ForeColor = Color.FromArgb(192, 0, 0);
            lblTruckErrors.Location = new Point(34, 315);
            lblTruckErrors.Name = "lblTruckErrors";
            lblTruckErrors.Size = new Size(56, 15);
            lblTruckErrors.TabIndex = 6;
            lblTruckErrors.Text = "Error Text";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(233, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(22, 347);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(123, 33);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormTruck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 422);
            Controls.Add(gbTruck);
            Name = "FormTruck";
            Text = "Add Truck";
            Load += FormTruck_Load;
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbTruckNumber.ResumeLayout(false);
            gbTruckNumber.PerformLayout();
            gbTruckStatus.ResumeLayout(false);
            gbTruckStatus.PerformLayout();
            gbTruck.ResumeLayout(false);
            gbTruck.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbName;
        private Label lblNameError;
        private TextBox tbName;
        private GroupBox gbTruckNumber;
        private Label lblNumberError;
        private TextBox tbTruckNumber;
        private GroupBox gbTruckStatus;
        private ComboBox cbStatus;
        private Label lblStatusError;
        private GroupBox gbTruck;
        private Label lblTruckErrors;
        private Button btnCancel;
        private Button btnSubmit;
    }
}