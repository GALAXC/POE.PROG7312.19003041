using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2.PROG7312._19003041
{
    public partial class IdentifyingAreas : Form
    {
        private ListViewItem clickedBookItem;
        private ListViewItem clickedDescItem;
        private Point originalPoint;
        private ImageList imageList = new ImageList();
        private Dictionary<int, string> callDictionary = new Dictionary<int, string>();

        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        //Load images and Call numbers with descriptions on load of form
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            UpdatePoints();
            if (WelcomeScreen.callDesc)
            {
                WelcomeScreen.callDesc = false;
                descList.Cursor = Cursors.Hand;
                bookList.Cursor = Cursors.No;
                descriptionLabel.Text = "Match the descriptions below to the correct call numbers on the books to the left.\n\n" +
                    "Drag the descriptions to the relevant number of the book you are matching it to.\n\n" +
                    "Good luck!";
            }
            else
            {
                WelcomeScreen.callDesc = true;
                bookList.Cursor = Cursors.Hand;
                descList.Cursor = Cursors.No;
                descriptionLabel.Text = "Match the call numbers on the books to the left with the correct descriptions given below\n\n" +
                    "Drag the books to the relevant number of the description you are matching it to.\n\n" +
                    "Good luck!";
            }
            AddBookImages();
            AddCallDescriptions();
            PopulateCallNumbers();
            PopulateDescriptions();
        }

        public void AddCallDescriptions()
        {
            callDictionary.Add(99, "Computer science, information and general works");
            callDictionary.Add(199, "Philosophy and psychology");
            callDictionary.Add(299, "Religion");
            callDictionary.Add(399, "Social sciences");
            callDictionary.Add(499, "Language");
            callDictionary.Add(599, "Pure Science");
            callDictionary.Add(699, "Technology");
            callDictionary.Add(799, "Arts and recreation");
            callDictionary.Add(899, "Literature");
            callDictionary.Add(999, "History and geography");
        }

        public int GenerateDeweyTopLevel()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int firstDew = random.Next(1000);
            if (firstDew == 0)
            {
                firstDew = random.Next(1000);
            }
            return firstDew;
        }

        public void PopulateCallNumbers()
        {
            var bookColours = new List<String> { "blueBook", "purpleBook", "orangeBook", "lightOrangeBook" };
            for (int i = 0; i < 7; i++)
            {
                bookList.Items[i].Text = (GenerateDeweyTopLevel().ToString());
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int choice = rand.Next(bookColours.Count);
                String bookColourChoice = bookColours[choice];
                bookList.Items[i].ImageKey = bookColourChoice;
            }
        }

        private void PopulateDescriptions()
        {
            for (int i = 0; i < bookList.Items.Count; i++)
            {
                for (int j = 0; j < callDictionary.Count; j++)
                {
                    int tempCall = Convert.ToInt32(bookList.Items[i].Text);
                    switch (tempCall)
                    {
                        case int n when n <= 99:
                            descList.Items[i].Text = callDictionary[99];
                            goto exitInsideLoop;

                        case int n when n <= 199:
                            descList.Items[i].Text = callDictionary[199];
                            goto exitInsideLoop;

                        case int n when n <= 299:
                            descList.Items[i].Text = callDictionary[299];
                            goto exitInsideLoop;

                        case int n when n <= 399:
                            descList.Items[i].Text = callDictionary[399];
                            goto exitInsideLoop;

                        case int n when n <= 499:
                            descList.Items[i].Text = callDictionary[499];
                            goto exitInsideLoop;

                        case int n when n <= 599:
                            descList.Items[i].Text = callDictionary[599];
                            goto exitInsideLoop;

                        case int n when n <= 699:
                            descList.Items[i].Text = callDictionary[699];
                            goto exitInsideLoop;

                        case int n when n <= 799:
                            descList.Items[i].Text = callDictionary[799];
                            goto exitInsideLoop;

                        case int n when n <= 899:
                            descList.Items[i].Text = callDictionary[899];
                            goto exitInsideLoop;

                        case int n when n <= 999:
                            descList.Items[i].Text = callDictionary[999];
                            goto exitInsideLoop;
                    }
                }
            exitInsideLoop:;
            }
            List<string> tempDescList = new List<string>();
            List<string> tempBookList = new List<string>();
            foreach (ListViewItem item in descList.Items)
            {
                tempDescList.Add(item.Text);
                Shuffle(tempDescList);
            }
            foreach (ListViewItem item in bookList.Items)
            {
                tempBookList.Add(item.Text);
                Shuffle(tempBookList);
            }

            for (int i = 0; i < 7; i++)
            {
                bookList.Items[i].Text = tempBookList[i];
                descList.Items[i].Text = tempDescList[i];
            }
            if (WelcomeScreen.callDesc)
            {
                for (int i = 0; i < 3; i++)
                {
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    int k = rnd.Next(7);
                    while (bookList.Items[k].Text.Equals(""))
                    {
                        k = rnd.Next(7);
                    }
                    bookList.Items[k].Text = "";
                }
                for (int i = 0; i < 7; i++)
                {
                    if (bookList.Items[i].Text.Equals(""))
                    {
                        bookList.Items[i].ImageKey = "noBook";
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    int k = rnd.Next(7);
                    while (descList.Items[k].Text.Equals("--------------------"))
                    {
                        k = rnd.Next(7);
                    }
                    descList.Items[k].Text = "--------------------";
                }
            }
        }

        public void AddBookImages()
        {
            imageList.Images.Add("blueBook", Properties.Resources.BookBlue);
            imageList.Images.Add("orangeBook", Properties.Resources.BookOrange);
            imageList.Images.Add("lightOrangeBook", Properties.Resources.BookLightOrange);
            imageList.Images.Add("purpleBook", Properties.Resources.BookPurple);
            imageList.Images.Add("noBook", Properties.Resources.NoBook);
            int imageHeight = 57;
            imageList.ImageSize = new Size(Convert.ToInt32(imageHeight / 0.32), imageHeight);
            bookList.SmallImageList = imageList;

            /*
            bookList.Items[0].ImageKey = "blueBook";
            bookList.Items[1].ImageKey = "noBook";
            bookList.Items[2].ImageKey = "purpleBook";
            bookList.Items[3].ImageKey = "noBook";
            bookList.Items[4].ImageKey = "orangeBook";
            bookList.Items[5].ImageKey = "noBook";
            bookList.Items[6].ImageKey = "lightOrangeBook";
            */
        }

        //MouseDown event handler for bookList
        private void bookList_MouseDown(object sender, MouseEventArgs e)
        {
            if (WelcomeScreen.callDesc)
            {
                bookList.AutoArrange = false;
                clickedBookItem = bookList.GetItemAt(e.X, e.Y);
                if (clickedBookItem == null)
                {
                    return;
                }

                originalPoint = new Point(e.X, e.Y);
                if (clickedBookItem != null)
                {
                    //droppedPoint = new Point(e.X - clickedItem.Position.X,
                    //                          e.Y - clickedItem.Position.Y);
                }
            }
        }

        //MouseDown event handler for descList
        private void descList_MouseDown(object sender, MouseEventArgs e)
        {
            if (!WelcomeScreen.callDesc)
            {
                descList.AutoArrange = false;
                clickedDescItem = descList.GetItemAt(e.X, e.Y);
                if (clickedDescItem == null)
                {
                    return;
                }

                originalPoint = new Point(e.X, e.Y);
                if (clickedDescItem != null)
                {
                    //droppedPoint = new Point(e.X - clickedItem.Position.X,
                    //                          e.Y - clickedItem.Position.Y);
                }
            }
        }

        //MouseMove event handler for bookList
        private void bookList_MouseMove(object sender, MouseEventArgs e)
        {
            if (WelcomeScreen.callDesc)
            {
                if (clickedBookItem != null)
                {
                    Cursor = Cursors.Hand;
                    clickedBookItem.Position = new Point(0, e.Y);
                }
            }
        }

        //MouseMove event handler for descList
        private void descList_MouseMove(object sender, MouseEventArgs e)
        {
            if (!WelcomeScreen.callDesc)
            {
                if (clickedDescItem != null)
                {
                    Cursor = Cursors.Hand;
                    clickedDescItem.Position = new Point(0, e.Y);
                }
            }
        }

        //MouseUp event handler for bookList
        private void bookList_MouseUp(object sender, MouseEventArgs e)
        {
            if (WelcomeScreen.callDesc)
            {
                //clickedItem.Position = originalPoint;
                ListViewItem itemAtMovedLocation = bookList.GetItemAt(0, e.Y);

                if (clickedBookItem == null)
                {
                    ReorderList(bookList);
                    return;
                }

                if (itemAtMovedLocation == null)
                {
                    if (e.Y > imageList.ImageSize.Height + 1)
                    {
                        bookList.Items.Remove(clickedBookItem);
                        bookList.Items.Insert(bookList.Items.Count, clickedBookItem);
                    }
                    ReorderList(bookList);
                    return;
                }

                Rectangle rect = itemAtMovedLocation.GetBounds(ItemBoundsPortion.Entire);

                // find out if we insert before or after the item the mouse is over
                bool insertBefore;
                if (e.Y < rect.Top + (rect.Height / 2))
                    insertBefore = true;
                else
                    insertBefore = false;
                if (clickedBookItem != itemAtMovedLocation)
                // if we dropped the item on itself, nothing is to be done
                {
                    if (insertBefore)
                    {
                        bookList.Items.Remove(clickedBookItem);
                        bookList.Items.Insert(itemAtMovedLocation.Index, clickedBookItem);
                    }
                    else
                    {
                        bookList.Items.Remove(clickedBookItem);
                        bookList.Items.Insert(itemAtMovedLocation.Index + 1, clickedBookItem);
                    }
                }

                ReorderList(bookList);
                bookList.AutoArrange = true;
                //clickedItem = null;

                Cursor = Cursors.Default;

                //DisplayOrder(bookList);
            }
        }

        //MouseUp event handler for descList
        private void descList_MouseUp(object sender, MouseEventArgs e)
        {
            if (!WelcomeScreen.callDesc)
            {
                //clickedItem.Position = originalPoint;
                ListViewItem itemAtMovedLocation = descList.GetItemAt(0, e.Y);

                if (clickedDescItem == null)
                {
                    ReorderList(descList);
                    return;
                }

                if (itemAtMovedLocation == null)
                {
                    if (e.Y > imageList.ImageSize.Height + 1)
                    {
                        descList.Items.Remove(clickedDescItem);
                        descList.Items.Insert(descList.Items.Count, clickedDescItem);
                    }
                    ReorderList(descList);
                    return;
                }

                Rectangle rect = itemAtMovedLocation.GetBounds(ItemBoundsPortion.Entire);

                // find out if we insert before or after the item the mouse is over
                bool insertBefore;
                if (e.Y < rect.Top + (rect.Height / 2))
                    insertBefore = true;
                else
                    insertBefore = false;
                if (clickedDescItem != itemAtMovedLocation)
                // if we dropped the item on itself, nothing is to be done
                {
                    if (insertBefore)
                    {
                        descList.Items.Remove(clickedDescItem);
                        descList.Items.Insert(itemAtMovedLocation.Index, clickedDescItem);
                    }
                    else
                    {
                        descList.Items.Remove(clickedDescItem);
                        descList.Items.Insert(itemAtMovedLocation.Index + 1, clickedDescItem);
                    }
                }

                ReorderList(descList);
                descList.AutoArrange = true;
                //clickedItem = null;

                Cursor = Cursors.Default;

                //DisplayOrder(descList);
            }
        }

        //REMOVE AFTER TESTING IS COMPLETE
        //REMOVE AFTER TESTING IS COMPLETE

        //Temporarily display the order of the books in a message box
        private void DisplayOrder(ListView list)
        {
            String myOrder = "";
            for (int i = 0; i < list.Items.Count; i++)
            {
                myOrder += " " + list.Items[i].Text;
            }
            MessageBox.Show(myOrder);
        }

        //REMOVE AFTER TESTING IS COMPLETE
        //REMOVE AFTER TESTING IS COMPLETE

        private void ReorderList(ListView list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                bookList.Items[i].Position = new Point(0, 0 + (i * imageList.ImageSize.Height));
            }
        }

        //Back Toolstrip
        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeScreen newWelcome = new WelcomeScreen();
            newWelcome.ShowDialog();
            this.Close();
        }

        //Close Toolstrip
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            CompareAnswer();
        }

        private void CompareAnswer()
        {
            bool listCorrect = true;
            if (WelcomeScreen.callDesc)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (!bookList.Items[i].Text.Equals(""))
                    {
                        int callNum = Convert.ToInt32(bookList.Items[i].Text);
                        int tempNum = 0;
                        switch (callNum)
                        {
                            case int n when n <= 99:
                                tempNum = 99;
                                goto exitSwitch;

                            case int n when n <= 199:
                                tempNum = 199;
                                goto exitSwitch;

                            case int n when n <= 299:
                                tempNum = 299;
                                goto exitSwitch;

                            case int n when n <= 399:
                                tempNum = 399;
                                goto exitSwitch;

                            case int n when n <= 499:
                                tempNum = 499;
                                goto exitSwitch;

                            case int n when n <= 599:
                                tempNum = 599;
                                goto exitSwitch;

                            case int n when n <= 699:
                                tempNum = 699;
                                goto exitSwitch;

                            case int n when n <= 799:
                                tempNum = 799;
                                goto exitSwitch;

                            case int n when n <= 899:
                                tempNum = 899;
                                goto exitSwitch;

                            case int n when n <= 999:
                                tempNum = 999;
                                goto exitSwitch;
                        }
                    exitSwitch:;
                        if (!descList.Items[i].Text.Equals(callDictionary[tempNum]))
                        {
                            listCorrect = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    if (!descList.Items[i].Text.Equals("--------------------"))
                    {
                        int callNum = Convert.ToInt32(bookList.Items[i].Text);
                        int tempNum = 0;
                        switch (callNum)
                        {
                            case int n when n <= 99:
                                tempNum = 99;
                                goto exitSwitch;

                            case int n when n <= 199:
                                tempNum = 199;
                                goto exitSwitch;

                            case int n when n <= 299:
                                tempNum = 299;
                                goto exitSwitch;

                            case int n when n <= 399:
                                tempNum = 399;
                                goto exitSwitch;

                            case int n when n <= 499:
                                tempNum = 499;
                                goto exitSwitch;

                            case int n when n <= 599:
                                tempNum = 599;
                                goto exitSwitch;

                            case int n when n <= 699:
                                tempNum = 699;
                                goto exitSwitch;

                            case int n when n <= 799:
                                tempNum = 799;
                                goto exitSwitch;

                            case int n when n <= 899:
                                tempNum = 899;
                                goto exitSwitch;

                            case int n when n <= 999:
                                tempNum = 999;
                                goto exitSwitch;
                        }
                    exitSwitch:;
                        if (!descList.Items[i].Text.Equals(callDictionary[tempNum]))
                        {
                            listCorrect = false;
                        }
                    }
                }
            }
            //If incorrect, pick from a pool of "incorrect" responses and display to user with encouragement message
            if (!listCorrect)
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
            }
            else
            {
                //If the order is correct, pick from a pool of "correct" reponses and allow the user to try again or go back to main menu
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                var correctResponses = new List<String> { "Congratulations! That is how it's done!", "You got it! Well Done!", "That is absolutely right! Good job!", "Very nice job! That's it!", "Nice Work! That's spot on!" };
                int choice = rand.Next(correctResponses.Count);
                String chosenCorrectResponse = correctResponses[choice];
                WelcomeScreen.playerPoints += 20;
                UpdatePoints();
                DialogResult dialog = MessageBox.Show(chosenCorrectResponse + "\n\nYou've been awarded 20 points.\n\nWould you like to try another one?", "Correct!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    IdentifyingAreas newIdentifyingAreas = new IdentifyingAreas();
                    newIdentifyingAreas.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    WelcomeScreen newWelcome = new WelcomeScreen();
                    newWelcome.ShowDialog();
                    this.Close();
                }
            }
        }

        public static void Shuffle(List<string> list)
        {
            Random myRand = new Random(Guid.NewGuid().GetHashCode());
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = myRand.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void UpdatePoints()
        {
            //Update the user points field
            pointsBar.Text = "Points: " + WelcomeScreen.playerPoints.ToString();
        }

        private void btnSwitchGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            IdentifyingAreas newIdentifyingAreas = new IdentifyingAreas();
            newIdentifyingAreas.ShowDialog();
            this.Close();
        }
    }
}