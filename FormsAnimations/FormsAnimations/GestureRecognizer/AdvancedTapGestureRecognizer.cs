﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace FormsAnimations.GestureRecognizer
{
    public class AdvancedTapGestureRecognizer : IGestureRecognizer
    {

        #region Property Changed
        
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion


        private ICommand _command;
        public ICommand Command
        {
            get { return _command; }
            set
            {
                if (_command == value)
                {
                    return;
                }

                OnPropertyChanged();
                _command = value;
            }
        }
    }
}
