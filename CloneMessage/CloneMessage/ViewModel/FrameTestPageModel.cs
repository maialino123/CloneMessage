using CloneMessage.Model;
using CloneMessage.Services;
using CloneMessage.Services.IService;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CloneMessage
{
    public class FrameTestPageModel : FreshBasePageModel
    {

        public ObservableCollection<CouponModel> ListCoupons1 { get; set; }
        public ObservableCollection<CouponModel> ListCoupons2 { get; set; }
        public string TargetScroll { get; set; } = "abcdsahfsaohnd";


        private readonly IDataService<CouponModel> _dataService;

        public FrameTestPageModel(IDataService<CouponModel> dataService)
        {

            _dataService = dataService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            var ListCoupons = new ObservableCollection<CouponModel>(_dataService.GetAll());
            ListCoupons1 = new ObservableCollection<CouponModel>(ListCoupons);
        }
    }
}
