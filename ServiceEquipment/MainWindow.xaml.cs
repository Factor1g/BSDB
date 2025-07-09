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

namespace ServiceEquipment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceEquipmentDbContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new ServiceEquipmentDbContext();
            LoadTableSelector();
        }

        private void LoadTableSelector()
        {
            TableSelector.Items.Add("Alvallalkozoks");
            TableSelector.Items.Add("Belimos");
            TableSelector.Items.Add("Berendezeseks");
            TableSelector.Items.Add("Csapadekvizs");
            TableSelector.Items.Add("Csovezetekeks");
            // Add all other table names you need
        }

        private void TableSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadSelectedTableData();
        }

        private void LoadSelectedTableData()
        {
            string selectedTable = TableSelector.SelectedItem as string;
            if (selectedTable == null) return;

            switch (selectedTable)
            {
                case "Alvallalkozoks":
                    DataGridView.ItemsSource = _context.Alvallalkozoks.ToList();
                    break;
                case "Belimos":
                    DataGridView.ItemsSource = _context.Belimos.ToList();
                    break;
                    // Add similar cases for other tables
            }
        }

        private void SearchBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string search = SearchBox.Text?.ToLower();
            string selectedTable = TableSelector.SelectedItem as string;
            if (selectedTable == null || string.IsNullOrWhiteSpace(search)) return;

            switch (selectedTable)
            {
                case "Alvallalkozoks":
                    DataGridView.ItemsSource = _context.Alvallalkozoks
                        .Where(x => x.Nev.ToLower().Contains(search) || x.Terulet.ToLower().Contains(search))
                        .ToList();
                    break;
                case "Belimos":
                    DataGridView.ItemsSource = _context.Belimos
                        .Where(x => x.Cikkszam.ToLower().Contains(search) || x.Leiras.ToLower().Contains(search))
                        .ToList();
                    break;
                    // Add search logic for other tables as needed
            }
        }
    }
}
