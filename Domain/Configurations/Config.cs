using Domain.Enums;
using Microsoft.Extensions.Configuration;

namespace Domain.Configurations
{
    public static class Config
    {
        static Config()
        {
            IConfigurationBuilder builder =
                new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            UpdateProperties(Env);
        }
        public static SysEnvironment Env = SysEnvironment.Local;
        private static void UpdateProperties(SysEnvironment env)
        {
            switch (env)
            {
                case SysEnvironment.Production:
                    Env = SysEnvironment.Production;
                    //
                    break;
                case SysEnvironment.Stg:
                    Env = SysEnvironment.Stg;
                    //
                    break;
                case SysEnvironment.Development:
                    Env = SysEnvironment.Development;
                    //
                    break;
                case SysEnvironment.Local:               
                    Env = SysEnvironment.Local;
                    //Write_DefaultConnection = "Server=localhost:5432;User Id=postgres;Password=123;Database=sela_local";
                    //Read_DefaultConnection = "Server=localhost:5432;User Id=postgres;Password=123;Database=sela_local";
                    break;
            }
        }
    }
}
