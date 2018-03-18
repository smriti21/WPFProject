using AvigilonLabManagement.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AvigilonLabManagement.ViewModel
{
    public class LoginUserViewModel : INotifyPropertyChanged
    {

        private string _userName { get; set; }

        private string _password { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginUserViewModel()
        {
            LoginCommand = new CustomCommand(Login, CanLogInCommand);
           
        }


        public string UserName
        {
            get { return _userName; }
            set
            {
                if (!_userName.Equals(value))
                {
                    _userName = value;
                    OnPropertChanged("UserName");
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (!_password.Equals(value))
                {
                    _password = value;
                    OnPropertChanged("Password");
                }
            }
        }

        private void OnPropertChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Login(object userName)
        {
            if (string.IsNullOrEmpty(userName.ToString()))
            {
                MessageBox.Show("Enter Username");
                return;
            }
            //if (string.IsNullOrEmpty(password.ToString()))
            //{
            //    MessageBox.Show("Enter Password");
            //    return;
            //}

            MessageBox.Show("Logged in successfully");
        }

        private bool CanLogInCommand(object obj)
        {
            return obj != null;
        }

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new CustomCommand(
                        param => this.SaveObject(),
                        param => this.CanSave()
                    );
                }
                return _saveCommand;
            }
        }

        private bool CanSave()
        {
            return true;
            // Verify command can be executed here
        }

        private void SaveObject()
        {
            // Save command execution logic
        }
    }
}
