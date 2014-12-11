namespace LinkedListDemoImplementation
{
    using System;
    using System.Text;

    public class LinkedList<T>
    {
        public ListItem<T> FirstElement { get; set; }

        public ListItem<T> LastElement { get; set; }

        public int Count
        {
            get
            {
                return this.GetCount();
            }
        }

        public void AddFirst(T value) 
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
                this.LastElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newItem = new ListItem<T>(value);
                newItem.NextItem = this.FirstElement;
                this.FirstElement = newItem;
            }
        }

        public void AddLast(T value)
        {
            if (this.LastElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
                this.LastElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newItem = new ListItem<T>(value);
                ListItem<T> current = this.FirstElement;

                while (current.NextItem != null)
                {
                    current = current.NextItem;
                }

                current.NextItem = newItem;
            }
        }

        public void Remove(T value)
        {
            if (this.FirstElement == null)
            {
                throw new InvalidOperationException("You can not remove an element from an empty list!");
            }

            ListItem<T> current = this.FirstElement;
            ListItem<T> previuos = null;
            while (current != null)
            {
                if ((dynamic)current.Value == (dynamic)value)
                {
                    if (previuos == null)
                    {
                        this.FirstElement = this.FirstElement.NextItem;
                    }
                    else
                    {
                        previuos.NextItem = current.NextItem;
                    }
                }

                previuos = current;
                current = current.NextItem;
            }
        }

        public override string ToString()
        {
            if (this.FirstElement == null)
            {
                return "Empty list!";
            }

            StringBuilder result = new StringBuilder();
            ListItem<T> current = this.FirstElement;

            result.AppendLine(current.Value.ToString());

            while (current.NextItem != null)
            {
                current = current.NextItem;
                result.AppendLine(current.Value.ToString());
            }

            return result.ToString();
        }

        private int GetCount()
        {
            if (this.FirstElement == null)
            {
                return 0;
            }

            ListItem<T> current = this.FirstElement;
            int count = 1;
            while (current.NextItem != null)
            {
                count++;
                current = current.NextItem;
            }

            return count;
        }
    }
}