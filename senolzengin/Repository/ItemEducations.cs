using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using Squidex.ClientLibrary;

namespace senolzengin.Repository
{
    public class ItemEducationsRepo
    {
        private readonly IConfiguration _configuration;

        public ItemEducationsRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class Item : SquidexEntityBase<_Item>
        {
        }

        public class _Item
        {
            public string SchoolName { get; set; }
            public string Description { get; set; }
            public string OrderNo { get; set; }
            public string Date { get; set; }
        }

        public async Task<List<Item>> GetItems()
        {
            var manager = SquidexClientManager.FromOption(_configuration.ToSquidexOptions());
            var clientInformation = manager.GetClient<Item, _Item>("education");
            var resultInformation = await clientInformation.GetAsync(context: SquidexParser.DefaultContext("tr"));
            return resultInformation.Items.OrderBy(x => x.Data.OrderNo).ToList();
        }
    }
}