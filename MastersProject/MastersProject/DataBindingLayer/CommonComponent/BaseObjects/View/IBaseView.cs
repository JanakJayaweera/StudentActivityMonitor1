using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastersProject.DataBindingLayer.CommonComponent.BaseObjects.Presenter;

namespace MastersProject.DataBindingLayer.CommonComponent.BaseObjects.View
{
    public interface IBaseView
    {
        ResultType FormStatus { set; }
        int SetFocusRow { set; }
        int GetUpdatedRow { get; }
        string SetUpdateModel { get; set; }
    }
}
