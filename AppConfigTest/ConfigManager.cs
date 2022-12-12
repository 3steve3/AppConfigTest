using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigTest
{
    public class DocsToRetrieveSection : ConfigurationSection
    {
        [ConfigurationProperty("DocType")]
        [ConfigurationCollection(typeof(DocTypeCollection))]
        public DocTypeCollection DocTypes
        {
            get
            {
                return (DocTypeCollection)this["DocType"];
            }
        }
    }

    public class DocTypeCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new DocTypeElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((DocTypeElement)element).Name;
        }
    }

    public class DocTypeElement : ConfigurationElement
    {
        [ConfigurationProperty("Name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["Name"];
            }
        }

        [ConfigurationProperty("DocType")]
        public string DocType
        {
            get
            {
                return (string)this["DocType"];
            }
        }

        [ConfigurationProperty("savePath")]
        public string SavePath
        {
            get
            {
                return (string)this["savePath"];
            }
        }

        [ConfigurationProperty("CustomFields")]
        [ConfigurationCollection(typeof(CustomFieldCollection))]
        public CustomFieldCollection CustomFields
        {
            get
            {
                return (CustomFieldCollection)this["CustomFields"];
            }
        }
    }

    public class CustomFieldCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new CustomFieldElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((CustomFieldElement)element).Name;
        }
    }

    public class CustomFieldElement : ConfigurationElement
    {
        [ConfigurationProperty("Name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["Name"];
            }
        }

        [ConfigurationProperty("Keyword")]
        public string Keyword
        {
            get
            {
                return (string)this["Keyword"];
            }
        }
    }
}
