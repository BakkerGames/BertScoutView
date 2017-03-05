using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.JSON;

namespace BertScoutView
{
    public partial class FormMain : Form
    {
        private int syncDBVersion = 21;
        private JSONObject allPit;
        private JSONObject allStand;
        private List<StandInfoItem> matches;

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

            // load allPit and allStand
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

            // load all pit info and save

            foreach (string fileName in Directory.GetFiles(filePath, "*_pit.json"))
            {
                JSONObject tempJO = JSONObject.FromString(File.ReadAllText($"{fileName}"));
                if (!tempJO.ContainsKey("dbversion") || (int)tempJO["dbversion"] < 21)
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

            // load all stand info and save

            foreach (string fileName in Directory.GetFiles(filePath, "*_stand.json"))
            {
                JSONObject tempJO = JSONObject.FromString(File.ReadAllText($"{fileName}"));
                if (!tempJO.ContainsKey("dbversion") || (int)tempJO["dbversion"] < 21)
                {
                    continue;
                }
                foreach (JSONObject currTeam in (JSONArray)tempJO["stand_data"])
                {
                    bool found = false;
                    foreach (JSONObject allStandTeam in (JSONArray)allStand["stand_data"])
                    {
                        if ((int)allStandTeam["match"] == (int)currTeam["match"] &&
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

            // fill team combobox

            comboBoxTeam.Items.Clear();

            foreach (JSONObject currMatchTeam in (JSONArray)allStand["stand_data"])
            {
                bool found = false;
                foreach (int tempTeam in comboBoxTeam.Items)
                {
                    if (tempTeam == (int)currMatchTeam["team"])
                    {
                        found = true;
                        continue;
                    }
                }
                if (!found)
                {
                    comboBoxTeam.Items.Add((int)currMatchTeam["team"]);
                }
            }

            // done with loading

            textBoxKindleFilePath.Enabled = false;
            buttonLoad.Enabled = false;
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeam.SelectedIndex < 0)
            {
                dataGridViewStand.DataSource = null;
                return;
            }
            matches = new List<StandInfoItem>();
            foreach (JSONObject currMatchTeam in (JSONArray)allStand["stand_data"])
            {
                if ((int)currMatchTeam["team"] != (int)comboBoxTeam.Items[comboBoxTeam.SelectedIndex])
                {
                    continue;
                }
                StandInfoItem info = new StandInfoItem();
                info.Match = (int)currMatchTeam["match"];
                info.Alliance = (string)currMatchTeam["alliance_red_blue"];
                info.AutoHigh = (int)currMatchTeam["auto_score_high"];
                info.AutoLow = (int)currMatchTeam["auto_score_low"];
                info.AutoBaseline = (bool)currMatchTeam["auto_base_line"];
                info.AutoOpenHopper = (bool)currMatchTeam["auto_open_hopper"];
                info.TeleHigh = (int)currMatchTeam["tele_score_high"];
                info.TeleLow = (int)currMatchTeam["tele_score_low"];
                info.GearsReceived = (int)currMatchTeam["tele_gears_received"];
                info.GearsPlaced = (int)currMatchTeam["tele_gears_placed"];
                info.Climbed = (bool)currMatchTeam["tele_climbed"];
                info.Touchpad = (bool)currMatchTeam["tele_touchpad"];
                info.Penalties = (int)currMatchTeam["tele_penalties"];
                info.ScoutName = (string)currMatchTeam["scout_name"];
                info.Comment = (string)currMatchTeam["stand_comment"];
                matches.Add(info);
            }
            dataGridViewStand.DataSource = matches;
            foreach (DataGridViewColumn column in dataGridViewStand.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

    }
}
