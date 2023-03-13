using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TarimSitesi
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblBilgiTableAdapter dt= new DataSet1TableAdapters.TblBilgiTableAdapter();
            Repeater1.DataSource = dt.BilgiGetir();
            Repeater1.DataBind();

            DataSet1TableAdapters.TblUrunlerTableAdapter dt2 = new DataSet1TableAdapters.TblUrunlerTableAdapter();
            Repeater2.DataSource = dt2.UrunGetir();
            Repeater2.DataBind();

        }
    }
}