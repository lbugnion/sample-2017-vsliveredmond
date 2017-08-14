using Data.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;

namespace HelloAndroid.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// The <see cref="Result" /> property's name.
        /// </summary>
        public const string ResultPropertyName = "Result";

        private string _result = "Nothing yet";

        /// <summary>
        /// Sets and gets the Result property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                Set(() => Result, ref _result, value);
            }
        }

        private RelayCommand _refreshCommand;
        private IYoutubeService _service;

        /// <summary>
        /// Gets the RefreshCommand.
        /// </summary>
        public RelayCommand RefreshCommand
        {
            get
            {
                return _refreshCommand
                    ?? (_refreshCommand = new RelayCommand(
                    async () =>
                    {
                        try
                        {
                            Result = "Please wait...";
                            Result = await _service.Refresh();
                        }
                        catch (Exception ex)
                        {
                            Result = ex.Message;
                        }

                    }));
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IYoutubeService service)
        {
            _service = service;

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}