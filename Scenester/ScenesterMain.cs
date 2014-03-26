/*Icon downloaded from the https://www.iconfinder.com/icons/196910/app_fez_framework_puzzle_software_icon#size=32 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Xml;
using System.IO;
using System.Security.AccessControl;
using System.Net;
//adding Threading support for progress bar
using System.Threading;


namespace Scenester
{
    public partial class ScenesterMain : Form
    {
        private List<UserAgent> useragents;
        private List<Result> results;
        private FirefoxProfile profile;
        private string tempFolder;
        private Utils utils;
        
        
        

        public ScenesterMain()
        {
            InitializeComponent();
            profile = new FirefoxProfile();
            useragents = new List<UserAgent>();
            results = new List<Result>();
            utils = new Utils();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempFolder = System.IO.Path.GetTempPath() + "ncc_scenester\\" ;
            /* clear temporary directory may have been created in past */
            if (Directory.Exists(tempFolder))
            {
                try
                {
                    Directory.Delete(tempFolder, true);
                }
                catch (IOException ioe)
                {
                    errorMsg_txt.AppendText(ioe.Message);
                }
            }
            /*create temporary directory to store screenshots and render output */
            DirectoryInfo info =  Directory.CreateDirectory(tempFolder);
            
            /*Make sure that directory created successfully*/
            if (!info.Exists)
            {
                Directory.CreateDirectory(tempFolder);
            }

            getDefaultUserAgents(null);
            errorMsg_txt.AppendText(tempFolder);          

        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            run_btn.Enabled = false;
            
            
            // Create a new instance of the Firefox driver.
            IWebDriver driver;
            results.Clear();

            /*Check if url/Ip are entered or not*/
            if (urlIp_txtarea.Lines.Length <= 0)
            {
                MessageBox.Show(this, "Please enter target URL", "URL's Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                run_btn.Enabled = true;
                return;
            }

            /*<scenester>
             * 	<useragent description="Chrome 4.0.302.2 (OS X 10_5_8 Intel)" useragent="Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-US) AppleWebKit/532.8 (KHTML, like Gecko) Chrome/4.0.302.2 Safari/532.8" platform="Windows" width=800 height=200 />
             *</scenester>
             */
            var useragentsSelected = userAgent_listbox.SelectedIndices;
            if (useragentsSelected.Count <= 0)
            {
                MessageBox.Show(this, "Please select atleast one User Agent", "User Agent Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                run_btn.Enabled = true;
                return;
            }

            Uri tempUri;
            Result tempResult;
            /*Counting total number of screenshots to take, for each url there will be screenshot with selected useragents,  */
            int total = urlIp_txtarea.Lines.Length * useragentsSelected.Count;
            screenshot_progressbar.Maximum = total;
            
            
            int result = 0;
            /*initiate progressbar */
            updateProgressbar(result, total);

            /*Enumerate each IP/URL entered*/
            for (int i = 0; i < urlIp_txtarea.Lines.Length; i++)
            {
                /*Enumerate each useragent selected */
                for (int j = 0; j < useragentsSelected.Count; j++)
                {
                    result++;
                    tempResult = new Result();

                    try
                    {
                        
                        /*If protocole is missing then add protocole based on radio button selected and update tempUri*/
                        if (urlIp_txtarea.Lines[i].ToLower().IndexOf("http://", 0, 8 ) == -1 && urlIp_txtarea.Lines[i].ToLower().IndexOf("https://", 0, 8) == -1)
                            {
                                if (http_rbtn.Checked)
                                {
                                    tempUri = new Uri("http://" + urlIp_txtarea.Lines[i]);
                                }
                                else
                                {
                                    tempUri = new Uri("https://" + urlIp_txtarea.Lines[i]);
                                }
                               
                            }
                            else {
                                tempUri = new Uri(urlIp_txtarea.Lines[i]);
                            }
                        
                        tempResult.OriginalHost = tempUri;
                        IPHostEntry Host = Dns.GetHostEntry(tempUri.Host);
                        //tempResult.FinalIpAddress = Host.AddressList[0] + "";
                        tempResult.Useragent = useragents[useragentsSelected[j]];
                    }
                    catch (Exception ee)
                    {
                        errorMsg_txt.AppendText(Environment.NewLine+"Error with Url : " + urlIp_txtarea.Lines[i] + " : " + ee.Message);
                        updateProgressbar(result, total);
                        
                        continue;
                    
                    }

                    try
                    {
                        profile.SetPreference("general.useragent.override", useragents[useragentsSelected[j]].UserAgentString);
                        profile.AcceptUntrustedCertificates = true;
                        profile.SetPreference("network.http.connection-timeout", 5);
                        driver = new FirefoxDriver(profile);
                        //driver = new FirefoxDriver();
                        driver.Navigate().GoToUrl(new Uri("about:blank"));

                        if (useragents[useragentsSelected[j]].Width != -1)
                        {
                            driver.Manage().Window.Size = new Size(useragents[useragentsSelected[j]].Width, useragents[useragentsSelected[j]].Height);
                        }
                        Thread.Sleep(500);
                        driver.Navigate().GoToUrl(tempUri);

                        /*wait for 2 seconds for page to finish rendering page */
                        Thread.Sleep(2000);
                        // Should see: "Cheese - Google Search"
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                        System.Console.WriteLine("Page title is: " + (new Uri(driver.Url)).Host);
                        tempResult.FinalHost = new Uri(driver.Url);
                        try
                        {
                            IPHostEntry Host_dns = Dns.GetHostEntry((new Uri(driver.Url)).Host);
                            tempResult.FinalIpAddress = Host_dns;
                            for (int k = 0; k < Host_dns.AddressList.Length; k++)
                            {
                                Console.WriteLine(Host_dns.AddressList[j]);
                            }
                            Console.WriteLine();
                        }
                        catch (Exception exception)
                        {
                            /*Exception in resolving dns*/
                            errorMsg_txt.AppendText(Environment.NewLine + "Exception in resolving DNS " + exception);
                        }
                        //driver.Manage().Timeouts().SetPageLoadTimeout(timespan);
                        //take screen shot
                        var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                        String tempuri = tempFolder + "screenShot" + i + "_" + j + ".png";
                        ///String tempuri = "C:\\Users\\Sharique\\Downloads\\" + "screenShot" + i + "_" + j + ".png";

                        tempResult.ImageUrl = tempuri;
                        screenshot.SaveAsFile(tempuri, System.Drawing.Imaging.ImageFormat.Png);
                        tempResult.ResponseHeader= utils.getResponseHeaders(tempUri.OriginalString);
                        results.Add(tempResult);
                        //Close the browser

                        driver.Quit();
                    }
                    catch (Exception eee)
                    {
                        errorMsg_txt.AppendText(Environment.NewLine + "\nError with Driver : " + urlIp_txtarea.Lines[i] + "\n" + eee.Message);
                    }
                    updateProgressbar(result, total);
                    
                    
                }
            }
            utils.reportBuilder(results, tempFolder);
            userAgent_listbox.ClearSelected();
            run_btn.Enabled = true;
            return;



        }

        private void importUseragent_btn_Click(object sender, EventArgs e)
        {
            
            importUseragentXml_fdb.Title = "Import UserAgent XML";
            //importUseragentXml_fdb.Filter = "XML|*.xml";

            if (importUseragentXml_fdb.ShowDialog() == DialogResult.OK)
            {
                importUseragent_txt.Text = importUseragentXml_fdb.FileName;
                /*Read User agent strings from the XML file*/
                getDefaultUserAgents(importUseragentXml_fdb.FileName);
              
            }
        }
        private Boolean getDefaultUserAgents(String fileName)
        {
            userAgent_listbox.Items.Clear();
            String defaultXml =  "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>"
                 +"<scenester>"
                 + "<useragent description=\"FireFox 24.0 \" useragent=\"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0\" />"
                 + "<useragent description=\"Android 1.1 - Mobile Safari 523\" useragent=\"Mozilla/5.0 (Linux; U; Android 1.1; en-gb; dream) AppleWebKit/525.10  (KHTML, like Gecko) Version/3.0.4 Mobile Safari/523.12.2\" />"
                 + "<useragent description=\"iPhone 4\" useragent=\"Mozilla/5.0 (iPhone; CPU iPhone OS 5_0_1 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Mobile/9A405\" width=\"320\" height=\"480\" />"
                 + "<useragent description=\"Android HTC One X - Chrome\" useragent=\"Mozilla/5.0 (Linux; Android 4.0.3; HTC One X Build/IML74K) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/535.19\" width=\"720\" height=\"1280\" />"
                 + "<useragent description=\"Samsung Galaxy S3 - Safari\" useragent=\"Mozilla/5.0 (Linux; U; Android 4.0.4; en-gb; GT-I9300 Build/IMM76D) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30\" width=\"720\" height=\"1280\" />"
                 + "<useragent description=\"Windows Phone 8 Lumia 920\" useragent=\"Mozilla/5.0 (compatible; MSIE 10.0; Windows Phone 8.0; Trident/6.0; IEMobile/10.0; ARM; Touch; NOKIA; Lumia 920)\" width=\"768\" height=\"1280\" />"	
                 + "</scenester>";

            /**/
            try
            {
                XmlReader xmlReader;
                if (fileName != null)
                {
                    xmlReader = XmlReader.Create(fileName);
                }
                else
                {
                    xmlReader = XmlReader.Create(new StringReader(defaultXml));
                    
                }

                UserAgent tmp_agents;
                while (xmlReader.Read())
                {
                    if (xmlReader.Name.Equals("useragent") && (xmlReader.NodeType == XmlNodeType.Element))
                    {


                        tmp_agents = new UserAgent();
                        tmp_agents.UserAgentString = xmlReader.GetAttribute("useragent");
                        tmp_agents.Description = xmlReader.GetAttribute("description");
                        if (xmlReader.GetAttribute("width") != null)
                        {
                            try
                            {
                                tmp_agents.Width = Convert.ToInt32(xmlReader.GetAttribute("width"));
                            }
                            catch (Exception)
                            {//ignote and continue }
                            }

                        }
                        if (xmlReader.GetAttribute("height") != null)
                        {
                            try
                            {
                                tmp_agents.Height = Convert.ToInt32(xmlReader.GetAttribute("height"));
                            }
                            catch (Exception)
                            {//ignote and continue }
                            }

                        }
                        useragents.Add(tmp_agents);
                        userAgent_listbox.Items.Add(xmlReader.GetAttribute("useragent"));
                    }
                }
            }
            catch (Exception e)
            {
                errorMsg_txt.Text = e.Message;
                Console.WriteLine(e.StackTrace);
                return false;
            }
            /**/
            return true;
        }
        private Boolean updateProgressbar(int result, int total)
        {
            screenshot_progressbar.Step = 1;
            screenshot_progressbar.PerformStep();
            screenshot_progressbar.Refresh();
            
            progress_lbl.Text = "Total: " + result + "/" + total + " Done";
            progress_lbl.Refresh();
            Thread.Sleep(300);
            return true;
        }
        

    }
}
