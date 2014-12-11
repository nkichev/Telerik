namespace TreeDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Node<T>
    {
        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value) : this()
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }
            
        public dynamic GetSum()
        {
            dynamic sum = 0;

            if (this.Children.Count == 0)
            {
                return this.Value;
            }

            sum += this.Value;

            foreach (var node in this.Children)
            {
                sum += node.GetSum();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Children.Count == 0)
            {
                result.AppendFormat("{{{0}}}", this.Value);
                return result.ToString();
            }

            result.AppendFormat("{{{0}->", this.Value);
            foreach (var node in this.Children)
            {
                result.Append(node.ToString());
            }
            result.Append("}");

            return result.ToString();
        }
    }
}