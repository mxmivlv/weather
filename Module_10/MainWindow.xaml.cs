using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Module_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Weather> ObjWeather = new ObservableCollection<Weather>();
        List<Weather> listweather = new List<Weather>();
        Weather weather;
        Method method = new Method();

        private string currenturl; //Текущий адрес
        private string currentcity; //Текущий город
        private string currentJsonFile; //Текущий фаил для записи
        private string currentFile; //Текущий сформированный фаил
        public MainWindow()
        {
            InitializeComponent();
            Closing +=MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            currentJsonFile = method.SaveJsonFile(listweather);
            method.SaveFilePC(currentJsonFile);
        }

        private void ComboBoxCity_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            currentcity = ComboBoxCity.SelectedValue.ToString();
        }

        private void Weather_Click(object sender, RoutedEventArgs e)
        {
            currenturl = method.City(currentcity);
            currentFile = method.RequestWebsite(currenturl);
            method.CreateJsonFile(currentFile, out ObjWeather, out weather);
            listweather.Add(weather);
            Water_Messages.Items.Add(ObjWeather);
        }
    }
}
