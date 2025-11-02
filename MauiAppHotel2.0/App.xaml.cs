namespace MauiAppHotel2._0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Sobre());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var windon = base.CreateWindow(activationState);

            windon.Width = 400;
            windon.Height = 600;


            return windon;
        }
    }
}