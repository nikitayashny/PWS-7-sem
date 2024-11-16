using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.PWS_Lab5;

namespace WebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var client = new WCFSiplexClient("BasicHttpBinding_IWCFSiplex"))
            {
                int x = int.Parse(num1.Text);
                int y = int.Parse(num2.Text);
                int result = client.Add(x, y);
                lblResultAdd.Text = $"Сумма: {result}";
            }
        }

        protected void btnConcat_Click(object sender, EventArgs e)
        {
            using (var client = new WCFSiplexClient("BasicHttpBinding_IWCFSiplex"))
            {
                string str = strInput.Text;
                double num = double.Parse(numInput.Text);
                string result = client.Concat(str, num);
                lblResultConcat.Text = $"Результат: {result}";
            }
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            using (var client = new WCFSiplexClient("BasicHttpBinding_IWCFSiplex"))
            {
                A a1 = new A
                {
                    S = strA1.Text,
                    K = int.Parse(numA1.Text),
                    F = float.Parse(floatA1.Text)
                };
                A a2 = new A
                {
                    S = strA2.Text,
                    K = int.Parse(numA2.Text),
                    F = float.Parse(floatA2.Text)
                };


                A result = client.Sum(a1, a2);
                lblResultSum.Text = $"Результат: {result.S}, {result.K}, {result.F}";
            }
        }
    }
}