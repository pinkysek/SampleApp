using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace SampleApp.UWP
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class SampleAppApp : MvxApplication<Setup, Core.App>
    {
    }
}
