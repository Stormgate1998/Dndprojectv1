namespace Dndprojectv1.Client.Services
{
    public class DataBaseService
    {
        private readonly IConfiguration config;

        public DataBaseService(IConfiguration config)
        {
            this.config = config;
        }
    }
}
