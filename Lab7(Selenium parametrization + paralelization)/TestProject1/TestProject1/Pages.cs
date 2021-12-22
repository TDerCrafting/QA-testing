using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_testing_project
{
    internal class Pages
    {
        public static OwnerPage OwnerPage => new OwnerPage(TestBase.driver);

        public static PetTypesPage PetTypesPage => new PetTypesPage(TestBase.driver);
    
        public static VetPage vetPage => new VetPage(TestBase.driver);
    }
}
