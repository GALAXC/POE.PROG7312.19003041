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

        /// <summary>
        /// Things to be done on the load of the Finding Call Numbers form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            //Load points
            UpdatePoints();
            //Prepare UI
            firstLevelList.Enabled = true;
            btnNextFirst.Visible = true;
            secondLevelList.Visible = false;
            btnNextSecond.Visible = false;
            thirdLevelList.Visible = false;
            btnSubmit.Visible = false;
            //Load call numbers from file into tree and then into UI
            CallNumbers.LoadCallNums();
            //Load the quiz goal that the user must get to
            answerLabel.Text = CallNumbers.myGoal;
            //Prepare lists to add quiz options to UI for user to select
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

        /// <summary>
        /// Determine the answer that the user has selected and either restart the game or move them to the next section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextFirst_Click(object sender, EventArgs e)
        {
            //If nothing selected, error
            if (firstLevelList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item :(");
            }
            else
            {
                //Determine if the user selected the correct item
                if (firstLevelList.SelectedItem.Equals(CallNumbers.firstLevelAnswer))
                {
                    //Move UI to next section
                    firstLevelList.Enabled = false;
                    btnNextFirst.Visible = false;
                    secondLevelList.Enabled = true;
                    secondLevelList.Visible = true;
                    btnNextSecond.Visible = true;
                    //Display feedback to the user
                    //and give them points for getting it correct
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
                    //Display feedback to user when they get it wrong
                    //And subtract points
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                    int choice = rand.Next(incorrectResponses.Count);
                    String chosenIncorrectResponse = incorrectResponses[choice];
                    if (WelcomeScreen.playerPoints != 0)
                    {
                        WelcomeScreen.playerPoints -= 5;
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 points :(\nPlease try again.\n\nThe correct answer was: " + CallNumbers.firstLevelAnswer, "Incorrect.");
                        UpdatePoints();
                    }
                    else
                    {
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost points, but you're already at 0 :(\nPlease try again. You can do it!\n\nThe correct answer was: " + CallNumbers.firstLevelAnswer, "Incorrect.");
                    }
                    //Start the quiz again
                    FindingCallNumbers_Load(sender, e);
                }
            }
        }

        /// <summary>
        /// Determine the answer that the user has selected and either restart the game or move them to the next section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextSecond_Click(object sender, EventArgs e)
        {
            //If nothing selected, error
            if (secondLevelList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item :(");
            }
            else
            {
                if (secondLevelList.SelectedItem.Equals(CallNumbers.secondLevelAnswer))
                {
                    //Move UI to next section
                    secondLevelList.Enabled = false;
                    btnNextSecond.Visible = false;
                    thirdLevelList.Visible = true;
                    btnSubmit.Visible = true;
                    //Display feedback to the user
                    //and give them points for getting it correct
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
                    //Display feedback to user when they get it wrong
                    //And subtract points
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                    int choice = rand.Next(incorrectResponses.Count);
                    String chosenIncorrectResponse = incorrectResponses[choice];
                    if (WelcomeScreen.playerPoints != 0)
                    {
                        WelcomeScreen.playerPoints -= 5;
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 points :(\nPlease try again.\n\nThe correct answer was: " + CallNumbers.secondLevelAnswer, "Incorrect.");
                        UpdatePoints();
                    }
                    else
                    {
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost points, but you're already at 0 :(\nPlease try again. You can do it!\n\nThe correct answer was: " + CallNumbers.secondLevelAnswer, "Incorrect.");
                    }
                    //Start the quiz again
                    FindingCallNumbers_Load(sender, e);
                }
            }
        }

        /// <summary>
        /// Determine the answer that the user has selected and either restart the game or move them to the next section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //If nothing selected, error
            if (thirdLevelList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item :(");
            }
            else
            {
                if (thirdLevelList.SelectedItem.Equals(CallNumbers.thirdLevelAnswer.Substring(0, 3)))
                {
                    //Display feedback to the user
                    //and give them points for getting it correct
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var correctResponses = new List<String> { "Congratulations! That is how it's done!", "You got it! Well Done!", "That is absolutely right! Good job!", "Very nice job! That's it!", "Nice Work! That's spot on!" };
                    int choice = rand.Next(correctResponses.Count);
                    String chosenCorrectResponse = correctResponses[choice];
                    WelcomeScreen.playerPoints += 10;
                    UpdatePoints();
                    DialogResult dialog = MessageBox.Show(chosenCorrectResponse + "\n\nYou've been awarded 10 points.\n\nWould you like to try another one?", "Correct!", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        //Start quiz again
                        FindingCallNumbers_Load(sender, e);
                    }
                    else
                    {
                        //Go back to main menu
                        goBackToolStripMenuItem_Click(sender, e);
                    }
                }
                else
                {
                    //Display feedback to user when they get it wrong
                    //And subtract points
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                    int choice = rand.Next(incorrectResponses.Count);
                    String chosenIncorrectResponse = incorrectResponses[choice];
                    if (WelcomeScreen.playerPoints != 0)
                    {
                        WelcomeScreen.playerPoints -= 5;
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 points :(\nPlease try again.\n\nThe correct answer was: " + CallNumbers.thirdLevelAnswer, "Incorrect.");
                        UpdatePoints();
                    }
                    else
                    {
                        MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost points, but you're already at 0 :(\nPlease try again. You can do it!\n\nThe correct answer was: " + CallNumbers.thirdLevelAnswer, "Incorrect.");
                    }
                    //Start the quiz again
                    FindingCallNumbers_Load(sender, e);
                }
            }
        }

        //Method to update the points label when any changes
        private void UpdatePoints()
        {
            //Update the user points field
            pointsBar.Text = "Points: " + WelcomeScreen.playerPoints.ToString();
        }

        //Go back to main menu
        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeScreen newWelcome = new WelcomeScreen();
            newWelcome.ShowDialog();
            this.Close();
        }

        //Close the program
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}