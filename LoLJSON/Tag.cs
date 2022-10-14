using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLJSON
{
    public class Tag
    {
        public string TagName { get; set; }
        public int Id { get; set; }

        public Tag(string tagName, int id)
        {
            TagName = tagName;
            Id = id;
        }
    }
}
