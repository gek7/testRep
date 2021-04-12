using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp1
{
    public class UserModel : INotifyPropertyChanged
    {
        private readonly ObservableCollection<User> _myUsers = new ObservableCollection<User>();
        public readonly ReadOnlyObservableCollection<User> MyUsers;
        public event PropertyChangedEventHandler PropertyChanged;
        public UserModel()
        {
            MyUsers = new ReadOnlyObservableCollection<User>(_myUsers);
        }

        public void AddValue(User u)
        {
            _myUsers.Add(u);
        }

        public void RemoveValue(User u)
        {
            _myUsers.Remove(u);
        }
    }
}
