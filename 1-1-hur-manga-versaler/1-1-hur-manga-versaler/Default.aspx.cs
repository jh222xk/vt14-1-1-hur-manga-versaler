using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_1_hur_manga_versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            TextBox1.Enabled = false;
            UppercaseCount.Text = "Texten innehåller " + Model.TextAnalyzer.GetNumberofCapitals(TextBox1.Text) + " versaler";
            SendButton.CssClass = "hidden";
            ClearButton.CssClass = "show";
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            ClearButton.CssClass = "hidden";
            SendButton.CssClass = "show";
        }
        
    }
}