using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastersProject.DomainLayer;

namespace MastersProject.DataBindingLayer.View
{
    public interface IApplicationsView
    {
        List<Item> ApplicationList { get; set; }
        string Status { get; }
    }
}
