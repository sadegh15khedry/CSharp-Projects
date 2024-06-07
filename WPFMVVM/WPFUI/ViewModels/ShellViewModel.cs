using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFUI.ViewModels;

public class ShellViewModel : Conductor<Object>
{
    public ShellViewModel()
    {
        SetActiveItem();
    }
    public async void SetActiveItem()
    {
        await ActivateItemAsync(new HomeViewModel());
    }

}
