using PolymorphismSamples.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSamples
{
    internal class Animal
    {
        public string Color { get; set; } = "茶";
        public string Smell { get; set; } = "コーヒー";
        public string Flavor { get; set; } = "チョコレート";

        public virtual Image Sing()
        {
            return Resources.AnimalCookieSing;
        }

        public virtual Image Reset()
        {
            return Resources.AnimalCookie;
        }
    }
}
