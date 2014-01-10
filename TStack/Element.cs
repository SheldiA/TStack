using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TStack
{
    class Element<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        private Element<T> next;
        public Element<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Element(T data)
        {
            this.data = data;
            next = null;
        }

    }
}
