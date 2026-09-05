using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpstrapper.UI.ViewModels.Settings;

namespace Sharpstrapper.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for SharpstrapperPage.xaml
    /// </summary>
    public partial class SharpstrapperPage
    {
        public SharpstrapperPage()
        {
            DataContext = new SharpstrapperViewModel();
            InitializeComponent();
        }
    }
}

