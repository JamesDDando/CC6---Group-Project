using MVVMWPFCRUD.ViewModel;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVMWPFCRUD.View
{
    public partial class CC6Members : ContentPage
    {
        public CC6Members()
        {
            InitializeComponent();
            this.DataContext = new StudentViewModel();

        }
    }
}
