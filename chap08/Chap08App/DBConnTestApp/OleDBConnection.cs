using System.Data;

namespace DBConnTestApp
{
    internal class OleDBConnection : IDbConnection
    {
        private string connString;

        public OleDBConnection(string connString)
        {
            this.connString = connString;
        }
    }
}