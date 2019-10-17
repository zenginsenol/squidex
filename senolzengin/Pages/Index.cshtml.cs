using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Squidex.ClientLibrary;

namespace senolzengin.Pages
{
    public class IndexModel : PageModel
    {
        public Item items;

        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class Item : SquidexEntityBase<_Item>
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
            public string Departman { get; set; }
            public string Location { get; set; }
        }

        public async Task OnGet()
        {
            var manager = SquidexClientManager.FromOption(_configuration.ToSquidexOptions());
            var client = manager.GetClient<Item, _Item>("information");
            var result = await client.GetAsync(context: SquidexParser.DefaultContext("tr"));
            var res = result.Items.ToArray().FirstOrDefault();
            items = res;
        }
    }
}