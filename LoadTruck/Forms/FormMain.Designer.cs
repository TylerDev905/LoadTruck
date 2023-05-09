namespace LoadTruck
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            btnAssignToInventory = new Button();
            btnEdit = new Button();
            lvTruckInventory = new ListView();
            btnTruckDelete = new Button();
            btnAddTruck = new Button();
            cbTrucks = new ComboBox();
            groupBox2 = new GroupBox();
            btnAssignToTruck = new Button();
            lvInventory = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAssignToInventory);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(lvTruckInventory);
            groupBox1.Controls.Add(btnTruckDelete);
            groupBox1.Controls.Add(btnAddTruck);
            groupBox1.Controls.Add(cbTrucks);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Truck";
            // 
            // btnAssignToInventory
            // 
            btnAssignToInventory.Location = new Point(383, 257);
            btnAssignToInventory.Name = "btnAssignToInventory";
            btnAssignToInventory.Size = new Size(75, 23);
            btnAssignToInventory.TabIndex = 3;
            btnAssignToInventory.Text = "Assign";
            btnAssignToInventory.UseVisualStyleBackColor = true;
            btnAssignToInventory.Click += btnAssignToInventory_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(302, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lvTruckInventory
            // 
            lvTruckInventory.CheckBoxes = true;
            lvTruckInventory.GridLines = true;
            lvTruckInventory.Location = new Point(6, 50);
            lvTruckInventory.Name = "lvTruckInventory";
            lvTruckInventory.Size = new Size(452, 201);
            lvTruckInventory.TabIndex = 0;
            lvTruckInventory.UseCompatibleStateImageBehavior = false;
            lvTruckInventory.View = View.List;
            // 
            // btnTruckDelete
            // 
            btnTruckDelete.Location = new Point(383, 22);
            btnTruckDelete.Name = "btnTruckDelete";
            btnTruckDelete.Size = new Size(75, 23);
            btnTruckDelete.TabIndex = 3;
            btnTruckDelete.Text = "Delete";
            btnTruckDelete.UseVisualStyleBackColor = true;
            btnTruckDelete.Click += btnTruckDelete_Click;
            // 
            // btnAddTruck
            // 
            btnAddTruck.Location = new Point(221, 22);
            btnAddTruck.Name = "btnAddTruck";
            btnAddTruck.Size = new Size(75, 23);
            btnAddTruck.TabIndex = 1;
            btnAddTruck.Text = "Add";
            btnAddTruck.UseVisualStyleBackColor = true;
            btnAddTruck.Click += btnAddTruck_Click;
            // 
            // cbTrucks
            // 
            cbTrucks.FormattingEnabled = true;
            cbTrucks.Location = new Point(6, 22);
            cbTrucks.Name = "cbTrucks";
            cbTrucks.Size = new Size(209, 23);
            cbTrucks.TabIndex = 0;
            cbTrucks.SelectedIndexChanged += cbTrucks_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAssignToTruck);
            groupBox2.Controls.Add(lvInventory);
            groupBox2.Location = new Point(12, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 238);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inventory";
            // 
            // btnAssignToTruck
            // 
            btnAssignToTruck.Location = new Point(383, 209);
            btnAssignToTruck.Name = "btnAssignToTruck";
            btnAssignToTruck.Size = new Size(75, 23);
            btnAssignToTruck.TabIndex = 2;
            btnAssignToTruck.Text = "Assign";
            btnAssignToTruck.UseVisualStyleBackColor = true;
            btnAssignToTruck.Click += btnAssignToTruck_Click;
            // 
            // lvInventory
            // 
            lvInventory.CheckBoxes = true;
            lvInventory.GridLines = true;
            lvInventory.Location = new Point(6, 22);
            lvInventory.Name = "lvInventory";
            lvInventory.Size = new Size(452, 181);
            lvInventory.TabIndex = 1;
            lvInventory.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "LoadTruck";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTruckDelete;
        private Button btnAddTruck;
        private ComboBox cbTrucks;
        private GroupBox groupBox2;
        private Button btnEdit;
        private ListView lvTruckInventory;
        private ListView lvInventory;
        private Button btnAssignToTruck;
        private Button btnAssignToInventory;
    }
}