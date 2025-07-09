using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using DataAccess;
using BusinessLogic;


namespace ServiceEquipment
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            services.AddDbContext<ServiceEquipmentDbContext>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(GenericDataService<>));
            services.AddSingleton<IDataServiceFactory, DataServiceFactory>();
            services.AddSingleton<MainWindow>();
            ServiceProvider = services.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);


        }
    }

}
