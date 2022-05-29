using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EconomyGame.ViewModels.MainContainer
{
    public class MainViewModel : ObservableRecipient
    {
        public MainViewModel()
        {
            Title = "Economy Game by RG";
        }
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
