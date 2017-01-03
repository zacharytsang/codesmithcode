using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;
using Models;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        T_User user = new T_User();
        user = T_UserManager.GetT_UserById(1);
        List<T_User> List = new List<T_User>();
        List = T_UserManager.GetAllT_UserBySQLstring("select * from T_User");

    }
}
