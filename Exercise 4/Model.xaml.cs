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
using System.Xml;

namespace Exercise_4
{
    /// <summary>
    /// Logika interakcji dla klasy Model.xaml
    /// </summary>
    public partial class Model : Window
    {
        public Model(XmlNode grupa)
        {
            DataContext = grupa;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)this.FindName("ListaGrup");
            XmlNode grupa = (XmlNode)lista.SelectedItem;
            if (grupa != null)
                (new SzczegolyGrupy(grupa)).Show();
        }
    }
}
