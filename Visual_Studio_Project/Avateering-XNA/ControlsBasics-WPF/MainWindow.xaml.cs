//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------


namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Toolkit;
    using Microsoft.Kinect.Toolkit.Controls;
    using System.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Controls;
    using System.Collections.Generic;
    using database1;
    

    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow
    {
        public static readonly DependencyProperty PageLeftEnabledProperty = DependencyProperty.Register(
            "PageLeftEnabled", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));

        public static readonly DependencyProperty PageRightEnabledProperty = DependencyProperty.Register(
            "PageRightEnabled", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));

        private const double ScrollErrorMargin = 0.001;

        private const int PixelScrollByAmount = 20;

        private SoundPlayer play= new SoundPlayer();
        private SoundPlayer playOver = new SoundPlayer();
      
        private Dictionary<string, string> Name_and_Path;
        private Dictionary<string, string> NameKid;
        private string tempPath = "";
  
        private readonly KinectSensorChooser sensorChooser;

        public Image buttonImage;



        

        public Stack<string> stackAv1 = new Stack<string>();
        public Stack<string> stackAv2 = new Stack<string>();
        public Stack<string> stackSce = new Stack<string>();

        public string tempName="";
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class. 
        /// </summary>
        public MainWindow()
        {
          
            this.InitializeComponent();
            this.WindowState = WindowState.Maximized;
           // this.WindowStyle = WindowStyle.None;
            // initialize the sensor chooser and UI
            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();

            // Bind the sensor chooser's current sensor to the KinectRegion
            var regionSensorBinding = new Binding("Kinect") { Source = this.sensorChooser };
            BindingOperations.SetBinding(this.kinectRegion, KinectRegion.KinectSensorProperty, regionSensorBinding);


            Name_and_Path= new Dictionary<string,string>();
            Name_and_Path["Willie1"] = "avatars/bodies/kid1.png";
            Name_and_Path["Jake1"] = "avatars/bodies/kid2.png";
            // Name_and_Path["Tom"] = "avatars/bodies/kid3.png";
            Name_and_Path["Darnell1"] = "avatars/bodies/kid4.png";
            Name_and_Path["Scott1"] = "avatars/bodies/kid5.png";
            Name_and_Path["Kelly1"] = "avatars/bodies/kid6.png";
            Name_and_Path["Jada1"] = "avatars/bodies/kid7.png";
            Name_and_Path["Maria1"] = "avatars/bodies/kid8.png";
            Name_and_Path["Emma1"] = "avatars/bodies/kid9.png";
            Name_and_Path["Jenna1"] = "avatars/bodies/kid10.png";
            Name_and_Path["David1"] = "avatars/bodies/kid11.png";
            Name_and_Path["Ariel1"] = "avatars/bodies/kid12.png";
            Name_and_Path["Darryl1"] = "avatars/bodies/kid13.png";
            Name_and_Path["Fred1"] = "avatars/bodies/kid14.png";
            Name_and_Path["John1"] = "avatars/bodies/kid15.png";
            Name_and_Path["Tierra1"] = "avatars/bodies/kid16.png";
            Name_and_Path["Caitlin1"] = "avatars/bodies/kid17.png";
            Name_and_Path["Lisa1"] = "avatars/bodies/kid18.png";
            Name_and_Path["Ju1"] = "avatars/bodies/kid19.png";
            Name_and_Path["Anita1"] = "avatars/bodies/kid20.png";
            
            Name_and_Path["Willie"] = "avatars/bodies/kid1.png";
            Name_and_Path["Jake"] = "avatars/bodies/kid2.png";
           // Name_and_Path["Tom"] = "avatars/bodies/kid3.png";
            Name_and_Path["Darnell"] = "avatars/bodies/kid4.png";
            Name_and_Path["Scott"] = "avatars/bodies/kid5.png";
            Name_and_Path["Kelly"] = "avatars/bodies/kid6.png";
            Name_and_Path["Jada"] = "avatars/bodies/kid7.png";
            Name_and_Path["Maria"] = "avatars/bodies/kid8.png";
            Name_and_Path["Emma"] = "avatars/bodies/kid9.png";
            Name_and_Path["Jenna"] = "avatars/bodies/kid10.png";
            Name_and_Path["David"] = "avatars/bodies/kid11.png";
            Name_and_Path["Ariel"] = "avatars/bodies/kid12.png";
            Name_and_Path["Darryl"] = "avatars/bodies/kid13.png";
            Name_and_Path["Fred"] = "avatars/bodies/kid14.png";
            Name_and_Path["John"] = "avatars/bodies/kid15.png";
            Name_and_Path["Tierra"] = "avatars/bodies/kid16.png";
            Name_and_Path["Caitlin"] = "avatars/bodies/kid17.png";
            Name_and_Path["Lisa"] = "avatars/bodies/kid18.png";
            Name_and_Path["Ju"] = "avatars/bodies/kid19.png";
            Name_and_Path["Anita"] = "avatars/bodies/kid20.png";
            Name_and_Path["Cafeteria"] = "scenario/cafeteria.png";
            Name_and_Path["Classroom"] = "scenario/classroom.png";
            Name_and_Path["School Hall"] = "scenario/schoolHall.png";
            Name_and_Path["Library"] = "scenario/library.png";

            NameKid = new Dictionary<string, string>();
            NameKid["Willie"] = "kid1";
            NameKid["Jake"] = "kid2";
           // NameKid["Tom"] = "kid3";
            NameKid["Darnell"] = "kid4";
            NameKid["Scott"] = "kid5";
            NameKid["Kelly"] = "kid6";
            NameKid["Jada"] = "kid7";
            NameKid["Maria"] = "kid8";
            NameKid["Emma"] = "kid9";
            NameKid["Jenna"] = "kid10";
            NameKid["David"] = "kid11";
            NameKid["Ariel"] = "kid12";
            NameKid["Darryl"] = "kid13";
            NameKid["Fred"] = "kid14";
            NameKid["John"] = "kid15";
            NameKid["Tierra"] = "kid16";
            NameKid["Caitlin"] = "kid17";
            NameKid["Lisa"] = "kid18";
            NameKid["Ju"] = "kid19";
            NameKid["Anita"] = "kid20";

            NameKid["Willie1"] = "kid1";
            NameKid["Jake1"] = "kid2";
            // NameKid["Tom"] = "kid3";
            NameKid["Darnell1"] = "kid4";
            NameKid["Scott1"] = "kid5";
            NameKid["Kelly1"] = "kid6";
            NameKid["Jada1"] = "kid7";
            NameKid["Maria1"] = "kid8";
            NameKid["Emma1"] = "kid9";
            NameKid["Jenna1"] = "kid10";
            NameKid["David1"] = "kid11";
            NameKid["Ariel1"] = "kid12";
            NameKid["Darryl1"] = "kid13";
            NameKid["Fred1"] = "kid14";
            NameKid["John1"] = "kid15";
            NameKid["Tierra1"] = "kid16";
            NameKid["Caitlin1"] = "kid17";
            NameKid["Lisa1"] = "kid18";
            NameKid["Ju1"] = "kid19";
            NameKid["Anita1"] = "kid20";

            NameKid["School Hall"] = "schoolHall";
            NameKid["Cafeteria"] = "cafeteria";
            NameKid["Classroom"] = "classroom";
            NameKid["Library"] = "library";



            // Bind listner to scrollviwer scroll position change, and check scroll viewer position
            this.UpdatePagingButtonState();
            scrollViewer11.ScrollChanged += (o, e) => this.UpdatePagingButtonState();
            scrollViewer1.ScrollChanged += (o, e) => this.UpdatePagingButtonState();
            scrollViewer3.ScrollChanged += (o, e) => this.UpdatePagingButtonState();
        }






        /// <summary>
        /// CLR Property Wrappers for PageLeftEnabledProperty
        /// </summary>
        public bool PageLeftEnabled
        {
            get
            {
                return (bool)GetValue(PageLeftEnabledProperty);
            }

            set
            {
                this.SetValue(PageLeftEnabledProperty, value);
            }
        }

        /// <summary>
        /// CLR Property Wrappers for PageRightEnabledProperty
        /// </summary>
        public bool PageRightEnabled
        {
            get
            {
                return (bool)GetValue(PageRightEnabledProperty);
            }

            set
            {
                this.SetValue(PageRightEnabledProperty, value);
            }
        }

        /// <summary>
        /// Called when the KinectSensorChooser gets a new sensor
        /// </summary>
        /// <param name="sender">sender of the event</param>
        /// <param name="args">event arguments</param>
        private static void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args)
        {
            if (args.OldSensor != null)
            {
                try
                {
                    args.OldSensor.DepthStream.Range = DepthRange.Default;
                    args.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    args.OldSensor.DepthStream.Disable();
                    args.OldSensor.SkeletonStream.Disable();
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    // E.g.: sensor might be abruptly unplugged.
                }
            }

            if (args.NewSensor != null)
            {
                try
                {
                    args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    args.NewSensor.SkeletonStream.Enable();

                    try
                    {
                        args.NewSensor.DepthStream.Range = DepthRange.Near;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
                    }
                    catch (InvalidOperationException)
                    {
                        // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.
                        args.NewSensor.DepthStream.Range = DepthRange.Default;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    }
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    // E.g.: sensor might be abruptly unplugged.
                }
            }
        }

        /// <summary>
        /// Execute shutdown tasks
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.sensorChooser.Stop();
        }

        /// <summary>
        /// Handle a button click from the wrap panel.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void KinectTileButtonClick(object sender, RoutedEventArgs e)
        {
            
           
            var button = (KinectTileButton)e.OriginalSource;
            //var selectionDisplay = new SelectionDisplay(button.Label as string);
            //this.kinectRegionGrid.Children.Add(selectionDisplay);

            this.tempName = button.Name as string;

            this.tempPath = getImagePath(button.Name as string);
            stackAv1.Push(this.NameKid[tempName]);
            SetImage(tempPath,1);
            e.Handled = true;
        }


        private void SetImage(string path, int but)
        {
            switch (but)
            {
                case 1:
                    image1.BeginInit();
                    image1.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                    image1.EndInit();
                    break;

                case 2:
                     image2.BeginInit();
                     image2.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                     image2.EndInit();
                     break;

                case 3:

                
                     image3.BeginInit();
                     image3.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                     image3.EndInit();
                     break;
                     
            }
         
        
        }

        private void KinectTileButtonClick1(object sender, RoutedEventArgs e)
        {

            var button = (KinectTileButton)e.OriginalSource;

         

           // var selectionDisplay = new SelectionDisplay(button.Label as string);
            //this.kinectRegionGrid.Children.Add(selectionDisplay);
            
     
            this.tempName = button.Name as string;
            this.tempPath = getImagePath(button.Name as string);
            stackAv2.Push(this.NameKid[tempName]);
            SetImage(tempPath, 2);

            e.Handled = true;
        }


        private void KinectTileButtonClick2(object sender, RoutedEventArgs e)
        {

            var button = (KinectTileButton)e.OriginalSource;
            //var selectionDisplay = new SelectionDisplay(button.Label as string);
            //this.kinectRegionGrid.Children.Add(selectionDisplay);
            
            this.tempName = button.Label as string;
            this.tempPath = getImagePath(button.Label as string);
            this.stackSce.Push(this.NameKid[tempName]);
            SetImage(tempPath, 3);

   
            e.Handled = true;
        }

        private void KinectTileButtonClick3(object sender, RoutedEventArgs e)
        {

            var button = (KinectTileButton)e.OriginalSource;
            var selectionDisplay = new SelectionDisplay(button.Label as string);
            this.kinectRegionGrid.Children.Add(selectionDisplay);
            e.Handled = true;
        }








        /// <summary>
        /// Handle paging right (next button).
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        /// 

        private string getImagePath(string n)
        {
      
            return Name_and_Path[n];

        }


        private void PageRightButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.stackAv1.Count == 0)
            {
                this.stackAv1.Push("default");
            }
            if (this.stackAv2.Count == 0)
            {
                this.stackAv2.Push("default");
            }
            if (this.stackSce.Count == 0)
            {
                this.stackSce.Push("default");
            }

            Class2 da_ta = Class2.stance();
            da_ta.av1=this.stackAv1.Pop();
            da_ta.av2=this.stackAv2.Pop();
            da_ta.sc=this.stackSce.Pop();


            this.stackAv1.Clear();
            this.stackAv2.Clear();
            this.stackSce.Clear();

            this.Close();
            
        }

        /// <summary>
        /// Handle paging left (previous button).
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void PageLeftButtonClick(object sender, RoutedEventArgs e)
        {
            scrollViewer11.ScrollToHorizontalOffset(scrollViewer11.HorizontalOffset - PixelScrollByAmount);
            scrollViewer1.ScrollToHorizontalOffset(scrollViewer1.HorizontalOffset + PixelScrollByAmount);
            scrollViewer3.ScrollToHorizontalOffset(scrollViewer3.HorizontalOffset - PixelScrollByAmount);
        }

        /// <summary>
        /// Change button state depending on scroll viewer position
        /// </summary>
        private void UpdatePagingButtonState()
        {
            this.PageLeftEnabled = scrollViewer11.HorizontalOffset > ScrollErrorMargin;
            this.PageLeftEnabled = scrollViewer1.HorizontalOffset > ScrollErrorMargin;
            this.PageLeftEnabled = scrollViewer3.HorizontalOffset > ScrollErrorMargin;
            this.PageRightEnabled = scrollViewer11.HorizontalOffset < scrollViewer11.ScrollableWidth - ScrollErrorMargin;
            this.PageRightEnabled = scrollViewer1.HorizontalOffset < scrollViewer1.ScrollableWidth - ScrollErrorMargin;
            this.PageRightEnabled = scrollViewer3.HorizontalOffset < scrollViewer3.ScrollableWidth - ScrollErrorMargin;
        }

        private void kinectRegionGrid_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
