using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace POE.PROG7312._19003041
{
    public class CallNumbers
    {
        public static List<string> thirdLevels = new List<string>();
        public static List<string> secondLevels = new List<string>();
        public static List<string> firstLevels = new List<string>();
        public static Random myRand = new Random();
        public static string myAnswer = "";
        public static string myGoal = "";
        public static string firstLevelAnswer = "";
        public static List<string> thirdLevelChoices = new List<string>();
        public static List<string> secondLevelChoices = new List<string>();
        public static List<string> firstLevelChoices = new List<string>();
        public static string thirdLevelAnswer = "";
        public static string secondLevelAnswer = "";
        public static string finalAnswer = "";

        public static void LoadCallNums()
        {
            //Instantiate the path of the text file with call numbers inside
            string myPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Resources\CallNumbers.txt"));
            string[] txtFile;
            //Check if the file exists
            if (!File.Exists(myPath))
            {
                //Error
                MessageBox.Show("Call number text file was not found.");
            }
            else
            {
                txtFile = File.ReadAllLines(myPath);
                string totalTree = "";
                //Convert file lines to format readable by tree building method
                foreach (string s in txtFile)
                {
                    totalTree += s;
                }
                //Build the tree based on lines from file
                TreeNode tree = TreeNode.BuildTree(txtFile);
                //Generate a random answer for the user to guess
                SelectRandomAnswer(tree);
                //Obscure the answer by removing the call number
                myGoal = thirdLevelAnswer.Substring(4, thirdLevelAnswer.Length - 4);
                ////Determine call number for final choice box
                //finalAnswer = myAnswer.Substring(0, 3);
                ////Add answer to list of possible final answers
                //thirdLevelChoices.Clear();
                //secondLevelChoices.Clear();
                //firstLevelChoices.Clear();
                //thirdLevelChoices.Add(finalAnswer);
                //for (int i = 0; i < 3; i++)
                //{
                //    Random theRand = new Random(Guid.NewGuid().GetHashCode());
                //    int choice = theRand.Next(thirdLevels.Count);

                //    if (myAnswer.Equals(thirdLevels[choice]))
                //    {
                //        i--;
                //    }
                //    else
                //    {
                //        thirdLevelChoices.Add(thirdLevels[choice].Substring(0, 3));
                //        PopulateWrongChoices(tree, thirdLevels[choice]);
                //    }
                //}
                //thirdLevelChoices.Sort();

                //foreach (TreeNode t in tree)
                //{
                //    foreach (TreeNode t1 in t)
                //    {
                //        try
                //        {
                //            if (t1.GetChild(myAnswer).ID.Equals(myAnswer))
                //            {
                //                secondLevelAnswer = t1.ID;
                //                firstLevelAnswer = t1.Parent.ID;
                //            }
                //        }
                //        catch (KeyNotFoundException e)
                //        {
                //            Console.WriteLine(e.Message);
                //            Console.WriteLine(t1.ID);
                //            //break;
                //        }
                //        catch (Exception e)
                //        {
                //            MessageBox.Show(e.Message);
                //        }
                //    }
                //}
                //secondLevelChoices.Add(secondLevelAnswer);
                //firstLevelChoices.Add(firstLevelAnswer);
                //secondLevelChoices.Sort();
                //firstLevelChoices.Sort();
            }
        }

        private static void PopulateWrongChoices(TreeNode tree, String childID)
        {
            foreach (TreeNode tree1 in tree)
            {
                foreach (TreeNode tree2 in tree1)
                {
                    try
                    {
                        if (tree2.GetChild(childID).ID.Equals(childID))
                        {
                            secondLevelChoices.Add(tree2.ID);
                            firstLevelChoices.Add(tree2.Parent.ID);
                        }
                    }
                    catch (KeyNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(tree2.ID);
                        //break;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private static void SelectRandomAnswer(TreeNode tree)
        {
            //Load items from tree
            firstLevels.Clear();
            secondLevels.Clear();
            thirdLevels.Clear();
            foreach (TreeNode tree1 in tree)
            {
                firstLevels.Add(tree1.ID);
                foreach (TreeNode tree2 in tree1)
                {
                    secondLevels.Add(tree2.ID);
                    foreach (TreeNode tree3 in tree2)
                    {
                        thirdLevels.Add(tree3.ID);
                    }
                }
            }
            firstLevelChoices.Clear();
            secondLevelChoices.Clear();
            thirdLevelChoices.Clear();
            //Randomly choose first level answer
            int choice = myRand.Next(firstLevels.Count);
            firstLevelAnswer = firstLevels[choice];
            firstLevelChoices.Add(firstLevelAnswer);
            //Add random first level choices that aren't answers
            for (int i = 0; i < 3; i++)
            {
                Random theRand = new Random(Guid.NewGuid().GetHashCode());
                int randomChoice = theRand.Next(firstLevels.Count);

                if (!firstLevels[randomChoice].Equals(firstLevelAnswer) && !firstLevelChoices.Contains(firstLevels[randomChoice]))
                {
                    firstLevelChoices.Add(firstLevels[randomChoice]);
                }
                else
                {
                    i--;
                }
            }
            //Randomly choose second level answer
            for (int i = 0; i < 1; i++)
            {
                Random theRand = new Random(Guid.NewGuid().GetHashCode());
                choice = theRand.Next(secondLevels.Count);
                if (secondLevels[choice].StartsWith(firstLevelAnswer.Substring(0, 1)))
                {
                    secondLevelAnswer = secondLevels[choice];
                    secondLevelChoices.Add(secondLevelAnswer);
                }
                else
                {
                    i--;
                }
            }
            //Add random second level choices that aren't answers
            for (int i = 0; i < 3; i++)
            {
                Random theRand = new Random(Guid.NewGuid().GetHashCode());
                int randomChoice = theRand.Next(secondLevels.Count);

                if (secondLevels[randomChoice].StartsWith(firstLevelAnswer.Substring(0, 1)) && !secondLevels[randomChoice].Equals(secondLevelAnswer) && !secondLevelChoices.Contains(secondLevels[randomChoice]))
                {
                    secondLevelChoices.Add(secondLevels[randomChoice]);
                }
                else
                {
                    i--;
                }
            }
            //Randomly choose third level answer
            for (int i = 0; i < 1; i++)
            {
                Random theRand = new Random(Guid.NewGuid().GetHashCode());
                choice = theRand.Next(thirdLevels.Count);
                if (thirdLevels[choice].StartsWith(secondLevelAnswer.Substring(0, 2)))
                {
                    thirdLevelAnswer = thirdLevels[choice];
                    thirdLevelChoices.Add(thirdLevelAnswer);
                }
                else
                {
                    i--;
                }
            }
            //Add random third level choices that aren't answers
            for (int i = 0; i < 3; i++)
            {
                Random theRand = new Random(Guid.NewGuid().GetHashCode());
                int randomChoice = theRand.Next(8) + 1;
                string wrongChoice = secondLevelAnswer.Substring(0, 2) + randomChoice;

                if (!wrongChoice.Equals(thirdLevelAnswer.Substring(0, 3)) && !thirdLevelChoices.Contains(wrongChoice))
                {
                    thirdLevelChoices.Add(wrongChoice);
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < thirdLevelChoices.Count; i++)
            {
                thirdLevelChoices[i] = thirdLevelChoices[i].Substring(0, 3);
            }
        }
    }
}