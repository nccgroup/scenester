using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Scenester
{
    class Utils
    {
        /*Build report*/
        public bool reportBuilder(List<Result> results, String rootFolder)
        {



            String html;
            System.IO.StreamWriter file=null;
            for (int i = 0; i < results.Count; i++)
            {
                html = Scenester.Properties.Resources.Header;
                html = html.Replace("NCC_BODY_TEXT_TO_REPLACE", Path.GetFileName(results[i].ImageUrl))
                    .Replace("NCC_USER_AGENT_STRING", System.Net.WebUtility.HtmlEncode(results[i].Useragent.UserAgentString))
                    .Replace("NCC_USER_AGENT_DESCRIPTION", System.Net.WebUtility.HtmlEncode(results[i].Useragent.Description))
                    .Replace("NCC_SITE_URL_IP", System.Net.WebUtility.HtmlEncode(results[i].OriginalHost.OriginalString))
                    .Replace("NCC_SITE_FINAL_URL", System.Net.WebUtility.HtmlEncode(results[i].FinalHost.AbsoluteUri));
                /* FINAL IP ADDRESS: if final ip address value is not null and it contain atleast one ip adreess then print them */
                if ((results[i].FinalIpAddress != null) && (results[i].FinalIpAddress.AddressList.Length > 0))
                {
                    String temp = "<ul>";
                    for (int j = 0; j < results[i].FinalIpAddress.AddressList.Length; j++)
                    {
                        temp = temp + "<li>" + results[i].FinalIpAddress.AddressList[j] + "</li>";
                    }
                    temp = temp + "</ul>";
                    html = html.Replace("NCC_SITE_FINAL_IP", temp);
                }
                /* RESPONSE HEADERS: if there is any final response headers then print them */
                if ((results[i].ResponseHeader != null) && (results[i].ResponseHeader.Count > 0))
                {
                    String temp = "<ul>";
                    for (int j = 0; j < results[i].ResponseHeader.Count; j++)
                    {
                        temp = temp + "<li>" + results[i].ResponseHeader.GetKey(j) + " : " + results[i].ResponseHeader.Get(j) + "</li>";
                    }
                    temp = temp + "</ul>";
                    html = html.Replace("NCC_SITE_FINAL_RESPONSE_HEADERS", temp);
                }
                
                /*first page, so there will be no previous page link*/
                if (i == 0)
                {
                    html = html.Replace("NCC_PREVIOUS_PAGE_LINK", "&nbsp;");
                    //<a href="#" >« Previous</a>
                }
                else {
                    html = html.Replace("NCC_PREVIOUS_PAGE_LINK", "<a href=\"screenshot-" + (i - 1) + ".html\" >&lt;&lt;Previous</a>");
                                   
                }
                /*last page so there will be no next page */
                if (i == results.Count-1)
                {
                    html = html.Replace("NCC_NEXT_PAGE_LINK", "&nbsp;");
                    //<a href="#" >Next »</a>
                }
                else
                {
                    html = html.Replace("NCC_NEXT_PAGE_LINK", "<a href=\"screenshot-" + (i + 1) + ".html\" >Next &gt;&gt;</a>");
                }

                /*create file and write everything in it */
                if (!System.IO.File.Exists(System.IO.Path.Combine(rootFolder, "screenshot-" + i + ".html")))
                {
                    System.IO.FileStream ff = System.IO.File.Create(System.IO.Path.Combine(rootFolder, "screenshot-" + i + ".html"));
                    ff.Close();
                }
                file = new System.IO.StreamWriter(System.IO.Path.Combine(rootFolder, "screenshot-" + i + ".html"));
                file.WriteLine(html);
                if (file != null)
                {
                    file.Close();
                }
            }
            
            /*temp*/
            try
            {
                System.Diagnostics.Process.Start(System.IO.Path.Combine(rootFolder, "screenshot-0.html"));
            }
            catch(System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    Console.WriteLine(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                Console.WriteLine(other.Message);
            }
            
            return true;
        }
        public WebHeaderCollection getResponseHeaders(String url)
        {
            HttpWebResponse httpWebResponse;
            WebHeaderCollection headers = null;
            try
            {
                Uri ourUri = new Uri(url);
                // Creates an HttpWebRequest for the specified URL. 
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(ourUri);
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Console.WriteLine("\nThe server did not issue any challenge.  Please try again with a protected resource URL.");
                // Releases the resources of the response.
                headers = httpWebResponse.Headers;
                httpWebResponse.Close();
            }
            catch (Exception e)
            {
                /*may be handle later, anyway on exception, function will return null header object*/
            }
            return headers;    
        
        }
    }
}
