using PolymorphismSamples.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSamples
{
    internal class Dog : Animal
    {
        public string Nose { get; set; } = "丸";

        public override Image Sing()
        {
            return Resources.DogCookieSing;
        }
        public override Image Reset()
        {
            return Resources.DogCookie;
        }
    }
}
