using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Twainsoft.CodeSharer.VSPackage.GUI
{
    [Guid("9599ef85-2ac0-4dfe-9e0f-e83a812102db")]
    public class SharedListingsToolWindow : ToolWindowPane
    {
        public SharedListingsToolWindow() : 
            base(null)
        {
            Caption = Resources.ToolWindowTitle;

            BitmapResourceID = 301;
            BitmapIndex = 1;

            base.Content = new SharedListingsToolWindowView();
        }
    }
}
