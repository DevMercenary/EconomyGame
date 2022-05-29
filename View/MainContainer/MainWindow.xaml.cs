using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using EconomyGame.ViewModels.MainContainer;
using HandyControl.Controls;
using HandyControl.Themes;
using HandyControl.Tools;
using Microsoft.Extensions.DependencyInjection;

namespace EconomyGame.View.MainContainer
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //TODO: ЗАКЛАДКА #2 ===> Подключение модели представления.
            DataContext = App.Current.services.GetService<MainViewModel>();
        }
    }
}
