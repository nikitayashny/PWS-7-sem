using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Simplex service;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new Simplex();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtAddX.Text);
            int y = int.Parse(txtAddY.Text);
            int result = service.Add(x, y);
            addResult.InnerText = "Result: " + result;
        }

        protected void btnConcat_Click(object sender, EventArgs e)
        {
            string s = txtConcatString.Text;
            double d = double.Parse(txtConcatDouble.Text);
            string result = service.Concat(s, d);
            concatResult.InnerText = "Result: " + result;
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            var a1 = new A
            {
                s = txtSumString1.Text,
                k = int.Parse(txtSumInt1.Text),
                f = float.Parse(txtSumFloat1.Text)
            };
            var a2 = new A
            {
                s = txtSumString2.Text,
                k = int.Parse(txtSumInt2.Text),
                f = float.Parse(txtSumFloat2.Text)
            };
            var result = service.Sum(a1, a2);
            sumResult.InnerText = "Result: " + $"{{ s: {result.s}, k: {result.k}, f: {result.f} }}";
        }
    }

}
