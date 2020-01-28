using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestBugIsRefreshing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab : TabbedPage
    {
        public Tab()
        {
            InitializeComponent();

            Children.Add(new List());
        }
    }
}