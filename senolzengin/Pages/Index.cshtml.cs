using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using senolzengin.Repository;
using Squidex.ClientLibrary;

namespace senolzengin.Pages
{
    public class IndexModel : PageModel
    {
      

        public List<ItemEducationsRepo.Item> ItemEducations { get; set; }
        public ItemInformationRepo.Item ItemInformation { get; set; }
        public List<ItemExperienceRepo.Item> ItemExperience { get; set; }
        
        private readonly ItemInformationRepo _informationRepo;
       private readonly ItemEducationsRepo _educationRepo;
       private readonly ItemExperienceRepo _experienceRepo;

        public IndexModel(ItemInformationRepo informationRepo, ItemEducationsRepo educationRepo, ItemExperienceRepo experienceRepo)
        {
            _informationRepo = informationRepo;
            _educationRepo = educationRepo;
            _experienceRepo = experienceRepo;
        }

        public async Task OnGet()
        {
            var resInformation = await  _informationRepo.GetItem();
            var resEducation = await _educationRepo.GetItems();
            var resExperience = await _experienceRepo.GetItems();
            ItemInformation = resInformation;
            ItemEducations = resEducation;
            ItemExperience = resExperience;
        }

        
    }
}