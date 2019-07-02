using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SeriesListPrism.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeriesListPrism.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase
    {
        private Serie serie;
        public Serie Serie
        {
            get { return serie; }
            set { SetProperty(ref serie, value); }
        }

        public DetailsPageViewModel(INavigationService navigationService)
             : base(navigationService)
        {
            Title = "Serie Detail";
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            Serie = (Serie)parameters["model"];
        }

    }
}
