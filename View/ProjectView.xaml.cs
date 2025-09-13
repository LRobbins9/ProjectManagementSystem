using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectManagementSystem.View
{
    /// <summary>
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : UserControl
    {
        public ProjectView()
        {
            InitializeComponent();
        }

        private void Clear_Form(object sender, RoutedEventArgs e)
        {
            proj_desc_txtbox.Clear();
            owner_name_txtbox.Clear();
            proj_members_txtbox.Clear();
            risks_txtbox.Clear();
            func_req_txtbox.Clear();
            non_func_req_txtbox.Clear();
        }
    }
}
