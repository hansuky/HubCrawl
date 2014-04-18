using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HubCrawl.ViewModels.Account
{
    public class LogInViewModel : Yuhan.WPF.ViewModels.ViewModelBase
    {
        private String _UserID;
        /// <summary>
        /// HubCrawl User ID
        /// </summary>
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        public String UserID
        {
            get { return _UserID; }
            set
            {
                ChangedPropertyChanged<String>("UserID", ref _UserID, ref value);
            }
        }

        private String _Password;
        /// <summary>
        /// HubCrawl User Password
        /// </summary>
        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        public String Password
        {
            get { return _Password; }
            set
            {
                ChangedPropertyChanged<String>("Password", ref _Password, ref value);
            }
        }

        private Boolean _AutoLogIn;

        public Boolean AutoLogIn
        {
            get { return _AutoLogIn; }
            set { ChangedPropertyChanged<Boolean>("AutoLogIn", ref _AutoLogIn, ref value); }
        }


        private ICommand _LogInCommand;

        public ICommand LogInCommand
        {
            get
            {
                if (_LogInCommand == null)
                {
                    _LogInCommand = new Yuhan.WPF.Commands.RelayCommand(LogIn, CanLogIn);
                }
                return _LogInCommand;
            }
        }

        public Boolean CanLogIn()
        {
            if (!String.IsNullOrEmpty(UserID) && !String.IsNullOrEmpty(Password))
                return true;
            return false;
        }
        public void LogIn()
        { //this.Error = "계정 또는 비밀번호를 잘못 입력하였습니다. 다시한번 확인해주세요."; 
        }
    }
}
