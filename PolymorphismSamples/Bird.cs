using PolymorphismSamples.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSamples
{
    internal class Bird : Animal
    {
        public string Beak { get; set; } = "三角";

        public override Image Sing()
        {
            return Resources.BirdCookieSing;
        }

        public override Image Reset()
        {
            return Resources.BirdCookie;
        }
    }
}
