namespace WebViewMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //webView.Source = new HtmlWebViewSource
            //{
            //    Html = @"
            //<html>
            //<body>
            //<h1>Hello</h1>
            //<script type=""text/javascript"">
            //function factorial(num) {
            //        if (num === 0 || num === 1)
            //            return 1;
            //        for (var i = num - 1; i >= 1; i--) {
            //            num *= i;
            //        }
            //        return num;
            //}
            //</script>
            //</body>
            //</html>
            //"
            //};

            webView.Source = "http://bafsd.osl.team/";
        }

        

        private async void Calculate_Clicked(object sender, EventArgs e)
        {
            int number = 10;
            string result = await webView.EvaluateJavaScriptAsync($"factorial({number})");

            await DisplayAlert("MAUI WebView", $"Factorial of {number} is {result}.", "OK");
        }
    }
}