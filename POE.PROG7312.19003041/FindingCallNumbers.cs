using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE.PROG7312._19003041
{
    public partial class FindingCallNumbers : Form
    {
        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            firstLevelList.Enabled = true;
            btnNextFirst.Visible = true;
            secondLevelList.Visible = false;
            btnNextSecond.Visible = false;
            thirdLevelList.Visible = false;
            btnSubmit.Visible = false;
            CallNumbers.LoadCallNums();
            answerLabel.Text = CallNumbers.myGoal;
            thirdLevelList.Items.Clear();
            secondLevelList.Items.Clear();
            firstLevelList.Items.Clear();
            foreach (string i in CallNumbers.firstLevelChoices)
            {
                firstLevelList.Items.Add(i);
            }
            foreach (string i in CallNumbers.secondLevelChoices)
            {
                secondLevelList.Items.Add(i);
            }
            foreach (string i in CallNumbers.thirdLevelChoices)
            {
                thirdLevelList.Items.Add(i);
            }
        }

        private void btnNextFirst_Click(object sender, EventArgs e)
        {
            if (firstLevelList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item :(");
            }
            else
            {
                if (firstLevelList.SelectedItem.Equals(CallNumbers.firstLevelAnswer))
                {
                    firstLevelList.Enabled = false;
                    btnNextFirst.Visible = false;
                    secondLevelList.Enabled = true;
                    secondLevelList.Visible = true;
                    btnNextSecond.Visible = true;

                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var correctResponses = new List<String> { "Congratulations! That is how it's done!", "You got it! Well Done!", "That is absolutely right! Good job!", "Very nice job! That's it!", "Nice Work! That's spot on!" };
                    int choice = rand.Next(correctResponses.Count);
                    String chosenCorrectResponse = correctResponses[choice];
                    WelcomeScreen.playerPoints += 5;
                    UpdatePoints();
                    MessageBox.Show(chosenCorrectResponse + "\n\nYou've been awarded 5 points.\n\nNow, choose the right category!", "Correct!", MessageBoxButtons.OK);
                }
                else
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                    int choice = rand.Next(incorrectResponses.Count);
                    String chosenIncorrectResponse = incorrectResponses[choice];
                    if (WelcomeScreen.playerPoints != 0)
                    {
                        WelcomeScreen.playerPoints -= 5;
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 points :(\nPlease try again.", "Incorrect.");
                        UpdatePoints();
                    }
                    else
                    {
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost points, but you're already at 0 :(\nPlease try again. You can do it!", "Incorrect.");
                    }
                    FindingCallNumbers_Load(sender, e);
                }
            }
        }

        private void btnNextSecond_Click(object sender, EventArgs e)
        {
            if (secondLevelList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item :(");
            }
            else
            {
                if (secondLevelList.SelectedItem.Equals(CallNumbers.secondLevelAnswer))
                {
                    secondLevelList.Enabled = false;
                    btnNextSecond.Visible = false;
                    thirdLevelList.Visible = true;
                    btnSubmit.Visible = true;
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var correctResponses = new List<String> { "Congratulations! That is how it's done!", "You got it! Well Done!", "That is absolutely right! Good job!", "Very nice job! That's it!", "Nice Work! That's spot on!" };
                    int choice = rand.Next(correctResponses.Count);
                    String chosenCorrectResponse = correctResponses[choice];
                    WelcomeScreen.playerPoints += 5;
                    UpdatePoints();
                    MessageBox.Show(chosenCorrectResponse + "\n\nYou've been awarded 5 points.\n\nNow, choose the final call number!", "Correct!", MessageBoxButtons.OK);
                }
                else
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                    int choice = rand.Next(incorrectResponses.Count);
                    String chosenIncorrectResponse = incorrectResponses[choice];
                    if (WelcomeScreen.playerPoints != 0)
                    {
                        WelcomeScreen.playerPoints -= 5;
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 points :(\nPlease try again.", "Incorrect.");
                        UpdatePoints();
                    }
                    else
                    {
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost points, but you're already at 0 :(\nPlease try again. You can do it!", "Incorrect.");
                    }
                    FindingCallNumbers_Load(sender, e);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (thirdLevelList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item :(");
            }
            else
            {
                if (thirdLevelList.SelectedItem.Equals(CallNumbers.thirdLevelAnswer.Substring(0, 3)))
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var correctResponses = new List<String> { "Congratulations! That is how it's done!", "You got it! Well Done!", "That is absolutely right! Good job!", "Very nice job! That's it!", "Nice Work! That's spot on!" };
                    int choice = rand.Next(correctResponses.Count);
                    String chosenCorrectResponse = correctResponses[choice];
                    WelcomeScreen.playerPoints += 10;
                    UpdatePoints();
                    DialogResult dialog = MessageBox.Show(chosenCorrectResponse + "\n\nYou've been awarded 10 points.\n\nWould you like to try another one?", "Correct!", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        FindingCallNumbers_Load(sender, e);
                    }
                    else
                    {
                        goBackToolStripMenuItem_Click(sender, e);
                    }
                }
                else
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                    int choice = rand.Next(incorrectResponses.Count);
                    String chosenIncorrectResponse = incorrectResponses[choice];
                    if (WelcomeScreen.playerPoints != 0)
                    {
                        WelcomeScreen.playerPoints -= 5;
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 points :(\nPlease try again.", "Incorrect.");
                        UpdatePoints();
                    }
                    else
                    {
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost points, but you're already at 0 :(\nPlease try again. You can do it!", "Incorrect.");
                    }
                    FindingCallNumbers_Load(sender, e);
                }
            }
        }

        private void UpdatePoints()
        {
            //Update the user points field
            pointsBar.Text = "Points: " + WelcomeScreen.playerPoints.ToString();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeScreen newWelcome = new WelcomeScreen();
            newWelcome.ShowDialog();
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}