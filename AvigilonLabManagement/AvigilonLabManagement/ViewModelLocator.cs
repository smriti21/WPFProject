using AvigilonLabManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonLabManagement
{
    public class ViewModelLocator
    {
        private LoginUserViewModel _loginUserViewModel;

        public ViewModelLocator()
        {
            _loginUserViewModel = new LoginUserViewModel();
        }

        public LoginUserViewModel LoginUserViewModel
        {
            get
            {
                if (_loginUserViewModel == null)
                {
                    _loginUserViewModel = new LoginUserViewModel();
                }
                return _loginUserViewModel;
            }
            set
            {
                _loginUserViewModel = value;
            }
        }
    }
}
