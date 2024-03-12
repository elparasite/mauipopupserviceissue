using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PopupServiceIssue.ViewModels
{
    public partial class MyPopupViewModel : ObservableObject
    {
        public string Message { get; set; }
    }
}
