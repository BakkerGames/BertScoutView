using Common.JSON;
using System;
using System.IO;
using System.Windows.Forms;

namespace BertScoutView
{
    public partial class FormMain : Form
    {
        private int syncDBVersion = 24;

        private JSONObject allPit;
        private JSONObject allStand;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxKindleFilePath.Text = Properties.Settings.Default.KindleFilePath;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string filePath = textBoxKindleFilePath.Text;
            if (string.IsNullOrEmpty(filePath) || !Directory.Exists(filePath))
            {
                return;
            }

            LoadStandPitInfo(filePath);

            // fill team combobox

            FillTeamComboBox();

            // done with loading

            textBoxKindleFilePath.Enabled = false;
            buttonLoad.Enabled = false;
            comboBoxTeam.Enabled = true;
            buttonShowPitInfo.Enabled = true;
            buttonShowPicture.Enabled = true;
            dataGridViewStand.Enabled = true;
            comboBoxTeam.Focus();

        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeam.SelectedIndex < 0)
            {
                dataGridViewStand.DataSource = null;
                return;
            }
            FillGrid();
        }

        private void LoadStandPitInfo(string filePath)
        {

            // load all pit info and save

            if (File.Exists($"{filePath}\\allpit.json"))
            {
                allPit = JSONObject.FromString(File.ReadAllText($"{filePath}\\allpit.json"));
            }
            else
            {
                allPit = new JSONObject();
                allPit["dbversion"] = syncDBVersion;
                allPit["pit_data"] = new JSONArray();
            }

            foreach (string fileName in Directory.GetFiles(filePath, "*_pit.json"))
            {
                JSONObject tempJO = JSONObject.FromString(File.ReadAllText($"{fileName}"));
                if (!tempJO.ContainsKey("dbversion") || (int)tempJO["dbversion"] < syncDBVersion)
                {
                    continue;
                }
                foreach (JSONObject currTeam in (JSONArray)tempJO["pit_data"])
                {
                    bool found = false;
                    foreach (JSONObject allPitTeam in ((JSONArray)allPit["pit_data"]))
                    {
                        if ((int)allPitTeam["team"] == (int)currTeam["team"] &&
                            allPitTeam["scout_name"].ToString() == currTeam["scout_name"].ToString())
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        ((JSONArray)allPit["pit_data"]).Add(currTeam);
                    }
                }
            }
            File.WriteAllText($"{filePath}\\allpit.json", allPit.ToString());

            ConvertToCSV.OutputCSV($"{filePath}\\allpit.json", $"{filePath}\\allpit.csv");

            // load all stand info and save

            if (File.Exists($"{filePath}\\allstand.json"))
            {
                allStand = JSONObject.FromString(File.ReadAllText($"{filePath}\\allstand.json"));
            }
            else
            {
                allStand = new JSONObject();
                allStand["dbversion"] = syncDBVersion;
                allStand["stand_data"] = new JSONArray();
            }

            foreach (string fileName in Directory.GetFiles(filePath, "*_stand.json"))
            {
                JSONObject tempJO = JSONObject.FromString(File.ReadAllText($"{fileName}"));
                if (!tempJO.ContainsKey("dbversion") || (int)tempJO["dbversion"] < syncDBVersion)
                {
                    continue;
                }
                foreach (JSONObject currTeam in (JSONArray)tempJO["stand_data"])
                {
                    bool found = false;
                    foreach (JSONObject allStandTeam in (JSONArray)allStand["stand_data"])
                    {
                        if ((int)allStandTeam["match_no"] == (int)currTeam["match_no"] &&
                            (int)allStandTeam["team"] == (int)currTeam["team"] &&
                            allStandTeam["scout_name"].ToString() == currTeam["scout_name"].ToString())
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        ((JSONArray)allStand["stand_data"]).Add(currTeam);
                    }
                }
            }
            File.WriteAllText($"{filePath}\\allstand.json", allStand.ToString());

            ConvertToCSV.OutputCSV($"{filePath}\\allstand.json", $"{filePath}\\allstand.csv");

        }

        private void FillTeamComboBox()
        {

            comboBoxTeam.Items.Clear();

            foreach (JSONObject currMatchTeam in (JSONArray)allStand["stand_data"])
            {
                bool found = false;
                foreach (string tempTeam in comboBoxTeam.Items)
                {
                    if (tempTeam == GetTeamPadded((int)currMatchTeam["team"]))
                    {
                        found = true;
                        continue;
                    }
                }
                if (!found)
                {
                    comboBoxTeam.Items.Add(GetTeamPadded((int)currMatchTeam["team"]));
                }
            }

            foreach (JSONObject currTeam in (JSONArray)allPit["pit_data"])
            {
                bool found = false;
                foreach (string tempTeam in comboBoxTeam.Items)
                {
                    if (tempTeam == GetTeamPadded((int)currTeam["team"]))
                    {
                        found = true;
                        continue;
                    }
                }
                if (!found)
                {
                    comboBoxTeam.Items.Add(GetTeamPadded((int)currTeam["team"]));
                }
            }

        }

        private string GetTeamPadded(int teamNumber)
        {
            string result = teamNumber.ToString().PadLeft(5);
            return result;
        }

        private void FillGrid()
        {
            dataGridViewStand.Rows.Clear();


            //matches = new List<StandInfoItem>();
            foreach (JSONObject currMatchTeam in (JSONArray)allStand["stand_data"])
            {
                if (GetTeamPadded((int)currMatchTeam["team"]) !=
                    (string)comboBoxTeam.Items[comboBoxTeam.SelectedIndex])
                {
                    continue;
                }
                dataGridViewStand.Rows.Add();
                int row = dataGridViewStand.Rows.Count - 1;
                dataGridViewStand.Rows[row].Cells["Match"].Value = (int)currMatchTeam["match_no"];
                dataGridViewStand.Rows[row].Cells["Alliance"].Value = (string)currMatchTeam["alliance_red_blue"];
                dataGridViewStand.Rows[row].Cells["AutoScoreHigh"].Value = (int)currMatchTeam["auto_score_high"];
                dataGridViewStand.Rows[row].Cells["AutoScoreLow"].Value = (int)currMatchTeam["auto_score_low"];
                dataGridViewStand.Rows[row].Cells["AutoBaseline"].Value = (bool)currMatchTeam["auto_base_line"];
                dataGridViewStand.Rows[row].Cells["AutoOpenHopper"].Value = (bool)currMatchTeam["auto_open_hopper"];
                dataGridViewStand.Rows[row].Cells["TeleScoreHigh"].Value = (int)currMatchTeam["tele_score_high"];
                dataGridViewStand.Rows[row].Cells["TeleScoreLow"].Value = (int)currMatchTeam["tele_score_low"];
                dataGridViewStand.Rows[row].Cells["TeleGearsPlaced"].Value = (int)currMatchTeam["tele_gears_placed"];
                dataGridViewStand.Rows[row].Cells["TeleClimbed"].Value = (bool)currMatchTeam["tele_climbed"];
                dataGridViewStand.Rows[row].Cells["TeleTouchpad"].Value = (bool)currMatchTeam["tele_touchpad"];
                dataGridViewStand.Rows[row].Cells["Comment"].Value = (string)currMatchTeam["stand_comment"];
                dataGridViewStand.Rows[row].Cells["ScoutName"].Value = (string)currMatchTeam["scout_name"];
            }
            dataGridViewStand.Sort(dataGridViewStand.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void buttonShowPitInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxTeam.SelectedIndex < 0)
            {
                return;
            }
            string teamNum = ((string)comboBoxTeam.Items[comboBoxTeam.SelectedIndex]).Trim();
            string filePath = textBoxKindleFilePath.Text;
            string pixPath = $"{filePath}\\{teamNum}.jpg";
            FormTeamPit pitForm;
            foreach (JSONObject currTeam in (JSONArray)allPit["pit_data"])
            {
                if (((int)currTeam["team"]).ToString() == teamNum)
                {
                    pitForm = new FormTeamPit(currTeam, pixPath);
                    pitForm.ShowDialog();
                    return;
                }
            }
            pitForm = new FormTeamPit(null, pixPath);
            pitForm.ShowDialog();
        }

        private void buttonShowPicture_Click(object sender, EventArgs e)
        {
            if (comboBoxTeam.SelectedIndex < 0)
            {
                return;
            }
            string filePath = textBoxKindleFilePath.Text;
            string teamNum = ((string)comboBoxTeam.Items[comboBoxTeam.SelectedIndex]).Trim();
            string pixPath = $"{filePath}\\{teamNum}.jpg";
            FormTeamPix pixForm = new FormTeamPix(pixPath);
            pixForm.ShowDialog();
            return;
        }
    }
}
