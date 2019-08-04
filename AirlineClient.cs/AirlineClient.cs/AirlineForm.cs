using System;
using System.Linq;
using System.Windows.Forms; 
using AirlineClient.cs.AirlineService;

namespace AirlineClient.cs
{
    public partial class AirlineForm : Form
    {
        private readonly AirlineServiceClient client;
        public AirlineForm()
        {
            InitializeComponent();
            client = new AirlineServiceClient("BasicHttpBinding_IAirlineService");

        }

        private void btnGetRoutes_Click(object sender, EventArgs e)
        {
            var routes = client.GetRoutes(textSource.Text, textDestination.Text);
           
            lblRoute.Text = string.Join(" -> ", routes.ToList());
            
        }

        private void Source_Click(object sender, EventArgs e)
        {

        }
    }
}
