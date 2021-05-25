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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Thesis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MaterialsWindow : Window
    {
        public MaterialsWindow(string fullName,string group,DateTime entryTime)
        {
            InitializeComponent();
            var topic = Constant.Constant.Topic;
            for (int i = 0; i < topic.Count; i++)
                topics.Items.Add(topic[i]);
            var content = Constant.Constant.Content;
            for (int i = 0; i < content.Count; i++)
                contents.Items.Add(content[i]);

        }
    }
}
