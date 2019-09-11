using AnimalApp.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnimalApp.ViewModel
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private ICommand _selectDogCommand;

        public string Text { get; set; }

        //Command binding property for Button Click
        public ButtonCommandBinding DogClick { get; set; }
        public ButtonCommandBinding DuckClick { get; set; }

        public MainWindowVM()
        {
            //Call the button command binding class to
            //register the button click event with the handler
            DogClick = new ButtonCommandBinding(SelectDog);
            DuckClick = new ButtonCommandBinding(SelectDuck);

            //Enable the button click event
            DogClick.IsEnabled = true;
            DuckClick.IsEnabled = true;
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void SelectDog()
        {
            Dog dog = new Dog();

            string dogClass = dog.useDog(dog);

            Text = dogClass;
            NotifyPropertyChanged("Text");
        }

        private void SelectDuck()
        {
            Duck duck = new Duck();

            string duckClass = duck.useDuck(duck);

            Text = duckClass;
            NotifyPropertyChanged("Text");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}