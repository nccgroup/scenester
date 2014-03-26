using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Scenester
{
    

    class Result
    {
        private UserAgent useragent;
        private String imageUrl;
        private Uri originalHost;
        private String originalIpAddress;
        private Uri finalHost;
        private IPHostEntry finalIpAddress;
        private WebHeaderCollection responseHeader;

               
        public Result()
        {
            useragent = null;
            imageUrl = "";
            originalHost = null;
        }
        public UserAgent Useragent
        {
            get { return useragent; }
            set { useragent = value; }
        }
        public String ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
        public Uri OriginalHost
        {
            get { return originalHost; }
            set { originalHost = value; }
        }
        public String OriginalIpAddress
        {
            get { return originalIpAddress; }
            set { originalIpAddress = value; }
        }
        public Uri FinalHost
        {
            get { return finalHost; }
            set { finalHost = value; }
        }
        public IPHostEntry FinalIpAddress
        {
            get { return finalIpAddress; }
            set { finalIpAddress = value; }
        }
        public WebHeaderCollection ResponseHeader
        {
            get { return responseHeader; }
            set { responseHeader = value; }
        }
    }
}
