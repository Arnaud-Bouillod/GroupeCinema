﻿using GroupeCinema.Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfGroupeCinema.ViewModel;

namespace WpfGroupeCinema.Views
{
    /// <summary>
    /// Interaction logic for HomeCinemaEnterView.xaml
    /// </summary>
    public partial class HomeCinemaEnterView : Page
    {
        private HomeCinemaEnterViewModel homeCinemaEnterViewModel;
        private Cinema cinema;

        public HomeCinemaEnterViewModel HomeCinemaEnterViewModel
        {
            get { return homeCinemaEnterViewModel; }
            set { homeCinemaEnterViewModel = value; }
        }


        public HomeCinemaEnterView()
        {
            InitializeComponent();
            this.homeCinemaEnterViewModel = new HomeCinemaEnterViewModel(this);
        }

        public HomeCinemaEnterView(Cinema cinema)
        {
            InitializeComponent();
            this.homeCinemaEnterViewModel = new HomeCinemaEnterViewModel(this);
            this.cinema = cinema;
            HomeCinemaEnterViewModel.HomeCinemaEnterView.cinemaUserControl.Cinema = cinema;
            HomeCinemaEnterViewModel.HomeCinemaEnterView.homeUserControl.BtnHome.Click += BtnNavigate_Click;
            HomeCinemaEnterViewModel.HomeCinemaEnterView.homeCinemaUserControl.BtnMovie.Click += BtnMovies_Click;
            HomeCinemaEnterViewModel.HomeCinemaEnterView.homeCinemaUserControl.BtnManagement.Click += BtnManagement_Click;
            HomeCinemaEnterViewModel.HomeCinemaEnterView.homeCinemaUserControl.BtnProducts.Click += BtnProducts_Click;
        }

    

        private void BtnProducts_Click(object sender, RoutedEventArgs e)
        {
            if (this.cinema != null)
            {
                this.NavigationService.Navigate(new ProductEnterView(this.cinema));
            }
        }

        private void BtnMovies_Click(object sender, RoutedEventArgs e)
        {
            if (this.cinema != null)
            {
                this.NavigationService.Navigate(new MovieEnterView(this.cinema));
            }
        }

        private void BtnManagement_Click(object sender, RoutedEventArgs e)
        {
            if (this.cinema != null)
            {
                this.NavigationService.Navigate(new ManagementEnterView(this.cinema));
            }
        }

        private void BtnNavigate_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want go to home ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new HomeEnterView());
            }
        }
    }
}
