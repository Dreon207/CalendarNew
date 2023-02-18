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
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace Calendari
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = @"C:\\Users\\Fetis\\Desktop\\f.json";


            if (File.Exists(path))
            {
                string txt = File.ReadAllText(path);
            }
            else
            {
                File.Create(path);
            }
        }
        
       

    }
}
