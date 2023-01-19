using PueroApp.Models;

namespace PueroApp.Services
{
    public class ClientsService : IClientService
    {
        private static List<Client> _clients= new List<Client>();

        static ClientsService()
        {
            _clients = new List<Client>();
            _clients.Add(new Client
            {
                IdClient = 1,
                FirstName = "Franek",
                LastName = "Kaminski",
                Email = "f.k@o2.pl",
                Address = "Warsaw, Szafirowa 13"
            });
            _clients.Add(new Client
            {
                IdClient = 2,
                FirstName = "Pawel",
                LastName = "Piortrowski",
                Email = "spar@o2.pl",
                Address = "Warsaw, Jana Pawla 3"
            });
            _clients.Add(new Client
            {
                IdClient = 3,
                FirstName = "Rafal",
                LastName = "Kowal",
                Email = "iron@o2.pl",
                Address = "Warsaw, Krucza 3"
            });
            _clients.Add(new Client
            {
                IdClient = 4,
                FirstName = "Piotr",
                LastName = "Cielec",
                Email = "piotr231@o2.pl",
                Address = "Warsaw, Zlota 3"
            });
        }
        public List<Client> GetClients(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return _clients;
            }

            return _clients.Where(e => e.LastName == query).ToList();
        }

        public void InsertClient(Client client)
        {
            _clients.Add(client);
        }

        public void RemoveClient(ClientId clientId)
        {
            var recordId = clientId.Id;
            var itemToRemove = _clients.Single(r => r.IdClient == recordId);
            _clients.Remove(itemToRemove);
        }

    }
}
