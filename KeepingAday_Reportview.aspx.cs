using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KeepingAday_Reportview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Confirm_date_Click(object sender, EventArgs e)
    {
        string str1 = "";
        string[] str2 = null;
        str2 = Request.PathInfo.Split('/');
        foreach (string i in str2)
        {
            str1 = i.ToString();
        }
        HttpCookie cookie = new HttpCookie("Feed_aday_time");    //定義cookie對象以及名為Info的項
        cookie.Value = str1;
        DateTime dtNow = DateTime.Now;
        TimeSpan tsMinute = new TimeSpan(0, 0, 3, 0);
        cookie.Expires = dtNow + tsMinute;
        Response.Cookies.Add(cookie);
    }
}