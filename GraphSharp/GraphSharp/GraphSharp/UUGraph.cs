using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSharp
{
    /// <summary>
    /// Unweighted undirected graph
    /// </summary>
    public class UUGraph : Dictionary<INode,double>, IGraph
    {
        private double[,] m_adjmatrix;
        public int Order
        {
            get
            {
                return m_adjmatrix.GetLength(1);
            }
            private set { }
        }

        public UUGraph(int Order)
        {
            m_adjmatrix = new double[Order, Order];
        }

        public IComponent BreadthFirstSearch(INode sink)
        {

        }
    }
}
