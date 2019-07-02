using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Validate
{
    public class ValidateResult
    {
        public ValidateResult()
        {
            Messages = new List<string>();
        }
        public bool IsValid { get; set; }

        public List<string> Messages { get; set; }
    }
}
