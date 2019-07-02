using Infrastructure;
using Infrastructure.Validate;
using System;

namespace Model.Validators
{
    public class ProductValidator : BaseEntityValidator<Product>
    {
        ValidateResult _result;

        public override ValidateResult IsValid()
        {
            _result = new ValidateResult();

            if (string.IsNullOrWhiteSpace(this.validObject.ProductName))
            {
                _result.Messages.Add("ProductName is required");
            }
            if (this.validObject.ProductPrice <= 0)
            {
                _result.Messages.Add("ProductPrice is required");
            }
            if (string.IsNullOrWhiteSpace(this.validObject.ProductDescription))
            {
                _result.Messages.Add("ProductDescription is required");
            }

            return _result;
        }
    }
}
