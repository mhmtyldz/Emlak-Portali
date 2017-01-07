using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_master_admin : System.Web.UI.MasterPage
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtilan = klas.GetDataTable("Select * From ilanlar Where Onay=0");
        if (dtilan.Rows.Count > 0)
            lblilan.Visible = true;
        else
            lblilan.Visible = false;
        lblilan.Text =" ("+dtilan.Rows.Count.ToString()+") ";
    }
}
