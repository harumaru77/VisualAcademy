using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public partial class About
    {
        private readonly string title = "정보";

        private string subTitle = "사이트 정보";

        public string SubTitle
        {
            get { return subTitle; }
            set { subTitle = value; }
        }

        protected override void OnInitialized()
        {
            subTitle = DateTime.Now.ToLongTimeString();
        }
    }
}
