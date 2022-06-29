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
    /// Logika interakcji dla klasy SzczegolyGrupy.xaml
    /// </summary>
    public partial class SzczegolyGrupy : Window
    {
        public SzczegolyGrupy(XmlNode grupa)
        {
            DataContext = grupa;
            InitializeComponent();
        }
    }
}
