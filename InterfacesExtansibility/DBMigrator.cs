using System;

namespace InterfacesExtansibility
{
  public class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}" + DateTime.Now);

            //Details of migration the database

            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
    }
}
