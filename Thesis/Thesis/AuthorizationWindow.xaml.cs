using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Thesis
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void FormWithClasses(object sender, RoutedEventArgs e)
        {
            var group = Group.Text;
            var fullName = FullName.Text;
            bool isCheck = false;
            if (group == "")
            {
                ErrorGroup.Content = "Введите группу";
                isCheck = true;
            }
            else
                ErrorGroup.Content = "";
            if (fullName == "")
            {
                ErrorFullName.Content = "Введите ФИО";
                isCheck = true;
            }
            else
                ErrorFullName.Content = "";
            if (isCheck)
                return;
            MaterialsWindow mainWindow = new MaterialsWindow(fullName,group,DateTime.Now);
            mainWindow.Show();
            this.Close();
        }
    }
}
