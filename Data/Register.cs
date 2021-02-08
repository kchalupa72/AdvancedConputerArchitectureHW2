using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Register
    {
        public string Identifier { get; set; }
        public int Value { get; set; }
        public bool JustChanged { get; set; }
    }
}
