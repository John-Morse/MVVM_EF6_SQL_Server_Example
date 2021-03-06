﻿namespace MVVM_EF6.View
{
    using MVVM_EF6.ViewModel;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IClosable
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => 
            {
                ViewModelLocator.Cleanup();

                log.Info("Application Closing");
            };
        }
    }
}
