using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace SharpKit_SDK.samples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<Category> GetGetegories()
        {
            var list = new List<Category>();
            var root = new DirectoryInfo(MapPath("."));
            foreach (var dir in root.GetDirectories())
            {
                if (dir.Name == ".svn")
                    continue;
                var cat = new Category { Samples = new List<Sample>(), Name = dir.Name };
                list.Add(cat);
                foreach (var subDir in dir.GetDirectories())
                {
                    if (subDir.Name == ".svn")
                        continue;
                    cat.Samples.Add(new Sample { Name = subDir.Name, Href=cat.Name+"/"+subDir.Name+"/" });
                }
            }
            return list;
        }

    }

    public class Category
    {
        public List<Sample> Samples { get; set; }
        public string Name { get; set; }
    }

    public class Sample
    {
        public bool IsCategory { get; set; }
        public string Href { get; set; }

        public string Name { get; set; }
    }
}