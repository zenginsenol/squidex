using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using Squidex.ClientLibrary;

namespace senolzengin.Repository
{
    public class ItemItemWhatidoRepo
    {
        private readonly IConfiguration _configuration;

        public ItemItemWhatidoRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class Item : SquidexEntityBase<_Item>
        {
        }

        public class _Item
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string OrderNo { get; set; }
        }

        public async Task<List<Item>> GetItems()
        {
            var manager = SquidexClientManager.FromOption(_configuration.ToSquidexOptions());
            var clientWhatIdo = manager.GetClient<Item, _Item>("whatido");
            var resultWhatIdo = await clientWhatIdo.GetAsync(context: SquidexParser.DefaultContext("tr"));
            return resultWhatIdo.Items.OrderBy(x => x.Data.OrderNo).ToList();
        }
    }
}