using FluentValidation;

namespace EDrinkMarket.Business.Utilities
{
    public static class ValidationTools
    {
        public static void FluentValidate<T>(IValidator<T> validator,T entity) where T:class,new()
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
