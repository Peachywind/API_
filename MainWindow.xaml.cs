
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Net.Http;

namespace API
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           /* LoadProvincesAsync();*/
        }

       /* private void LoadProvincesAsync()
        {
            var modelWrapper = new ModelDataGridWrapper<Root>(Location=>Location);
            var result = modelWrapper.LoadProvincesAsync();
           


        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApiHelper.Get(Sity.Text);

        }
    }
}
