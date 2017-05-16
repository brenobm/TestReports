using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestReports.Models
{
    public class TestList : IEnumerable<Test>
    {
        private IList<Test> tests = new List<Test>();

        public IEnumerator<Test> GetEnumerator()
        {
            return this.tests.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.tests.GetEnumerator();
        }
    }
}