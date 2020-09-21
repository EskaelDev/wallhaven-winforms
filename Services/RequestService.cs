using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using wallpaper_forms.Enums;
using wallpaper_forms.Models;

namespace wallpaper_forms.Services
{
    public class RequestService : IRequestService
    {
        private readonly ILogger<RequestService> _log;
        private readonly IConfiguration _config;
        private readonly IWallhavenApiService _wallhavenApiService;
        private readonly IRandomSeedService _randomSeedService;

        public RequestService(ILogger<RequestService> log, IConfiguration config, IWallhavenApiService wallhavenApiService, IRandomSeedService randomSeedService)
        {
            _log = log;
            _config = config;
            _wallhavenApiService = wallhavenApiService;
            _randomSeedService = randomSeedService;
        }

        public async Task RequestImageDetails(string searchText)
        {
            try
            {
                var requestBody = CreateRequest(searchText);
                string searchChain = "?";
                foreach (PropertyInfo propertyInfo in requestBody.GetType().GetProperties())
                {
                    if (propertyInfo != null && propertyInfo.GetValue(requestBody) != null)
                    {
                        searchChain += $"{propertyInfo.CustomAttributes.ElementAt(0).ConstructorArguments.ElementAt(0).Value.ToString()}={propertyInfo.GetValue(requestBody).ToString()}&";
                    }
                }

                string searchURL = AppConfiguration.WallhavenUri + searchChain;

                _log.LogInformation("Search phrase:{searchText}", searchText);
                _log.LogInformation("Search url: {searchurl}", searchURL);

                var response = await _wallhavenApiService.Get(searchURL, null);
                var responseModel = JsonSerializer.Deserialize<WallhavenResponse>(response, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });



                GlobalVariables.CurrentImage = new ImageDetails();
                GlobalVariables.CurrentImage.PhotoURL = responseModel.Data[0].Path;
                GlobalVariables.CurrentImage.ThumbnailURL = responseModel.Data[0].Thumbs.Original;
                GlobalVariables.CurrentImage.Id = responseModel.Data[0].Id;
                GlobalVariables.CurrentImage.Description = $"ID: {responseModel.Data[0].Id}\r\n"
                                                    + $"Resolution: {responseModel.Data[0].Resolution}\r\n"
                                                    + $"Url: { responseModel.Data[0].Url}";

                GlobalVariables.Visited.Add(GlobalVariables.CurrentImage);
            }
            catch (Exception exception)
            {
                _log.LogError(exception.Message);
                Trace.WriteLine(exception.Message);
            }
        }

        public WallhavenRequest CreateRequest(string searchText)
        {
            return new WallhavenRequest()
            {
                Q = searchText,
                AtLeast = AppConfiguration.LeastResolution,
                Categories = AppConfiguration.Categories,
                Purity = AppConfiguration.Putiry,
                Ratios = AppConfiguration.Ratio,
                Sorting = Sorting.Random,
                Page = AppConfiguration.Page,
                Seed = _randomSeedService.RandomString(AppConfiguration.seedLength)
            };
        }
        public string BuildCategoryString(CheckBox General, CheckBox Anime, CheckBox People)
        {
            int category = 0;
            category = General.Checked ? category + Categories.General : category;
            category = Anime.Checked ? category + Categories.Anime : category;
            category = People.Checked ? category + Categories.People : category;
            _log.LogDebug("Category: {category}", category.ToString("000"));
            return category.ToString("000");
        }
        public string BuildPurityString(CheckBox SFW, CheckBox Sketchy, CheckBox NSFW)
        {
            int purity = 0;
            purity = SFW.Checked ? purity + Purity.Sfw : purity;
            purity = Sketchy.Checked ? purity + Purity.Sketchy : purity;
            purity = NSFW.Checked ? purity + Purity.Nsfw : purity;
            _log.LogDebug("Purity: {purity}", purity.ToString("000"));
            return purity.ToString("000");
        }

    }
}
