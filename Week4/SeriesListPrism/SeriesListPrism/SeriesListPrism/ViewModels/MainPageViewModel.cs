using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SeriesListPrism.Models;
using SeriesListPrism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SeriesListPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISeriesService _seriesService;
        public MainPageViewModel(INavigationService navigationService, ISeriesService seriesService)
            : base(navigationService)
        {
            _seriesService = seriesService;
            Title = "Prism Series";
            SeriesList = new ObservableCollection<Serie>();
            GetSeriesFromAPI();
        }
        private ObservableCollection<Serie> seriesList;
        public ObservableCollection<Serie> SeriesList
        {
            get { return seriesList; }
            set { SetProperty(ref seriesList, value); }
        }

        private Serie serie;
        public Serie Serie
        {
            get { return serie; }
            set
            {
                SetProperty(ref serie, value);
                //Send single object to details
                if (value != null)
                {
                    ViewDetails.Execute();
                }
            }
        }

        private DelegateCommand viewDetails;
        public DelegateCommand ViewDetails =>
            viewDetails ?? (viewDetails = new DelegateCommand(ExecuteViewDetailsAsync));

        async void ExecuteViewDetailsAsync()
        {
            //Go to the next page...
            var parameters = new NavigationParameters();
            parameters.Add("model", Serie);
            await NavigationService.NavigateAsync("DetailsPage", parameters);
        }

        async void GetSeriesFromAPI()
        {
            IsRunning = true;
            var result = await _seriesService.GetAllSeriesAsync();
            IsRunning = false;
            foreach (var item in result)
            {
                SeriesList.Add(item);
            }
        }
    }
}
