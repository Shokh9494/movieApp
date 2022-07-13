using movieApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace movieApp.ViewModels
{
    public class MainViewModel:BindableObject
    {

        private INetworkService1 _networkService;
        public MainViewModel(INetworkService1 networkService)
        {
            _networkService=networkService;
            OnPropertyChanged("Items");
            getMovieData();

        }

        private async void getMovieData()
        {
            var result = await _networkService.GetAsync<RootObject>(Constans.GetMoviesUri("avengers"));
            Items=new ObservableCollection<MovieData>(result.Search.Select(x=> new MovieData (x.Title,x.Poster)));
            OnPropertyChanged("Items");

            
        }

        public ObservableCollection<MovieData> Items
    {
            get;
            set;
    }




    }


}

