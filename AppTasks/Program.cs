using AppTasksLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace AppTasks
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = ConfigureServices();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }
        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            string connectionString = "Data Source=tasks.db";
            DatabaseInitializer.EnsureTablesExist(connectionString);
            services.AddSingleton(new SQLiteExecutor(connectionString));
            services.AddSingleton(new SQLiteTaskInfo(connectionString));
            services.AddTransient<MainForm>();
            services.AddTransient<AddForm>();
            services.AddTransient<ExecutorForm>();

            return services;
        }
    }
}