using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using DataAccess;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Model;


namespace ServiceEquipment
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();
            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // Register your services here
            services.AddDbContext<ServiceEquipmentDbContext>(options =>
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ServiceEquipmentDB;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IGenericDataService<>), typeof(GenericDataService<>));
            services.AddSingleton<IDataServiceFactory, DataServiceFactory>();
            services.AddScoped<IGenericDataService<Model.Belimo>, GenericDataService<Model.Belimo>>();
            //services.AddScoped<IGenericDataService<Model.Csovezetekek>, GenericDataService<Model.Csovezetekek>>();


            services.AddSingleton<MainWindow>();
        }
    }

}
