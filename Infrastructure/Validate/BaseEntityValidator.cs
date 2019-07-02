using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Validate
{
    public abstract class BaseEntityValidator<T> where T : class,IValidatable
    {
        public T validObject { get; set; }
        public virtual  ValidateResult IsValid()
        {
            return new ValidateResult();
        }
    }
}
