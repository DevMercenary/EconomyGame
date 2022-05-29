using System;
using System.Windows;
using System.Windows.Media;
using EconomyGame.ViewModels.MainContainer;
using HandyControl.Themes;
using Microsoft.Extensions.DependencyInjection;

namespace EconomyGame
{
    public partial class App : Application
    {
        public IServiceProvider services { get; }
        public App()
        {
            services = ConfigureServices();
        }
        public new static App Current => (App)Application.Current;

        //TODO: ЗАКЛАДКА #1 ===> Регистрация сервисов.
        private static IServiceProvider ConfigureServices()
        {
            
            var services = new ServiceCollection();
            /*
             * Регистрация сервисов Singleton - сервис создается при первом запросе, каждый последующий запрос будет использовать этот же инстанс.
             */

            //services.AddSingleton<IFilesService, FilesService>();

            /*
             * Регистрация сервисов Scoped - сервис создаются единожды для каждого запроса.
             */

            //services.AddScoped<IFilesService, FilesService>(); 


            /*
             * Регистрация сервисов (модели представления) Transient подразумевает, что сервис создается каждый раз, когда его запрашивают.
             * Этот жизненный цикл лучше всего подходит для легковесных, не фиксирующих состояние, сервисов.
             * Наиболее подходит для регистрации модели представления.
             */

            services.AddTransient<MainViewModel>();



            return services.BuildServiceProvider();
        }

        internal void UpdateTheme(ApplicationTheme theme)
        {
            if (ThemeManager.Current.ApplicationTheme != theme)
            {
                ThemeManager.Current.ApplicationTheme = theme;
            }
        }

        internal void UpdateAccent(Brush accent)
        {
            if (ThemeManager.Current.AccentColor != accent)
            {
                ThemeManager.Current.AccentColor = accent;
            }
        }
    }
}
