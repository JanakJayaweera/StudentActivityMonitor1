using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastersProject.DataBindingLayer.CommonComponent.BaseObjects.View;

namespace MastersProject.DataBindingLayer.CommonComponent.BaseObjects.Presenter
{
    /// <summary>
    /// Base Peresenter Contain : All Common methods and attribute related to presenters.
    /// </summary>
    /// <typeparam name="TView">related view(Inteface object) object type</typeparam>
    public abstract class BasePresenter<TView, TModel>
    {
        /// <summary>
        /// All private windows
        /// </summary>
        private readonly TView _view;

        /// <summary>
        /// base presenter: ctor
        /// </summary>
        /// <param name="view"> Type model</param>
        public BasePresenter(TView view)
        {
            _view = view;

        }

       

    }

    /// <summary>
    /// Form Result Type enum
    /// </summary>
    public enum ResultType
    {
        None = 0,
        OK = 1,
        Cancel = 2,
    }

    public class AttributeInfo
    {
        public string MemberName { get; set; }
        public string Description { get; set; }
    }
}
