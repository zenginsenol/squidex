
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using Squidex.ClientLibrary;

namespace senolzengin.Repository
{
    public class ItemInformationRepo
    {
        private readonly IConfiguration _configuration;

        public ItemInformationRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class Item: SquidexEntityBase<_Item>
        {
        }

        public class _Item
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Telephone { get; set; }
            public string HighSchool { get; set; }
            public string University { get; set; }
            public string Title { get; set; }
            public string Department { get; set; }
            public string Location { get; set; }
            public string Experience { get; set; }
            public string Age { get; set; }
            public string Country { get; set; }
            public string Summary { get; set; }
        }

        public async Task<Item> GetItem()
        {
            var manager = SquidexClientManager.FromOption(_configuration.ToSquidexOptions());
            var clientInformation = manager.GetClient<Item, _Item>("information");
            var resultInformation = await clientInformation.GetAsync(context: SquidexParser.DefaultContext("tr"));
            return resultInformation.Items.FirstOrDefault();
        }
    }
}