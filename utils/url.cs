using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Xiaos.utils
{
    class url
    {
        public String Url( String url, NameValueCollection data)
        {
            var web = new WebClient();
            String responseData  = Encoding.UTF8.GetString(web.DownloadData(url));
            return responseData;
        }
    }
}
