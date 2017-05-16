using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestReports.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static IList<Test> ListarTeste()
        {
            return new List<Test> { };
        }
    }
}