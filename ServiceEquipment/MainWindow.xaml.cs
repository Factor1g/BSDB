using BusinessLogic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccess;
using Model;
using System.Reflection;

namespace ServiceEquipment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataServiceFactory _factory;
        private object _currentService;
        private Type _currentEntityType;

        public MainWindow(IDataServiceFactory factory)
        {
            InitializeComponent();
            _factory = factory;

            // Populate ComboBox with available entities
            EntitySelector.ItemsSource = new List<string>
            {
                "Belimo",
                "Alvallalkozok",
                "Csovezetekek"
            };
        }

        private void EntitySelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EntitySelector.SelectedItem == null)
                return;

            string selected = EntitySelector.SelectedItem.ToString();
            _currentEntityType = ResolveEntityType(selected);
            if (_currentEntityType == null)
            {
                MessageBox.Show($"Type for '{selected}' not found.");
                return;
            }

            _currentService = _factory.GetServiceForType(_currentEntityType);
            if (_currentService == null)
            {
                MessageBox.Show($"No service found for type {_currentEntityType} from {_currentEntityType.Assembly}");
                return;
            }
            MessageBox.Show($"Resolved type: {_currentEntityType?.FullName}");
            LoadAllData();
        }

        private void LoadAllData()
        {
            if (_currentService == null) {
                MessageBox.Show("No data to return");
                return;
            }
            

            var method = _currentService.GetType().GetMethod("GetAll");
            var result = method?.Invoke(_currentService, null) as IEnumerable<object>;
            EntityGrid.ItemsSource = result?.ToList();
            MessageBox.Show($"Loaded {result?.Count()} items.");
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (_currentService == null || _currentEntityType == null) return;

            string search = SearchBox.Text?.Trim().ToLower();
            if (string.IsNullOrEmpty(search))
            {
                LoadAllData();
                return;
            }

            var method = _currentService.GetType().GetMethod("SearchByName");
            var result = method?.Invoke(_currentService, new object[] { search }) as IEnumerable<object>;
            EntityGrid.ItemsSource = result?.ToList();
        }

        private Type ResolveEntityType(string name)
        {
            // Match class name from the Models.Entities namespace
            return Assembly.GetAssembly(typeof(IEntity))
                           ?.GetTypes()
                           .FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
