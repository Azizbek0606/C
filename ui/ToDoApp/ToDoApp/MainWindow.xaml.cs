using System.Collections.ObjectModel;
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

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            Students = new ObservableCollection<Student>();

            var faculties = new[] { "Engineering", "Business", "Law", "Medicine" };
            var genders = new[] { "Male", "Female" };

            var random = new Random();

            for (int i = 1; i <= 20; i++) // 20 ta student yaratamiz
            {
                Students.Add(new Student
                {
                    FirstName = $"Student {i}",
                    LastName = $"LastName {i}",
                    Age = random.Next(18, 25),
                    Faculty = faculties[random.Next(faculties.Length)],
                    Gender = genders[random.Next(genders.Length)]
                });
            }

            DataContext = this;
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
        public string Gender { get; set; }
    }

}
