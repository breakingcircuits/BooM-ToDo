namespace BoomLibrary
{
    class DataStore
    {
        public string DbConnectionString { get; set; }
        public string FileStorePath { get; set; }
        
        public DataStore(string ConnectionString)
        {
            DbConnectionString = ConnectionString;
        }

        /// <summary>
        /// Constructor for Storage on local machine
        /// </summary>
        /// <param name="path"></param>
        public DataStore(string path)
        {
            FileStorePath = path;
        }
    }
}