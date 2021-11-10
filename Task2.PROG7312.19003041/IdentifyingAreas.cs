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
            return firstDew;
        }

        public void PopulateCallNumbers()
        {
            for (int i = 0; i < 7; i++)
            {
                bookList.Items[i].Text = (GenerateDeweyTopLevel().ToString());
            }
            if (WelcomeScreen.callDesc)
            {

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
                            descList.Items[i].ToolTipText = callDictionary[99];
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

        //Load images and Call numbers with descriptions on load of form
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            if (WelcomeScreen.callDesc)
            {
                WelcomeScreen.callDesc = false;
                descList.Cursor = Cursors.Hand;
                bookList.Cursor = Cursors.No;
            }
            else
            {
                WelcomeScreen.callDesc = true;
                bookList.Cursor = Cursors.Hand;
                descList.Cursor = Cursors.No;
            }
            AddBookImages();
            AddCallDescriptions();
            PopulateCallNumbers();
            PopulateDescriptions();
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
    }
}