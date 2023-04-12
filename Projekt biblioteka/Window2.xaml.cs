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
using Projekt_biblioteka;
using System.IO;
using System.Diagnostics;

namespace Projekt_biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        //private Window2 lstValue;

        public Window2(MainWindow mainWindow)
        {
            InitializeComponent();


        }



        //Dodawanie do ListBoxa

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            
            if (string.IsNullOrEmpty(TitleBox.Text))
               
                return;
            if (string.IsNullOrEmpty(PublishBox.Text))
                return;

            mainWindow.list_Box.Items.Add($"Tytuł: {TitleBox.Text} \nWydawnictwo: {PublishBox.Text}");

            if (mainWindow.list_Box.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("lista.txt"))
                {
                    foreach (string itemText in mainWindow.list_Box.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }

               // Process.Start("lista.txt");
            }



            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
