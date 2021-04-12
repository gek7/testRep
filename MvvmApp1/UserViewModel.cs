using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp1
{
    public class UserViewModel : INotifyPropertyChanged
    {
        readonly UserModel _model = new UserModel();
        public event PropertyChangedEventHandler PropertyChanged;
        public ReadOnlyObservableCollection<User> MyUsers { get; set; }

        public UserViewModel()
        {
            _model.PropertyChanged += (s, e) => PropertyChanged(this, e);
            MyUsers = new ReadOnlyObservableCollection<User>(_model.MyUsers);
        }
    }
}
