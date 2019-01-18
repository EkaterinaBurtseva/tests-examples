using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties;

namespace Page
{
    public class HomePage:BasePage
    {

        public HomePage() : base()
        {

        }

        public void OpenStartPage(string baseURL)
        {
            Browsers.Goto(baseURL);
        }
    }
}
