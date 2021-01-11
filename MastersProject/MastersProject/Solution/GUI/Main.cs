using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MastersProject.DataBindingLayer.View;
using MastersProject.DomainLayer;
using MastersProject.DataBindingLayer.Presenter;

namespace MastersProject
{
    public partial class Form1 : Form, IApplicationsView
    {
        ApplicationsPresenter applicationsPresenter;
        string btnStatus;

        public Form1()
        {
            InitializeComponent();
            applicationsPresenter = new ApplicationsPresenter(this);
        }

        public string Status
        {
            get
            {
                return btnStatus;
            }
            
        }

        List<Item> IApplicationsView.ApplicationList
        {
            get
            {
                return (List<Item>)gridControlApplications.DataSource;
            }
            set
            {
                gridControlApplications.DataSource = value;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStatus = "Start";
            applicationsPresenter.LoadApplications();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStatus = "Stop";
        }
    }
}
