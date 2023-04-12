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
using System.IO;

namespace Projekt_biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //Otwieranie nowego okna 
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2(this);
            win2.Show();
            
        }



        //Metoda dodajaca item w listbox
        //public void UpdateListBox(Window2 window2)
        //{
        //    TextBox TextBoxItem = new TextBox();
        //    List_Box.Items.Add(TextBoxItem);
            
        //}

        public void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ContentPresenter_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            if (list_Box.Items.Count > 0)
                list_Box.Items.RemoveAt(list_Box.SelectedIndex);

             List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("E:/aPROJEKTY (studia)/Projekt biblioteka/Projekt biblioteka/bin/Debug/lista.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        //Automatyczne załadowanie pliku .txt
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            

        }




    }


}
