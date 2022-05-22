using FRMK.BLL;
using FRMK.IBLL;
using Microsoft.Extensions.DependencyInjection;

namespace FRMK.IoC
{
    public static class DependencyInjectionBootStrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            #region BLLs
            services.AddScoped<ICalculator, Calculator>();
            #endregion
            return services;
        }
    }
}