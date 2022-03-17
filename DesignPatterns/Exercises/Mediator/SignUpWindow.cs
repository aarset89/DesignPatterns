using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Mediator
{
    public class SignUpWindow
    {
        public class UsernameAndPasswordValidationObserver : Observer
        {
            private SignUpWindow _signUpWindow;
            public UsernameAndPasswordValidationObserver(SignUpWindow signUpWindow)
            {
                _signUpWindow = signUpWindow;
            }
            public void Update()
            {
                _signUpWindow.UsernameAndPasswordValidation();
            }
        }

        private TextBox _username = new TextBox();
        private TextBox _password = new TextBox();
        private CheckBox _checkBox = new CheckBox();
        private Button _button = new Button();

        public SignUpWindow()
        {

            _username.AddObserver(new UsernameAndPasswordValidationObserver(this));
            _password.AddObserver(new UsernameAndPasswordValidationObserver(this));
            _checkBox.AddObserver(new UsernameAndPasswordValidationObserver(this));
            //_button.AddObserver(new UsernameAndPasswordValidationObserver(this));
        }

        public void SimulateBehavior()
        {
            Console.WriteLine(_button.GetEnabled());

            _username.SetContent("asda");
            _password.SetContent("qwdas");
            _checkBox.SetChecked(true);

            Console.WriteLine(_button.GetEnabled());

            _username.SetContent("");
            _password.SetContent("qwdas");
            _checkBox.SetChecked(true);

            Console.WriteLine(_button.GetEnabled());
            
            _username.SetContent("adas");
            _password.SetContent("");
            _checkBox.SetChecked(true);

            Console.WriteLine(_button.GetEnabled());
            
            _username.SetContent("");
            _password.SetContent("");
            _checkBox.SetChecked(true);

            Console.WriteLine(_button.GetEnabled());
            
            _username.SetContent("asdas");
            _password.SetContent("qwdas");
            _checkBox.SetChecked(false);

            Console.WriteLine(_button.GetEnabled());
            
            _username.SetContent("asdas");
            _password.SetContent("qwdas");
            _checkBox.SetChecked(true);

            Console.WriteLine(_button.GetEnabled());
        }
        private void UsernameAndPasswordValidation()
        {
            var usrname = _username.GetContent();
            var password = _password.GetContent();
            var chkbox = _checkBox.IsChecked();
            if(!string.IsNullOrWhiteSpace(usrname) && !string.IsNullOrWhiteSpace(password) && chkbox)
                _button.SetEnabled(true);
            else _button.SetEnabled(false);
        }

        //private void CheckBoxValidation()
        //{
        //    if(_checkBox.IsChecked())
        //        _button.SetEnabled()
        //}
    }
}
