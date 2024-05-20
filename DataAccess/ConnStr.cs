namespace DNU_Library_website.DataAccess
{
    class ConnStr
    {
        public static IConfiguration configuration;
        public static string Get(){
            string connStr = configuration?.GetConnectionString("umbracoDbDSN");
            return connStr;
        }    
    }
}   