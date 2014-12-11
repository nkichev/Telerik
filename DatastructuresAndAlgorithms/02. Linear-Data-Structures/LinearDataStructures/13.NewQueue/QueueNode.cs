using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NewQueue
{
    public class QueueNode<T>
    {
        public QueueNode<T> NextNode { get; set; }

        public T Data { get; set; }

        public QueueNode (T newData)
	    {
            this.Data = newData;
	    }
    }
}
