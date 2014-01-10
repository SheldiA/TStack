using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TStack
{
    public enum RequestType { pop,push };

    class UserRequestEventsArgs : EventArgs
    {
        private RequestType request;
        public RequestType Request
        {
            get
            {
                return request;
            }
        }

        public UserRequestEventsArgs(RequestType request)
            : base()
        {
            this.request = request;
        }
    }
}
