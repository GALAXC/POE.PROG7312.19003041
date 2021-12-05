using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace POE.PROG7312._19003041
{
    /*
     Code retrieved from users 'SimpleVar' and 'Marcus Mangelsdorf'
    from StackOverflow question -> https://stackoverflow.com/questions/9860207/build-a-simple-high-performance-tree-data-structure-in-c-sharp
     */

    internal class TreeNode : IEnumerable<TreeNode>
    {
        private readonly Dictionary<string, TreeNode> _children =
                                            new Dictionary<string, TreeNode>();

        public readonly string ID;
        public TreeNode Parent { get; private set; }

        public TreeNode(string id)
        {
            this.ID = id;
        }

        public TreeNode GetChild(string id)
        {
            return this._children[id];
        }

        public void Add(TreeNode item)
        {
            if (item.Parent != null)
            {
                item.Parent._children.Remove(item.ID);
            }

            item.Parent = this;
            this._children.Add(item.ID, item);
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return this._children.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int Count
        {
            get { return this._children.Count; }
        }

        public static TreeNode BuildTree(string[] tree)
        {
            //var lines = tree.Split(new[] { Environment.NewLine },
            //                       StringSplitOptions.RemoveEmptyEntries);

            var result = new TreeNode("TreeRoot");
            var list = new List<TreeNode> { result };

            foreach (var line in tree)
            {
                var trimmedLine = line.Trim();
                var indent = line.Length - trimmedLine.Length;

                var child = new TreeNode(trimmedLine);
                list[indent].Add(child);

                if (indent + 1 < list.Count)
                {
                    list[indent + 1] = child;
                }
                else
                {
                    list.Add(child);
                }
            }

            return result;
        }
    }
}