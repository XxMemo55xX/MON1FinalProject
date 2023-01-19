using PueroApp.Models;
using System.Data.SqlClient;

namespace PueroApp.Services
{
    public class SqlServerClientService : IClientService
    {
        public List<Client> GetClients(string query)
        {
            SqlConnection con;
            return null;
        }

        public void InsertClient(Client client)
        {
            throw new NotImplementedException();
        }
        public void RemoveClient(ClientId clientId)
        {
            throw new NotImplementedException();
        }
    }
}
