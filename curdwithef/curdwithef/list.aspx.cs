using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace curdwithef
{
    public partial class list : System.Web.UI.Page
    {
       int rq;
        CURDEGEntities db = new CURDEGEntities();
        List<gETUSERS_Result> listt = new List<gETUSERS_Result>();
        protected void Page_Load(object sender, EventArgs e)
        {
             rq = Convert.ToInt16(Request.QueryString["id"]);
            if (rq == 0)
            {
                Bind();
            }
            else if (rq != 0)
            {
                db.DEL_USER(iD: rq);
                Bind();
            }
        }

        public void Bind()
        {
            listt = db.gETUSERS().ToList();
            gvlist.DataSource= db.gETUSERS().ToList();
            gvlist.DataBind();
        }
    }
}
