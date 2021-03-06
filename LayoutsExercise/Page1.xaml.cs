using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Rectangle r;
        public Page1()
        {
            InitializeComponent();
            r = new Rectangle(0.5, 0.5, box.Width, box.Height);
            AbsoluteLayout.SetLayoutBounds(box, r);
        }

        private void btnLeft_Clicked(object sender, EventArgs e)
        {
            r.X -= 0.1;
            AbsoluteLayout.SetLayoutBounds(box, r);
        }

        private void btnRight_Clicked(object sender, EventArgs e)
        {
            r.X += 0.1;
            AbsoluteLayout.SetLayoutBounds(box, r);
        }

        private void btnUp_Clicked(object sender, EventArgs e)
        {
            r.Y -= 0.1;
            AbsoluteLayout.SetLayoutBounds(box, r);
        }

        private void btnDown_Clicked(object sender, EventArgs e)
        {
            r.Y += 0.1;
            AbsoluteLayout.SetLayoutBounds(box, r);
        }
    }
}