using System.Collections;
using System.Web.Mvc;

namespace Infobox.ViewModels
{
    public class MySelectList : SelectList
    {
        public MySelectList()
            : base(new SelectListItem[] {})
        {
        }

        public MySelectList(IEnumerable items)
            : base(items)
        {
        }

        public MySelectList(IEnumerable items, object selectedValue)
            : base(items, null, null, selectedValue)
        {
        }

        public MySelectList(IEnumerable items, string dataValueField, string dataTextField)
            : base(items, dataValueField, dataTextField, null)
        {
        }

        public MySelectList(IEnumerable items, string dataValueField, string dataTextField, object selectedValue)
            : base(items, dataValueField, dataTextField, selectedValue)
        {
        }
    }
}