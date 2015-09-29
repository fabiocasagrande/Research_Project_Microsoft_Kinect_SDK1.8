//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;

[assembly: CLSCompliant(true)]

namespace Microsoft.Samples.Kinect.Avateering
{



    //using ControlsBasics;
    using System.Windows;
    using System.Threading;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
   
 
        /// <summary>
        /// The base XNA program.
        /// </summary>
        /// public  Window1 bGround= new Window1();

   
    
    
    public  class Program //: ControlsBasics.MainWindow
        {
            /// <summary>
            /// This method starts the game cycle.
            /// </summary>
            /// 

            static ControlsBasics.App customizeMenu;
            static AvateeringXNA game;
            static SplashScreen splash = null;

            public static  String av1;
            public static String av2;
            public static String sc;
       
         

          
           
            

            [STAThread()]
              static void Main()
            
            {
             

             
               


                /**
                //initialize Thread for Custom menu
                var tCustomize = new Thread(new ThreadStart(() =>{ customizeMenu = new ControlsBasics.App(); customizeMenu.InitializeComponent(); customizeMenu.Run(); })); tCustomize.SetApartmentState(ApartmentState.STA);
                //initialize Thread for Avatar Game 
                var tPlay = new Thread(new ThreadStart(() =>{ game = new AvateeringXNA(); game.Run(); }));tPlay.SetApartmentState(ApartmentState.STA);
                **/
                
                 splash = new SplashScreen("images/title.png");
                splash.Show(true);            
               


                customizeMenu = new ControlsBasics.App(); 
                customizeMenu.InitializeComponent();


          
                    customizeMenu.Run();
             

                
                Class2 data = Class2.stance();

                 av1 =data.av1;

               av2=data.av2;

               sc=data.sc;


               game = new AvateeringXNA(); 
               game.Run();



            }

            public String A_v1()
            {
                return av1;
            }

            public String A_v2()
            {
                return av2;
            }

            public String S_C()
            {
                return sc;
            }


      

          
        
        }
    }
