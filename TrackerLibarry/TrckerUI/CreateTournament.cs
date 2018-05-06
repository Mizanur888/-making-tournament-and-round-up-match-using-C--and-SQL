using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibarry;

namespace TrckerUI
{
    public partial class CreateTournament : Form, IPrizeRequester, ITeam_Requester
    {
        List<TeamModel> availableTeams = GlobalConfig.connection.GetTeam_All();
        List<TeamModel> selectedTeam = new List<TeamModel>();
        List<PrizeModel> selectedPrize = new List<PrizeModel>();
       
        public CreateTournament()
        {
            InitializeComponent();
            wireupList();
            
        }
        

        private void wireupList() {
            SelectTeamComboBox.DataSource = null;

            SelectTeamComboBox.DataSource = availableTeams;
            SelectTeamComboBox.DisplayMember = "TeamName";

            TournamentPlayerListBox.DataSource = null;
            TournamentPlayerListBox.DataSource = selectedTeam;
            TournamentPlayerListBox.DisplayMember = "TeamName";

            PrizeListBox.DataSource = null;
            PrizeListBox.DataSource = selectedPrize;
            PrizeListBox.DisplayMember = "Placename";

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t =(TeamModel) SelectTeamComboBox.SelectedItem;
            if (t != null) {

                availableTeams.Remove(t);
                selectedTeam.Add(t);
                wireupList();
            }


        }

        private void deleteSeletedTeamPlayeButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)TournamentPlayerListBox.SelectedItem;
            if (p != null)
            {
                selectedTeam.Remove(p);
                availableTeams.Add(p);
                wireupList();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            Create_Prize frm = new Create_Prize(this);
            frm.Show();
        }

        public void prizeComplete(PrizeModel model)
        {
            selectedPrize.Add(model);
            wireupList();
        }

        public void teamComplite(TeamModel model)
        {
            selectedTeam.Add(model);
            wireupList();
        }

        private void SelectTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Team frm = new Create_Team(this);
            frm.Show();
        }

        private void DeleteSletedPrizwButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizeListBox.SelectedItem;
            if (p != null)
            {
                selectedPrize.Remove(p);
                
                wireupList();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //first - create tournament model

            decimal fee = 0;
            bool feeAcceptable =decimal.TryParse(EntryFeeTextBox.Text, out fee);
            if (!feeAcceptable) {
                MessageBox.Show("Please Enter Valied Amount For Entry Fee ", "",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                return;
            }

           // List<TournamentModel> tm = new List<TournamentModel>();

            TournamentModel t = new TournamentModel();
             t.TournamentName = scoreTextBox.Text;
             t.EntreyFee = fee;

            t.Prizes = selectedPrize;
            t.EntredTeam = selectedTeam;

            //TODO - Wire our matchup
            TournamentLogic.CreateRound(t);
            GlobalConfig.connection.createTournamnet(t);
            //foreach (PrizeModel prize in selectedPrize) {

            //    t.Prizes.Add(prize);
            //}
            //create tournament Entery
            //create all of the prize enries
            //create all of the team entry

          




        }
    }
}
