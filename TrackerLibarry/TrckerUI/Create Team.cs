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
    public partial class Create_Team : Form
    {
        private List<personModel> abilableTeamMember = GlobalConfig.connection.GetPerson_All();
        private List<personModel> selectedTeamMember = new List<personModel>();
        ITeam_Requester callingFrom;
        public Create_Team(ITeam_Requester caller)
        {
            InitializeComponent();
            //Cratesampledata();
            this.callingFrom = caller;
            wireupList();
        }

        private void teamListData() {

           // abilableTeamMember = GlobalConfig.connection.GetPerson_All();

        }
        private void Cratesampledata() {

            abilableTeamMember.Add(new personModel { Fname = "mizanur", Lname = "rahman" });
            abilableTeamMember.Add(new personModel { Fname = "karla", Lname = "rahman" });

            selectedTeamMember.Add(new personModel { Fname = "tim", Lname = "corey" });
            selectedTeamMember.Add(new personModel { Fname = "john", Lname = "kerry" });

        }
        private void wireupList() {
            SelectTeamMemberComboBox.DataSource = null;

            SelectTeamMemberComboBox.DataSource = abilableTeamMember;
            SelectTeamMemberComboBox.DisplayMember = "Fullname";

            CreateTeamMemberListBox.DataSource = null;
            CreateTeamMemberListBox.DataSource = selectedTeamMember;
            CreateTeamMemberListBox.DisplayMember = "Fullname";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (validationFrom()) {

                personModel p = new personModel();
                p.Fname = FirstName1TextBox.Text;
                p.Lname = LastName1TextBox.Text;
                p.EmailAddress = EmailTextBox.Text;
                p.phoneNumber = CellPhoneTextBox.Text;

                GlobalConfig.connection.createPerson(p);
                selectedTeamMember.Add(p);
                wireupList();

                FirstName1TextBox.Text = "";
                LastName1TextBox.Text = "";
                EmailTextBox.Text = "";
                CellPhoneTextBox.Text = "";
            }
           else {

                MessageBox.Show("You need to fill in all the field");
            }
        }

        private bool validationFrom() {
            //TODO - add validation to the from
            if (FirstName1TextBox.Text.Length == 0) {
                return false;
            }
            if (LastName1TextBox.Text.Length==0) {
                return false;
            }

            if (EmailTextBox.Text.Length==0) {
                return false;
            }
            if (CellPhoneTextBox.Text.Length==0) {

                return false;
            }

            return true;
        }

        private void AddTeamMemberButton_Click(object sender, EventArgs e)
        {
            personModel p =(personModel) SelectTeamMemberComboBox.SelectedItem;
            if (p!=null) {
                abilableTeamMember.Remove(p);
                selectedTeamMember.Add(p);

                wireupList();
            }
        }

        private void deleteSeletedTeamMemberPlayeButton_Click(object sender, EventArgs e)
        {
            personModel p =(personModel) CreateTeamMemberListBox.SelectedItem;
            if (p!=null) {
                selectedTeamMember.Remove(p);
                abilableTeamMember.Add(p);
                wireupList();
            }
        }

        private void CreateTeamMemberButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = TeamMemberNameTextBox.Text;
            t.Teammember = selectedTeamMember;

            GlobalConfig.connection.createTeam(t);

            callingFrom.teamComplite(t);

            this.Close();
        }
    }
}
