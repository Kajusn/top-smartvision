using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    public class MenuViewModel : IMenuViewModel
    {
        public string Username { get; set; }
        public Command openFoundCommand { get; }
        public Command openLostCommand { get; }
        public Command userProfileCommand { get; }
        public string Name { get; set; }

        private MenuPage instance;

        public MenuViewModel()
        {
            instance = MenuPage.instance;
            openFoundCommand = new Command(() => OpenFound());
            openLostCommand = new Command(() => OpenLost());
            //userProfileCommand
        }

        private void OpenLost()
        {
            //throw new NotImplementedException();
        }

        private void OpenFound()
        {
            //throw new NotImplementedException();
        }
    }
}
