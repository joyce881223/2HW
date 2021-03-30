using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int N = 15;
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if ((i % 2 == 0)|| (i % 3 == 0))
                {
                    if ((i % 2 == 0) && (i % 3 == 0))
                    {
                        sum = i + 1;
                    }
                    else
                    {
                        sum = i + 1;
                    }
                }
            }
            Response.Write(sum);
        }
    }
}