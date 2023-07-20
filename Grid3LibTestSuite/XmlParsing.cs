using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlParsing;

namespace Grid3LibTestSuite
{
    public class XmlParsing
    {
        [Theory]
        [InlineData("<?xml version=\"1.0\" encoding=\"UTF-8\"?><note>  <to>Tove</to>  <from>Jani</from>  <heading>Reminder</heading>  <body>Don't forget me this weekend!</body></note>"
            , true)]
        [InlineData("<?xml version=\"1.0\" encoding=\"UTF-8\"?><note>  <to>Tove</to>  <from>Jani</fom>  <heading>Reminder</heading>  <body>Don't forget me this weekend!</body></note>"
            , false)]
        public void CheckParseXml(string xml, bool expectOK)
        {
            List<Exception>? exceptions = XmlParseFunctions.ValidateXml(xml);
            if (expectOK)
            {
                Assert.Null(exceptions);
            }
            else
            {
                Assert.NotNull(exceptions);
                Assert.NotEmpty(exceptions);
            }
        }
    }
}
