using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scenester
{
    class UserAgent
    {
        private String description = null;
        private String userAgentString = null;
        private int width = -1;
        private int height = -1;
        
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public String UserAgentString
        {
            get { return userAgentString; }
            set { userAgentString = value; }
        }

    }
}
