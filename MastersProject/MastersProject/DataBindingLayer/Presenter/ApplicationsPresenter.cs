using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastersProject.DataBindingLayer.View;
using MastersProject.DomainLayer;
using MastersProject.DataBindingLayer.CommonComponent.BaseObjects.Presenter;

namespace MastersProject.DataBindingLayer.Presenter
{
    public class ApplicationsPresenter : BasePresenter<IApplicationsView, Item>
    {
        IApplicationsView _applicationsView;
        int session = 0;

        public ApplicationsPresenter(IApplicationsView applicationsView) : base(applicationsView)
        {
            this._applicationsView = applicationsView;
        }

        public void LoadApplications()
        {
            List<Item> ApplicationList = new List<Item>();
            Process[] processes = Process.GetProcesses();
            
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle != "")
                {
                    ApplicationList.Add(new Item
                    {
                        Name = p.MainWindowTitle,
                        Type = "Application",
                        Time = p.TotalProcessorTime.Days.ToString() + " Days " + p.TotalProcessorTime.Hours.ToString() + " Hr " + p.TotalProcessorTime.Minutes.ToString() + " Min ",
                        Session = session

                    });
                }

            }
            _applicationsView.ApplicationList = ApplicationList.OrderBy(x => x.Name).ToList();
            session++;

            //while (_applicationsView.Status.Equals("Start"))
            //{
            //    if (times != 0)
            //    {
            //        Task.Delay(100).Wait();
            //    }
            //}
        }

    }
}
