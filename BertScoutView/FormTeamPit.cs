using Common.JSON;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BertScoutView
{
    public partial class FormTeamPit : Form
    {
        JSONObject team = null;
        string picPath = null;

        public FormTeamPit()
        {
            InitializeComponent();
        }

        public FormTeamPit(JSONObject currTeam, string path)
        {
            InitializeComponent();
            team = currTeam;
            picPath = path;
            ShowTeamInfo();
        }

        private void ShowTeamInfo()
        {
            // fill in fields here

            if (team != null)
            {
                labelTeamNumberValue.Text = team["team"].ToString();
                labelNameValue.Text = team["team_name"].ToString();
                labelYearsValue.Text = team["team_years"].ToString();
                labelHeightValue.Text = team["height"].ToString();
                labelWeightValue.Text = team["weight"].ToString();
                labelNumCimsValue.Text = team["num_cims"].ToString();
                labelMaxSpeedValue.Text = team["max_speed"].ToString();
                labelWheelTypeValue.Text = team["wheel_type"].ToString();
                labelWheelLayoutValue.Text = team["wheel_layout"].ToString();
                labelMaxFuelValue.Text = team["max_fuel"].ToString();
                labelShootSpeedValue.Text = team["shoot_speed"].ToString();
                labelShootLocationValue.Text = team["shoot_location"].ToString();
                labelCanShootHighValue.Text = team["can_shoot_high"].ToString();
                labelCanShootLowValue.Text = team["can_shoot_low"].ToString();
                //labelFloorPickupFuelValue.Text = team["floor_pickup_fuel"].ToString();
                labelTopLoadFuelValue.Text = team["top_loader"].ToString();
                labelVisionSensorValue.Text = team["auto_aim"].ToString();
                labelCanCarryGearValue.Text = team["can_carry_gear"].ToString();
                //labelFloorPickupGearValue.Text = team["floor_pickup_gear"].ToString();
                labelCanClimbValue.Text = team["can_climb"].ToString();
                labelUseOwnRopeValue.Text = team["own_rope"].ToString();

                StringBuilder startLoc = new StringBuilder();
                if ((bool)team["start_left"] == true)
                {
                    startLoc.Append("Boiler");
                }
                if ((bool)team["start_center"] == true)
                {
                    if (startLoc.Length > 0)
                    {
                        startLoc.Append(", ");
                    }
                    startLoc.Append("Center");
                }
                if ((bool)team["start_right"] == true)
                {
                    if (startLoc.Length > 0)
                    {
                        startLoc.Append(", ");
                    }
                    startLoc.Append("Non-Boiler");
                }
                labelStartingLocationsValue.Text = startLoc.ToString();

                labelAutoModesValue.Text = team["auto_num_modes"].ToString();
                labelAutoCrossBaselineValue.Text = team["auto_base_line"].ToString();
                labelAutoPlaceGearValue.Text = team["auto_place_gear"].ToString();
                labelAutoHighGoalValue.Text = team["auto_high_goal"].ToString();
                labelAutoLowGoalValue.Text = team["auto_low_goal"].ToString();
                labelAutoOpenHopperValue.Text = team["auto_hopper"].ToString();
                labelRatingValue.Text = team["team_rating"].ToString();
                labelCommentsValue.Text = team["comment"].ToString();
                labelScoutNameValue.Text = team["scout_name"].ToString();
            }

            // show team picture

            if (File.Exists(picPath))
            {
                Image pix = Image.FromFile(picPath);
                pictureBoxTeam.Image = pix;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
