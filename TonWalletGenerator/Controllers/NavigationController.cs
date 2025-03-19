using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TonWalletStudio.Controllers
{
    public sealed class NavigationController
    {
        public static NavigationController Instance { get; } = new NavigationController();

        private NavigationController() { }

        private Frame? mainFrame;

        public void SetMainFrame(Frame frame)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));
            mainFrame = frame;
        }

        public void NavigateToPage(Page page)
        {
            if(mainFrame == null) 
                throw new InvalidOperationException("MainFrame is not initialized");
            mainFrame.Navigate(page);
        }
        public bool GoBack()
        {
            if (mainFrame == null)
                throw new InvalidOperationException("MainFrame is not initialized");

            if (mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
                return true;
            }
            return false;
        }


    }
}
