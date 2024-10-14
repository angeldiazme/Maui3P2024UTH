namespace Maui3P2024UTH
{
    public partial class App : Application
    {
        static Controlles.DBServices dBServices;
        
        public static Controlles.DBServices DataBase
        {
            get
            {
                if (dBServices == null)
                {
                    dBServices = new Controlles.DBServices();
               
                }

                return dBServices;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageInit());
        }
    }
}
