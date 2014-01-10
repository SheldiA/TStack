using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TStack
{
    class TStack<T>
    {
        public delegate void UserRequest(object sender,UserRequestEventsArgs e);
        public event UserRequest OnRequest;

        private Element<T> top;
        private Element<T> bottom;
        private int size;
        public TStack()
        {
            top = null;
            bottom = null;
            size = 0;
        }

        public void Push(T data)
        {
            Element<T> element = new Element<T>(data);
            if (size > 0)
            {
                element.Next = top;
                top = element;
            }
            else
            {
                element.Next = null;
                top = element;
                bottom = element;
            }
            ++size;
            OnRequest(this,new UserRequestEventsArgs(RequestType.push));
        }

        public T Pop()
        {
            T result = default(T);

            if (top != null)
            {
                result = top.Data;
                top = top.Next;
                if (top == null)
                    bottom = null;
                --size;
            }
            OnRequest(this, new UserRequestEventsArgs(RequestType.pop));
            return result;
        }

        public void Clear()
        {
            top = null;
            bottom = null;
            size = 0;
        }
    }
}
