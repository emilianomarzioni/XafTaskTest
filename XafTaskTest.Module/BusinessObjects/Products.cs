using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Xpo.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafTasks.Module.BusinessObjects
{
    [Persistent("LegacyProducts")]
    [DefaultClassOptions]
    public class Product : XPLiteObject
    {
        public Product(Session session)
            : base(session)
        {
        }
      
        string name = "";
        string description = "";
        Category category;
        Guid fkey;
        [Key(AutoGenerate = true), Browsable(false)]
        public Guid _Key
        {
            get { return fkey; }
            set { SetPropertyValue<Guid>(nameof(_Key), ref fkey, value); }
        }

        [Persistent("Name")]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue<string>(nameof(Name), ref name, value); }
        }
        [Persistent("Category")]
        [Association("Category-Products")]
        public Category Category
        {
            get { return category; }
            set { SetPropertyValue<Category>(nameof(Category), ref category, value); }
        }
        [Persistent("Description")]
        public string Description
        {
            get { return description; }
            set { SetPropertyValue<string>(nameof(Description), ref description, value); }
        }

    }
    
}