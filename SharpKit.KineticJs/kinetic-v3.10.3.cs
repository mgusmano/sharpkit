using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.KineticJs
{
    public class Node
    {
        /// <summary>
        /// Node constructor.  Nodes are entities that can be transformed, layered,and have events bound to them. They are the building blocks of a KineticJSapplication
        /// </summary>
        /// <param name="config"></param>
        public Node(object config) { }

        /// <summary>
        /// clone node
        /// </summary>
        /// <param name="config">used to override cloned attrs</param>
        /// <returns></returns>
        public Node clone(object config) { return null; }

    }

}
