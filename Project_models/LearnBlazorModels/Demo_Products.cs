using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_models.LearnBlazorModels
{
    public class Demo_Products
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }

        public int Id3 { get; set; }

        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public bool IsActive1 { get; set; }
        public bool IsActive2 { get; set; }

        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public IEnumerable<Demo_ProductProp> ProductProperties { get; set; }

        /*---------------------------------------------------*/
        /*product components for task*/
        public int price { get; set; }
        public string Name3 { get; set; }
        public bool Active { get; set; }
        public string currentlyInactive { get; set;}
        public string currentlyActive { get; set; }

        /*------------------------------------*/




    }
}
