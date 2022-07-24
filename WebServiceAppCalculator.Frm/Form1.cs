using WebServiceAppCalculatorReference;

namespace WebServiceAppCalculator.Frm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.AddAsync(numericUpDownS1.Value, numericUpDownS2.Value);
            MessageBox.Show(result.ToString());
        }

        private async void buttonSub_Click(object sender, EventArgs e)
        {
            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.SubtractAsync(numericUpDownS1.Value, numericUpDownS2.Value);
            MessageBox.Show(result.ToString());
        }

        private async void buttonMyltiply_Click(object sender, EventArgs e)
        {
            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.MultiplyAsync(numericUpDownS1.Value, numericUpDownS2.Value);
            MessageBox.Show(result.ToString());
        }

        private async void buttonDivide_Click(object sender, EventArgs e)
        {
            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.DivideAsync(numericUpDownS1.Value, numericUpDownS2.Value);
            MessageBox.Show(result.ToString());
        }

        private async void buttonExpo_Click(object sender, EventArgs e)
        {

            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.ExponentiationAsync(Convert.ToInt32(numericUpDownS1.Value), Convert.ToInt32(numericUpDownS2.Value));
            MessageBox.Show(result.ToString());
        }

        private async void buttonMax_Click(object sender, EventArgs e)
        {
            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.FindMaxAndEqualAsync(numericUpDownS1.Value, numericUpDownS2.Value);
            MessageBox.Show(result.ToString());
        }

        private async void buttonMin_Click(object sender, EventArgs e)
        {
            WebServiceAppCalculatorSoapClient client = new WebServiceAppCalculatorSoapClient(WebServiceAppCalculatorSoapClient.EndpointConfiguration.WebServiceAppCalculatorSoap);
            var result = await client.FindMinAndEqualAsync(Convert.ToDouble(numericUpDownS1.Value), Convert.ToDouble(numericUpDownS2.Value));
            MessageBox.Show(result.ToString());

        }
    }
}

