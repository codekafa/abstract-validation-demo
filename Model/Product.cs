using Infrastructure;
using Infrastructure.Validate;
using Model.Validators;

namespace Model
{
    public class Product :  BaseValidatorContext<ProductValidator,Product>, IEntity
    {

        public Product()
        {
            this._validator.validObject = this;
        }

        public int ID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        
    }
}
