using Microsoft.Extensions.DependencyInjection;
using DataAccess;
using DataAccess.Repository;
namespace CaidaPresion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new ServiceCollection();
            Configservice(services);
            //using var servicesprovider = services.BuildServiceProvider();
            var servicesprovider = services.BuildServiceProvider();
            var frmPrincipal = servicesprovider.GetRequiredService<frmPrincipal>();
            Application.Run(frmPrincipal);
        }
        static void Configservice(ServiceCollection services)
        {
            services.AddScoped < GraficaRepository>();
            services.AddScoped<EspumanteRepository> ();
            services.AddScoped<ConcentracionRepository>();
            services.AddScoped<ResultadoRepository>();
            services.AddScoped<OtrosResultadosRepository>();
            services.AddScoped<frmPrincipal>();
            services.AddScoped<EspumanteConcentracionRepository> ();            
        }
    }
}