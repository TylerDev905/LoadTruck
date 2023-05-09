using LoadTruckDatabase;
using LoadTruckDatabase.Entities;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace LoadTruck
{
    public partial class FormMain : Form
    {
        private DatabaseContext _context { get; set; }

        public FormMain()
        {
            InitializeComponent();
            _context = new DatabaseContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvInventory.View = View.Details;

            lvInventory.Columns.Add("PLU");
            lvInventory.Columns.Add("Number");
            lvInventory.Columns.Add("Weight");
            lvInventory.Columns.Add("Status");

            lvTruckInventory.View = View.Details;

            lvTruckInventory.Columns.Add("PLU");
            lvTruckInventory.Columns.Add("Number");
            lvTruckInventory.Columns.Add("Weight");
            lvTruckInventory.Columns.Add("Status");

            PopulateStatusComboBox();
            PopulateInventory();
        }

        private void PopulateTruckInventory(Guid? truckId)
        {
            var boxes = _context.Boxs
                .Where(b => b.TruckId == truckId)
                .ToList();

            lvTruckInventory .Items.Clear();

            foreach (var box in boxes)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = box.Plu;
                lvItem.SubItems.Add(box.Number.ToString());
                lvItem.SubItems.Add(box.Weight.ToString());
                lvItem.SubItems.Add(box.BoxStatus?.Text);
                lvItem.Tag = box.BoxId;

                lvTruckInventory.Items.Add(lvItem);
            }
        }

        public void PopulateInventory()
        {
            var boxes = _context.Boxs
                .Where(b => b.TruckId == null)
                .ToList();

            lvInventory.Items.Clear();

            foreach (var box in boxes)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = box.Plu;
                lvItem.SubItems.Add(box.Number.ToString());
                lvItem.SubItems.Add(box.Weight.ToString());
                lvItem.SubItems.Add(box.BoxStatus?.Text);
                lvItem.Tag = box.BoxId;

                lvInventory.Items.Add(lvItem);
            }
        }

        public void PopulateStatusComboBox()
        {
            var truckCbItems = new Dictionary<string, string>();

            var trucks = _context?.Trucks
                ?.OrderBy(t => t.Name)
                .ToList();

            if (trucks != null)
            {
                foreach (var truck in trucks)
                {
                    truckCbItems.Add(truck.TruckId.ToString(), truck.Name);
                }

                cbTrucks.DataSource = new BindingSource(truckCbItems, null);
                cbTrucks.DisplayMember = "Value";
                cbTrucks.ValueMember = "Key";
            }
        }

        private void btnAddTruck_Click(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)cbTrucks.SelectedItem).Key;

            var form = new FormTruck(this);
            form.Visible = true;
        }

        private void btnTruckDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete this truck?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if (res == DialogResult.OK)
            {
                string key = ((KeyValuePair<string, string>)cbTrucks.SelectedItem).Key;

                var id = Guid.Parse(key);

                var selectedTruck = _context?.Trucks
                    ?.SingleOrDefault(t => t.TruckId == id);

                if (selectedTruck != null)
                {
                    var boxs = _context.Boxs.ToList();

                    foreach(var box in boxs)
                    {
                        box.TruckId = null;
                        box.BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662");
                    }
                    
                    _context?.Trucks?.Remove(selectedTruck);

                    _context.SaveChanges();

                    var truck = _context.Trucks.First();

                    PopulateTruckInventory(truck.TruckId);
                    PopulateInventory();
                    PopulateStatusComboBox();
                }
            }
        }

        private void cbTrucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrucks.SelectedItem != null)
            {
                string key = ((KeyValuePair<string, string>)cbTrucks.SelectedItem).Key;
                var id = Guid.Parse(key);

                PopulateTruckInventory(id);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)cbTrucks.SelectedItem).Key;
            var id = Guid.Parse(key);

            var truck = _context.Trucks.Single(t => t.TruckId == id);

            var form = new FormTruck(this, truck);
            form.Visible = true;
        }

        private void btnAssignToTruck_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem boxListItem in lvInventory.CheckedItems)
            {
                var boxId = boxListItem.Tag as Guid?;

                var box = _context.Boxs.Find(boxId);

                string key = ((KeyValuePair<string, string>)cbTrucks.SelectedItem).Key;

                box.TruckId = Guid.Parse(key);
                box.BoxStatusId = Guid.Parse("96526A0B-0AC1-4589-BBEC-E0028F3F09F4");

                _context.SaveChanges();

                PopulateTruckInventory(box.TruckId);
                PopulateInventory();
            }
        }

        private void btnAssignToInventory_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem boxListItem in lvTruckInventory.CheckedItems)
            {
                var boxId = boxListItem.Tag as Guid?;

                var box = _context.Boxs.Find(boxId);

                string key = ((KeyValuePair<string, string>)cbTrucks.SelectedItem).Key;

                box.TruckId = null;
                box.BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662");

                _context.SaveChanges();

                PopulateTruckInventory(Guid.Parse(key));
                PopulateInventory();
            }
        }
    }
}