using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AccordionXamarin
{
    public class ItemInfoRepository
    {
        #region Properties
        public ObservableCollection<ItemInfo> Info { get; set; }
        #endregion

        #region Constructor
        public ItemInfoRepository()
        {
            Info = new ObservableCollection<ItemInfo>();
            Info.Add(new ItemInfo() { ID = 1, Name = "Cheese burger", Description = "Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." });
            Info.Add(new ItemInfo() { ID = 2, Name = "Veggie burger", Description = "Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties." });
            Info.Add(new ItemInfo() { ID = 3, Name = "Barbecue burger", Description = "Consists of a hamburger, with the patty topped with chili con carne." });
            Info.Add(new ItemInfo() { ID = 4, Name = "Chili burger", Description = "Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes." });
        }
        #endregion
    }

    public class ItemInfo
    {
        #region Properties
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        #endregion
    }
}

