﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IcoGenerator.Source.Core
{
    /// <summary>
    /// An observable object that inherits the INotifyPropertyChanged interface.
    /// </summary>
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The event that fires when a property is changed. 
        /// If called from a member variable (i.e. called from a setter), it automatically determines the variable to update.
        /// </summary>
        /// <param name="name">The name of the property that has been changed.</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            // Check if the name is null, and if it isn't, invoke it.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
