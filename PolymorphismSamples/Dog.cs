using PolymorphismSamples.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSamples
{
    internal class Dog : Animal , ITopping
    {
        public string Nose { get; set; } = "丸";

        public string WrapChocolate { get; set; } = "ホワイトチョコ";

        public override Image Sing()
        {
            return this is ITopping ? Resources.DogCookieSingWhite : Resources.DogCookieSing;
        }
        public override Image Reset()
        {
            return this is ITopping ? Resources.DogCookieWhite : Resources.DogCookie;
        }
    }
}
