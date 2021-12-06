using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace POE.PROG7312._19003041
{
    public class CallNumbers
    {
        //To temporarily store all values from tree
        public static List<string> thirdLevels = new List<string>();

        public static List<string> secondLevels = new List<string>();
        public static List<string> firstLevels = new List<string>();

        //Random
        public static Random myRand = new Random();

        //String to keep track of answers for quiz
        public static string myAnswer = "";

        public static string myGoal = "";
        public static string firstLevelAnswer = "";

        //Lists that store options the user can select
        public static List<string> thirdLevelChoices = new List<string>();

        public static List<string> secondLevelChoices = new List<string>();
        public static List<string> firstLevelChoices = new List<string>();

        //To store the final answers
        public static string thirdLevelAnswer = "";

        public static string secondLevelAnswer = "";
        public static string finalAnswer = "";

        /// <summary>
        /// Method is used to load the call numbers from the file and populate it into a tree
        /// It is also responsible for preparing the tree the output options and answers for the quiz
        /// </summary>
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
                //Generate a random answer for the user to guess and random other options user can select
                SelectRandomAnswer(tree);
                //Obscure the answer by removing the call number
                myGoal = thirdLevelAnswer.Substring(4, thirdLevelAnswer.Length - 4);
            }
        }

        /// <summary>
        /// Take the tree of data read from the data file and use it to populate the UI with options and the answer for the user to select
        /// and in order to play the game
        /// </summary>
        /// <param name="tree"></param>
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
            //Change the format of all third level answers to consistent format
            for (int i = 0; i < thirdLevelChoices.Count; i++)
            {
                thirdLevelChoices[i] = thirdLevelChoices[i].Substring(0, 3);
            }
            //Sort the lists numerically
            firstLevelChoices.Sort();
            secondLevelChoices.Sort();
            thirdLevelChoices.Sort();
        }
    }
}