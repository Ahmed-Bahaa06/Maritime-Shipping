using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MaritimeShippingManagementSystem
{
    public partial class Form1 : Form
    {
        private DatabaseManager db = new DatabaseManager();

        private Dictionary<string, Control> insertControls =
            new Dictionary<string, Control>();

        private Dictionary<string, Control> updateControls =
            new Dictionary<string, Control>();

        private string currentTable = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bool connected = db.TestConnection();

                if (!connected)
                {
                    MessageBox.Show(
                        "Failed to connect to SQL Server.",
                        "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    tabMain.Enabled = false;
                    return;
                }

                lblStatus.Text = "Connected successfully";

                lstTables.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lstTables_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            currentTable = lstTables.SelectedItem.ToString();

            LoadTableData();
            BuildInsertPanel();
            BuildUpdatePanel();
        }

        private void LoadTableData()
        {
            try
            {
                DataTable table = null;

                switch (currentTable)
                {
                    case "CLIENT":
                        table = db.GetAllClients();
                        break;

                    case "PORT":
                        table = db.GetAllPorts();
                        break;

                    case "VESSEL":
                        table = db.GetAllVessels();
                        break;

                    case "VOYAGE":
                        table = db.GetAllVoyages();
                        break;

                    case "CONTAINER":
                        table = db.GetAllContainers();
                        break;

                    case "CREWMEMBER":
                        table = db.GetAllCrewMembers();
                        break;

                    case "MANIFEST":
                        table = db.GetAllManifests();
                        break;

                    case "CARRIES":
                        table = db.GetAllCarries();
                        break;

                    case "LISTS_IN":
                        table = db.GetAllListsIn();
                        break;

                    case "HAS":
                        table = db.GetAllHas();
                        break;
                }

                dgvMain.DataSource = table;

                lblRecordCount.Text =
                    "Records: " + table.Rows.Count;

                lblStatus.Text =
                    currentTable + " loaded successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BuildInsertPanel()
        {
            tblInsert.Controls.Clear();
            tblInsert.RowStyles.Clear();
            tblInsert.RowCount = 0;

            insertControls.Clear();

            CreateFields(tblInsert, insertControls);
        }

        private void BuildUpdatePanel()
        {
            tblUpdate.Controls.Clear();
            tblUpdate.RowStyles.Clear();
            tblUpdate.RowCount = 0;

            updateControls.Clear();

            CreateFields(tblUpdate, updateControls);
        }

        private void CreateFields(
            TableLayoutPanel panel,
            Dictionary<string, Control> dict)
        {
            string[] fields = GetFieldsForTable(currentTable);

            foreach (string field in fields)
            {
                Label lbl = new Label();

                lbl.Text = field;
                lbl.ForeColor = Color.Black;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;

                Control control;

                if (field.Contains("DATE"))
                {
                    control = new DateTimePicker();
                }
                else
                {
                    control = new TextBox();
                }

                control.Dock = DockStyle.Fill;

                panel.RowCount++;

                panel.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 40));

                panel.Controls.Add(lbl, 0, panel.RowCount - 1);
                panel.Controls.Add(control, 1, panel.RowCount - 1);

                dict.Add(field, control);
            }
        }

        private string[] GetFieldsForTable(string table)
        {
            switch (table)
            {
                case "CLIENT":
                    return new string[]
                    {
                        "CLIENT_ID",
                        "CLIENT_NAME",
                        "CONTACT_INFO"
                    };

                case "PORT":
                    return new string[]
                    {
                        "PORT_ID",
                        "PORT_NAME",
                        "COORDINATES",
                        "DOCKING_FEES",
                        "CITY",
                        "COUNTRY",
                        "TERMINAL_AREA"
                    };

                case "VESSEL":
                    return new string[]
                    {
                        "VESSEL_ID",
                        "CAPACITY",
                        "REGISTRATION",
                        "FUEL_EFFICIENCY_RATING"
                    };

                case "VOYAGE":
                    return new string[]
                    {
                        "VOYAGE_ID",
                        "ORIGIN_PORT_ID",
                        "DEST_PORT_ID",
                        "VESSEL_ID",
                        "STATUS",
                        "DEPARTURE_DATE",
                        "ARRIVAL_DATE"
                    };

                case "CONTAINER":
                    return new string[]
                    {
                        "SERIAL_NUMBER",
                        "CLIENT_ID",
                        "SIZE",
                        "CARGO_TYPE"
                    };

                case "CREWMEMBER":
                    return new string[]
                    {
                        "CREW_ID",
                        "CREW_NAME",
                        "NATIONALITY"
                    };

                case "MANIFEST":
                    return new string[]
                    {
                        "MANIFEST_ID",
                        "VOYAGE_ID",
                        "MANIFEST_DATE"
                    };

                case "CARRIES":
                    return new string[]
                    {
                        "VOYAGE_ID",
                        "SERIAL_NUMBER"
                    };

                case "LISTS_IN":
                    return new string[]
                    {
                        "MANIFEST_ID",
                        "SERIAL_NUMBER"
                    };

                default:
                    return new string[]
                    {
                        "VOYAGE_ID",
                        "CREW_ID",
                        "ROLE"
                    };
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                switch (currentTable)
                {
                    case "CLIENT":
                        db.InsertClient(
                            int.Parse(GetInsert("CLIENT_ID")),
                            GetInsert("CLIENT_NAME"),
                            GetInsert("CONTACT_INFO"));
                        break;

                    case "PORT":
                        db.InsertPort(
                            int.Parse(GetInsert("PORT_ID")),
                            GetInsert("PORT_NAME"),
                            GetInsert("COORDINATES"),
                            decimal.Parse(GetInsert("DOCKING_FEES")),
                            GetInsert("CITY"),
                            GetInsert("COUNTRY"),
                            GetInsert("TERMINAL_AREA"));
                        break;

                    case "VESSEL":
                        db.InsertVessel(
                            int.Parse(GetInsert("VESSEL_ID")),
                            int.Parse(GetInsert("CAPACITY")),
                            GetInsert("REGISTRATION"),
                            decimal.Parse(
                                GetInsert("FUEL_EFFICIENCY_RATING")));
                        break;

                    case "VOYAGE":
                        db.InsertVoyage(
                            int.Parse(GetInsert("VOYAGE_ID")),
                            int.Parse(GetInsert("ORIGIN_PORT_ID")),
                            int.Parse(GetInsert("DEST_PORT_ID")),
                            int.Parse(GetInsert("VESSEL_ID")),
                            GetInsert("STATUS"),
                            GetDateInsert("DEPARTURE_DATE"),
                            GetDateInsert("ARRIVAL_DATE"));
                        break;

                    case "CONTAINER":
                        db.InsertContainer(
                            GetInsert("SERIAL_NUMBER"),
                            int.Parse(GetInsert("CLIENT_ID")),
                            GetInsert("SIZE"),
                            GetInsert("CARGO_TYPE"));
                        break;

                    case "CREWMEMBER":
                        db.InsertCrewMember(
                            int.Parse(GetInsert("CREW_ID")),
                            GetInsert("CREW_NAME"),
                            GetInsert("NATIONALITY"));
                        break;

                    case "MANIFEST":
                        db.InsertManifest(
                            int.Parse(GetInsert("MANIFEST_ID")),
                            int.Parse(GetInsert("VOYAGE_ID")),
                            GetDateInsert("MANIFEST_DATE"));
                        break;

                    case "CARRIES":
                        db.InsertCarries(
                            int.Parse(GetInsert("VOYAGE_ID")),
                            GetInsert("SERIAL_NUMBER"));
                        break;

                    case "LISTS_IN":
                        db.InsertListsIn(
                            int.Parse(GetInsert("MANIFEST_ID")),
                            GetInsert("SERIAL_NUMBER"));
                        break;

                    case "HAS":
                        db.InsertHas(
                            int.Parse(GetInsert("VOYAGE_ID")),
                            int.Parse(GetInsert("CREW_ID")),
                            GetInsert("ROLE"));
                        break;
                }

                MessageBox.Show(
                    "Record inserted ✔",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTableData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvMain_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvMain.Rows[e.RowIndex];

                foreach (string key in updateControls.Keys)
                {
                    if (!dgvMain.Columns.Contains(key))
                        continue;

                    object value = row.Cells[key].Value;

                    if (updateControls[key] is TextBox)
                    {
                        ((TextBox)updateControls[key]).Text =
                            value.ToString();
                    }
                    else if (updateControls[key]
                             is DateTimePicker)
                    {
                        ((DateTimePicker)updateControls[key])
                            .Value = Convert.ToDateTime(value);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                switch (currentTable)
                {
                    case "CLIENT":
                        db.UpdateClient(
                            int.Parse(GetUpdate("CLIENT_ID")),
                            GetUpdate("CLIENT_NAME"),
                            GetUpdate("CONTACT_INFO"));
                        break;

                    case "PORT":
                        db.UpdatePort(
                            int.Parse(GetUpdate("PORT_ID")),
                            GetUpdate("PORT_NAME"),
                            decimal.Parse(GetUpdate("DOCKING_FEES")),
                            GetUpdate("CITY"),
                            GetUpdate("COUNTRY"));
                        break;

                    case "VESSEL":
                        db.UpdateVessel(
                            int.Parse(GetUpdate("VESSEL_ID")),
                            int.Parse(GetUpdate("CAPACITY")),
                            GetUpdate("REGISTRATION"),
                            decimal.Parse(
                                GetUpdate(
                                    "FUEL_EFFICIENCY_RATING")));
                        break;

                    case "VOYAGE":
                        db.UpdateVoyage(
                            int.Parse(GetUpdate("VOYAGE_ID")),
                            GetUpdate("STATUS"),
                            GetDateUpdate("DEPARTURE_DATE"),
                            GetDateUpdate("ARRIVAL_DATE"));
                        break;

                    case "CONTAINER":
                        db.UpdateContainer(
                            GetUpdate("SERIAL_NUMBER"),
                            GetUpdate("SIZE"),
                            GetUpdate("CARGO_TYPE"));
                        break;

                    case "CREWMEMBER":
                        db.UpdateCrewMember(
                            int.Parse(GetUpdate("CREW_ID")),
                            GetUpdate("CREW_NAME"),
                            GetUpdate("NATIONALITY"));
                        break;

                    case "MANIFEST":
                        db.UpdateManifest(
                            int.Parse(GetUpdate("MANIFEST_ID")),
                            GetDateUpdate("MANIFEST_DATE"));
                        break;

                    case "CARRIES":
                        db.UpdateCarriesRole(
                            int.Parse(GetUpdate("VOYAGE_ID")),
                            GetUpdate("SERIAL_NUMBER"));
                        break;

                    case "LISTS_IN":
                        db.UpdateListsIn(
                            int.Parse(GetUpdate("MANIFEST_ID")),
                            GetUpdate("SERIAL_NUMBER"));
                        break;

                    case "HAS":
                        db.UpdateHasRole(
                            int.Parse(GetUpdate("VOYAGE_ID")),
                            int.Parse(GetUpdate("CREW_ID")),
                            GetUpdate("ROLE"));
                        break;
                }

                MessageBox.Show(
                    "Record updated ✔",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTableData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                switch (currentTable)
                {
                    case "CLIENT":
                        db.DeleteClient(
                            int.Parse(GetUpdate("CLIENT_ID")));
                        break;

                    case "PORT":
                        db.DeletePort(
                            int.Parse(GetUpdate("PORT_ID")));
                        break;

                    case "VESSEL":
                        db.DeleteVessel(
                            int.Parse(GetUpdate("VESSEL_ID")));
                        break;

                    case "VOYAGE":
                        db.DeleteVoyage(
                            int.Parse(GetUpdate("VOYAGE_ID")));
                        break;

                    case "CONTAINER":
                        db.DeleteContainer(
                            GetUpdate("SERIAL_NUMBER"));
                        break;

                    case "CREWMEMBER":
                        db.DeleteCrewMember(
                            int.Parse(GetUpdate("CREW_ID")));
                        break;

                    case "MANIFEST":
                        db.DeleteManifest(
                            int.Parse(GetUpdate("MANIFEST_ID")));
                        break;

                    case "CARRIES":
                        db.DeleteCarries(
                            int.Parse(GetUpdate("VOYAGE_ID")),
                            GetUpdate("SERIAL_NUMBER"));
                        break;

                    case "LISTS_IN":
                        db.DeleteListsIn(
                            int.Parse(GetUpdate("MANIFEST_ID")),
                            GetUpdate("SERIAL_NUMBER"));
                        break;

                    case "HAS":
                        db.DeleteHas(
                            int.Parse(GetUpdate("VOYAGE_ID")),
                            int.Parse(GetUpdate("CREW_ID")));
                        break;
                }

                MessageBox.Show(
                    "Record deleted ✔",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTableData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            LoadTableData();
        }

        private void btnRunJoin_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DataTable table = null;

                switch (cmbJoinQueries.SelectedIndex)
                {
                    case 0:
                        table = db.GetVoyageFullDetails();
                        break;

                    case 1:
                        table = db
                            .GetContainersWithClientAndVoyage();
                        break;

                    case 2:
                        table = db.GetCrewByVoyage(
                            (int)numJoinParam.Value);
                        break;

                    case 3:
                        table = db.GetManifestWithContainers(
                            (int)numJoinParam.Value);
                        break;

                    case 4:
                        table = db
                            .GetVoyagesWithContainerCount();
                        break;
                }

                dgvJoin.DataSource = table;

                lblStatus.Text =
                    "Join query executed successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GetInsert(string key)
        {
            return ((TextBox)insertControls[key]).Text;
        }

        private DateTime GetDateInsert(string key)
        {
            return ((DateTimePicker)insertControls[key]).Value;
        }

        private string GetUpdate(string key)
        {
            return ((TextBox)updateControls[key]).Text;
        }

        private DateTime GetDateUpdate(string key)
        {
            return ((DateTimePicker)updateControls[key]).Value;
        }

        private void btnRunInquiry_Click(object sender , EventArgs e)
        {
            try
            {
                DataTable table = null;

                switch (cmbInquiry.SelectedIndex)
                {
                    case 0:
                        table = db.GetMostTransportedCargoType();
                        break;

                    case 1:
                        table = db.GetVesselsWithoutVoyagesLastMonth();
                        break;

                    case 2:
                        table = db.GetTopCaptainLastMonth();
                        break;

                    case 3:
                        table = db.GetClientsWithoutShipmentsLastMonth();
                        break;

                    case 4:
                        table = db.GetContainersDockedAtPortsLastMonth();
                        break;

                    case 5:
                        table = db.GetVesselContainerTotalsLastMonth();
                        break;
                }

                dgvInquiry.DataSource = table;

                lblStatus.Text =
                    "Inquiry executed successfully";

                lblRecordCount.Text =
                    "Records: " + table.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}