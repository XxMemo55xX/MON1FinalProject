using PueroApp.Models;

namespace PueroApp.Services
{
    public interface IClientService
    {
        List<Client> GetClients(string query);
        void InsertClient(Client client);
        void RemoveClient(ClientId clientId);
    }
}
