using MvvmCross.Platform.IoC;
using MvvmCross.Forms.Platform;

namespace MvvmFormsApp.Core
{
	public class CoreApp : MvvmCross.Core.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
		}
	}

	public class App : MvxFormsApplication
	{
		public App()
		{
		}
	}
}
