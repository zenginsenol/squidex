using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using Squidex.ClientLibrary;

namespace senolzengin.Repository
{
    public class ItemExperienceRepo
    {
        private readonly IConfiguration _configuration;

        public ItemExperienceRepo(IConfiguration configuration)
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
            public string Date { get; set; }
            public string Technology { get; set; }
        }

        public async Task<List<Item>> GetItems()
        {
            var manager = SquidexClientManager.FromOption(_configuration.ToSquidexOptions());
            var clientExperience = manager.GetClient<Item, _Item>("experience");
            var resultExperience = await clientExperience.GetAsync(context: SquidexParser.DefaultContext("tr"));
            return resultExperience.Items.OrderBy(x => x.Data.OrderNo).ToList();
        }
    }
}