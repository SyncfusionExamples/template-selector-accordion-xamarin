using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AccordionXamarin
{
    #region AccordionTemplateSelector
    public class AccordionTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate CustomTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (item as ItemInfo).ID % 2 == 0 ? CustomTemplate : DefaultTemplate;
        }
    }
    #endregion
}
