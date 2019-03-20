using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace curdwithef
{
    public partial class editform : System.Web.UI.Page
    {
        CURDEGEntities db = new CURDEGEntities();
        List<gETUSERS_Result> listt = new List<gETUSERS_Result>();
        int rq;
        protected void Page_Load(object sender, EventArgs e)
        {
            rq = Convert.ToInt16( Request.QueryString["id"]);
            if (rq==0)
            {
                btnsave.Visible = true;
                txtid.Visible = false;
            }

            else if (rq!=0)
            {
                Getid(id: rq);
                btnsave.Visible = false;
                btnupdate.Visible = true;
            }
            
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            db.INSERTUSER(nAME: txtname.Text);

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            db.UPDATEUSER(iD: rq, nAME: txtname.Text);
        }

        public void Getid(int id)
        {
            listt = db.gETUSERS().ToList();
            foreach (var item in listt.Where(y=>y.ID==id))
            {
                txtid.Text = item.ID.ToString();
                txtname.Text = item.NAME;
            }
        }
    }
}