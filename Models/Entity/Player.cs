using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EconomyGame.Models.Entity
{
    public class Player : ObservableObject
    {
        private Guid _id;
        private string _name;
        private int _level;
        private int _exp;
        public Guid Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public int Level
        {
            get => _level;
            set => SetProperty(ref _level, value);
        }
        public int Exp
        {
            get => _exp;
            set => SetProperty(ref _exp, value);
        }
    }
}
