using Meowgic.Repositories.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
namespace MeowgicAPI.Attribute
{
    public class CurrentAccountAttribute : System.Attribute, IBindingSourceMetadata
    {
        public BindingSource BindingSource => BindingSource.Custom;
    }

    public class CurrentAccountModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext is null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var account = bindingContext.HttpContext.Items["User"] as Account;
            bindingContext.Result = ModelBindingResult.Success(account);
            return Task.CompletedTask;
        }
    }

    public class CurrentAccountModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var bindingSource = context.BindingInfo.BindingSource;
            if (bindingSource is not null && bindingSource.CanAcceptDataFrom(BindingSource.Custom))
            {
                return new BinderTypeModelBinder(typeof(CurrentAccountModelBinder));
            }

            return null!;
        }
    }
}
