using PolymorphismSamples.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSamples
{
    internal class Cat : Animal
    {
        public string Ear { get; set; } = "丸";

        public override Image Sing()
        {
            return Resources.CatCookieSing;
        }

        public override Image Reset()
        {
            return Resources.CatCookie;
        }
    }
}
