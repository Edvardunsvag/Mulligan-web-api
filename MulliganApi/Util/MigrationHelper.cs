using Microsoft.EntityFrameworkCore;

namespace MulliganApi.Util;

public class MigrationHelper
{
    public static void EnsureMigrationApplied<T>(IServiceProvider serviceProvider) where T : DbContext
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<MigrationHelper>>();
            var db = scope.ServiceProvider.GetRequiredService<T>();

            try
            {
                var migrations = db.Database.GetPendingMigrations();
                if (migrations.Any())
                {
                    logger.LogInformation($"{typeof(T).FullName}:AutoDatabaseMigration Enabled. Applying '{string.Join(", ", migrations)}'");
                    db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{typeof(T).FullName}: Error applying migrations.");
                throw;
            }
        }
    }
}