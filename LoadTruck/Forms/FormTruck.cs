using LoadTruckDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadTruckDatabase.Entities;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoadTruck
{
    public enum FormTruckMode
    {
        Add,
        Edit
    }
    public partial class FormTruck : Form
    {
        private DatabaseContext _context { get; set; }
        private FormMain _main;
        private Truck _truck { get; set; }
        private FormTruckMode _mode;

        public FormTruck(FormMain main)
        {
            InitializeComponent();
            _main = main;
            _context = new DatabaseContext();
            _mode = FormTruckMode.Add;
            cbStatus.Enabled = false;
            this.Text = "Add Truck";
        }

        public FormTruck(FormMain main, Truck truck)
        {
            InitializeComponent();
            _main = main;
            _context = new DatabaseContext();
            _truck = truck;
            _mode = FormTruckMode.Edit;
            cbStatus.Enabled = true;
            this.Text = $"Edit Truck [{truck.Name}]";
        }

        private void FormTruck_Load(object sender, EventArgs e)
        {
            DisplayErrorMessages(false);
            populateStatusComboBox();

            if(_mode == FormTruckMode.Edit)
            {
                tbName.Text = _truck.Name;
                tbTruckNumber.Text = _truck.Number.ToString();
                cbStatus.SelectedItem = new KeyValuePair<string, string>(_truck.TruckStatus.TruckStatusId.ToString(), _truck.TruckStatus.Text);
            }
        }
        private void populateStatusComboBox()
        {
            var statusItems = new Dictionary<string, string>();

            var truckStatuses = _context?.TruckStatuses?.ToList();
            
            foreach(var status in truckStatuses)
            {
                statusItems.Add(status.TruckStatusId.ToString(), status.Text);
            }

            cbStatus.DataSource = new BindingSource(statusItems, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string key = ((KeyValuePair<string, string>)cbStatus.SelectedItem).Key;

                if (_mode == FormTruckMode.Add)
                {
                    var truck = new Truck()
                    {
                        TruckId = Guid.NewGuid(),
                        Name = tbName.Text,
                        Number = int.Parse(tbTruckNumber.Text.Trim()),
                        TruckStatusId = Guid.Parse(key)
                    };

                    _context?.Trucks?.Add(truck);
                }
                else
                {
                    _truck.Name = tbName.Text;
                    _truck.Number = int.Parse(tbTruckNumber.Text.Trim());
                    _truck.TruckStatusId = Guid.Parse(key);
                }

                _context?.SaveChanges();

                _main.PopulateStatusComboBox();
                this.Close();
            }
        }

        private void DisplayErrorMessages(bool visible)
        {
            lblNameError.Visible = visible;
            lblNumberError.Visible = visible;
            lblStatusError.Visible = visible;
            lblTruckErrors.Visible = visible;
        }

        private bool IsValid()
        {
            var errorCount = 0;

            if (string.IsNullOrEmpty(tbName.Text) || tbName.Text.Count() >= 10)
            {
                lblNameError.Visible = true;
                lblNameError.Text = "The name cannot be empty and must be below 10 characters. Please enter a name.";
                errorCount++;
            }
            else
            {
                lblNameError.Visible = false;
            }


            if (string.IsNullOrEmpty(tbTruckNumber.Text))
            {
                lblNumberError.Visible = true;
                lblNumberError.Text = "The number cannot be empty. Please enter a number.";
                errorCount++;
            }
            else
            {
                lblNumberError.Visible = false;
            }

            var isValid = errorCount == 0 ? true : false;

            if (!isValid)
            {
                lblTruckErrors.Visible = true;
                lblTruckErrors.Text = $"Errors ({errorCount}): Please correct the following errors.";
            }

            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
