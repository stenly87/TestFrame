using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp4
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Page currentPage;

        public Command FirstPage { get; set; }
        public Command SecondPage { get; set; }
        public Command ThirdPage { get; set; }

        public Page CurrentPage { get => currentPage; set { currentPage = value; RaiseEvent(); } }

        public ViewModel()
        {
            FirstPage = new Command(() =>
            {
                CurrentPage = new Page1();
            });
            SecondPage = new Command(() =>
            {
                CurrentPage = new Page2();
            });
            ThirdPage = new Command(() =>
            {
                CurrentPage = new Page3();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaiseEvent([CallerMemberName] string prop = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
