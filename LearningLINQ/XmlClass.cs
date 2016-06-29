using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearningLINQ
{
    public class XmlClass
    {
        public XElement element = new XElement("instructors",
            new XElement("instructor", "Aaron"),
            new XElement("instructor", "Finch"),
            new XElement("instructor", "Fritz"),
            new XElement("instructor", "Keith"),
            new XElement("instructor", "Scott")
        );
    }
}
