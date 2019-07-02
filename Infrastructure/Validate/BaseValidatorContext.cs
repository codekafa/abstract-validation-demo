using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Validate
{
    public abstract class BaseValidatorContext<VT, T> : IValidatorContext where T : class, IValidatable where VT : BaseEntityValidator<T>, new()
    {
        public BaseEntityValidator<T> _validator;

        public BaseValidatorContext()
        {
            _validator = new VT();
        }
        public  ValidateResult IsValid()
        {
            var result = _validator.IsValid();
            return result;

        }

    }
}
