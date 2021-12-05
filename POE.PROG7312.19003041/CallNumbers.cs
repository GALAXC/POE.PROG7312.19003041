using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace POE.PROG7312._19003041
{
    public class CallNumbers
    {
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
                foreach (string s in txtFile)
                {
                    totalTree += s;
                }
                //Console.WriteLine(totalTree);

                TreeNode tree = TreeNode.BuildTree(txtFile);
                foreach (TreeNode tre in tree)
                {
                    Console.WriteLine(tre.ID);
                    foreach (TreeNode tre2 in tre)
                    {
                        Console.WriteLine(tre2.ID);
                    }
                }
            }
        }
    }
}