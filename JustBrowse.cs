using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JustBrowse
{
    public partial class JustBrowse : Form
    {
        private string _defaulURL = "http://www.google.com";
        private WebBrowser _webBrowser = new WebBrowser();
        private int _tabIndex = 0;
        private string _nextTabURL = "http://";

        public JustBrowse()
        {
            InitializeComponent();
            
            this.URLInput.Text = this._defaulURL.ToString();
        }

        public static string ReturURLInProperFormat(string input)
        {

            //proper format http://www.Somedomain
            string pattern = @"http://www.";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input))
            {
                return input;
            } else
            {
                //check for other options
                //missing http:// part
                regex = new Regex(@"http://");
                if (regex.IsMatch(input))
                {
                    //http fragmet is not missing
                    regex = new Regex(@"www.");
                    if (regex.IsMatch(input))
                    {
                        //http://www. fragmet both are not missing -> wrong URL
                        return input;
                    }
                    else
                    {
                        //Issue Need to be fixed !
                        //www. part is missing
                        return String.Format("{0}www.{1}",String.Format("http://"), input);
                    }
                } else
                {
                    //check if www. is missing
                    regex = new Regex(@"www.");
                    if (regex.IsMatch(input))
                    {
                        //only http:// is missing
                        return String.Format("http://{0}", input);
                    } else
                    {
                        //http and www. fragmets are missing
                        return String.Format("http://www.{0}", input);
                    }
                }

            }
        }

        private void URLInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {   
                e.SuppressKeyPress = true;
                this.tabControl.SelectTab(this.tabControl.SelectedIndex);
                ((WebBrowser)tabControl.SelectedTab.Controls[0])
                .Navigate(ReturURLInProperFormat(URLInput.Text.ToString()));
                

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[this._tabIndex]).GoBack();      
        }

        private void forward_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[this._tabIndex]).GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Refresh();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0])
                .Navigate(ReturURLInProperFormat(this._defaulURL));
        }

        private void makeHomePage_Click(object sender, EventArgs e)
        {
            if (URLInput.Text.ToString() != null || URLInput.Text.ToString() != string.Empty)
            {
                this._defaulURL = ReturURLInProperFormat(URLInput.Text.ToString());
            }
        }

        private void JustBrowse_Load(object sender, EventArgs e)
        {

            this._webBrowser.ScriptErrorsSuppressed = true;
            this._webBrowser.Dock = DockStyle.Fill;
            this._webBrowser.Visible = true;
            this._webBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
            tabControl.TabPages.Add("New Page");
            tabControl.SelectTab(this._tabIndex);
            tabControl.SelectedTab.Controls.Add(this._webBrowser);
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(this._defaulURL);
            

        }

        private void _webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.tabControl.SelectedTab.Text = ((WebBrowser)tabControl.SelectedTab.Controls[0]).DocumentTitle;
        }

       

        private void closeTab_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ContextMenuStrip closeMenu = new ContextMenuStrip();
                closeMenu.Items.Add("Close Tab").Name = "close";
                closeMenu.Items.Add("Add new Tab").Name = "newTab";
                closeMenu.Show(this.tabControl, new Point(e.X, e.Y));
                closeMenu.ItemClicked += CloseMenu_ItemClicked;
            }
        }

        private void CloseMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name == "close")
            {
                if(tabControl.TabPages.Count - 1 > 0)
                {
                    tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                    this._tabIndex -= 1;
                }
            }
            if (e.ClickedItem.Name == "newTab")
            {
                AddNewTab();
            }
        }

        private void JustBrowse_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                menuStrip.Items.Add("Add new Tab").Name = "Add new tab";
                menuStrip.Show(this, e.X, e.Y);
                menuStrip.ItemClicked += MenuStrip_ItemClicked;
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name == "Add new tab")
            {              
                AddNewTab();
            }
        }
        private  void AddNewTab()
        {
            this._tabIndex = this._tabIndex + 1;
            this._webBrowser = new WebBrowser();
            this._webBrowser.ScriptErrorsSuppressed = true;
            this._webBrowser.Dock = DockStyle.Fill;
            this._webBrowser.Visible = true;
            this._webBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
            tabControl.TabPages.Add("New Page");
            tabControl.SelectTab(this._tabIndex);
            tabControl.SelectedTab.Controls.Add(this._webBrowser);
            this.URLInput.Text = this._nextTabURL.ToString();
        }
           

        
    }
}