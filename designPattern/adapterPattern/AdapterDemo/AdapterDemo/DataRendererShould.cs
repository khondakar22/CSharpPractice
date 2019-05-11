using AdapterDemo.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Text;
using AdapterDemo.Test;
using System;
using System.Linq;

namespace AdapterDemo
{
    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter() );
            var writer = new StringWriter();
            myRenderer.Render(writer);
            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);

        }
    }
}
