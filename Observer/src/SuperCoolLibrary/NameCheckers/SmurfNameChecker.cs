using System.Collections.Generic;
using System.Linq;

namespace SuperCoolLibrary.NameCheckers
{
    public class SmurfNameChecker : INameChecker
    {
        public bool CheckName(string name)
        {
            var list = new List<string>
            {
                "Papa", "Brainy", "Hefty", "Smurfette"
            };

            return list.Any(x => x.ToLowerInvariant() == name.ToLowerInvariant());
        }

        public string FriendlyName => "The Smurfs";
    }
}
