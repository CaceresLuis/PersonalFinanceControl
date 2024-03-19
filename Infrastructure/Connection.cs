namespace PersonalFinanceControl.Infrastructure
{
    public class Connection
    {
        public static string GetRoute(string dbName)
        {
            string routeDb = string.Empty;
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                routeDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                routeDb = Path.Combine(routeDb, dbName);
            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                routeDb = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                routeDb = Path.Combine(routeDb, "...", "Library", dbName);
            }

            return routeDb;
        }
    }
}
