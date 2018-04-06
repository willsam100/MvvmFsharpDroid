namespace MvvmFormsAppFsharp.Droid

open System
open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget
open MvvmCross.Forms.Platform
open MvvmCross.Platform
open MvvmCross.Core.Views
open MvvmCross.Core.ViewModels;
open Android.App;
open Android.Content;
open Android.OS;
open Android.Runtime;
open Android.Views;
open Android.Widget;
open Android.Content.PM;
open Xamarin.Forms
open Xamarin.Forms.Platform.Android

open Android.Content;
open MvvmCross.Core.ViewModels;
open MvvmCross.Platform.Platform;
open MvvmCross.Forms.Droid.Platform;
open MvvmCross.Forms.Platform;
open MvvmFormsApp
open System.Diagnostics

// the name of the type here needs to match the name inside the ResourceDesigner attribute
type Resources = MvvmFormsAppFsharp.Droid.Resource
[<assembly: Android.Runtime.ResourceDesigner("MvvmFormsAppFsharp.Droid.Resources", IsApplication=true)>]
()

type DebugTrace() = 

    interface IMvxTrace with 
        member this.Trace(level: MvxTraceLevel, tag:string , message: Func<string>) = 
            Debug.WriteLine(tag + ":" + (string level) + ":" + message.Invoke());
        
        member this.Trace(level:MvxTraceLevel, tag:string, message:string) = 
            Debug.WriteLine(tag + ":" + (string level) + ":" + message);
        
        member this.Trace(level:MvxTraceLevel, tag:string , message:string, [<ParamArray>] args: Object[]) = 
            try
                Debug.WriteLine(tag + ":" + (string level) + ":" + message, args);
            with 
            | :? FormatException -> ()
                //this.Trace(MvxTraceLevel.Error, tag, "Exception during trace of 0 1");
            

type Setup(applicationContext: Context ) = 
    inherit MvxFormsAndroidSetup(applicationContext) 

    override this.CreateFormsApplication(): MvxFormsApplication =    
        new Core.App() :> MvxFormsApplication
    
    override this.CreateApp(): IMvxApplication =
        new Core.CoreApp() :> IMvxApplication
    
    override this.CreateDebugTrace(): IMvxTrace  = 
        new DebugTrace() :> IMvxTrace
    

open Android.App;
open Android.Content.PM;
open Android.OS;
open MvvmCross.Forms.Droid.Views;

[<Activity(Label = "MvxFormsApplicationActivity", ScreenOrientation = ScreenOrientation.Portrait)>]
type MainActivity() = 
    inherit MvxFormsAppCompatActivity()

    override this.OnCreate(bundle:Bundle) = 
        base.OnCreate(bundle);
        FormsAppCompatActivity.ToolbarResource <- Resources.Layout.Toolbar
        FormsAppCompatActivity.TabLayoutResource <- Resources.Layout.Tabbar

    
open Android.App;
open Android.Content.PM;
open MvvmCross.Droid.Views;

[<Activity(
    Label = "MvxForms" , MainLauncher = true, Icon = "@drawable/icon" , Theme = "@style/Theme.Splash"
   , NoHistory = true , ScreenOrientation = ScreenOrientation.Portrait)>]
type SplashScreen() = 
   inherit MvxSplashScreenActivity(Resources.Layout.SplashScreen)

    override this.TriggerFirstNavigate() = 
        this.StartActivity(typeof<MainActivity>)
        base.TriggerFirstNavigate()