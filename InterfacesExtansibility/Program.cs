namespace InterfacesExtansibility
{
  partial class Program
    {

    static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new FileLogger("C:\\Users\\Kuba\\Desktop\\Log.txt"));
            dbMigrator.Migrate();
        }
    }
}
