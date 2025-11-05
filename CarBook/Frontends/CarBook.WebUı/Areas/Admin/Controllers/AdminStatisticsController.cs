using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Drawing;

namespace CarBook.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            #region CarC
            var responseMessage = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCount = values.carCount;

            }
            #endregion
            #region LocationC
            var responseMessage2 = await client.GetAsync("https://localhost:7218/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.LocationCount = values2.locationCount;

            }
            #endregion
            #region AuthorC
            var responseMessage3 = await client.GetAsync("https://localhost:7218/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.AuthorCount = values3.authorCount;

            }
            #endregion
            #region BlogC
            var responseMessage4 = await client.GetAsync("https://localhost:7218/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.BlogCount = values4.blogCount;

            }
            #endregion
            #region BrandC
            var responseMessage5 = await client.GetAsync("https://localhost:7218/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.BrandCount = values5.brandCount;

            }
            #endregion
            #region AvgPriFD
            var responseMessage6 = await client.GetAsync("https://localhost:7218/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.AvgPriFDCount = values6.avgPriceForDailyCount.ToString("0.00");

            }
            #endregion
            #region AvgPriFW
            var responseMessage7 = await client.GetAsync("https://localhost:7218/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.AvgPriFwCount = values7.avgPriceForWeeklyCount.ToString("0.00");

            }
            #endregion
            #region AvgPriFM
            var responseMessage8 = await client.GetAsync("https://localhost:7218/api/Statistics/GetAvgRentPriceForMontly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.AvgPriFMCount = values8.avgPriceForMontlyCount.ToString("0.00");

            }
            #endregion
            #region CarTransmissionAuto
            var responseMessage9 = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.CarTransmissionAuto = values9.carCountByTransmissionAuto;

            }
            #endregion
            #region FuelDB
            var responseMessage10 = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage10.IsSuccessStatusCode)
            {
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.FuelDB = values10.carCountByFuelGasolineOrDiesel;

            }
            #endregion
            #region FuelE
            var responseMessage11 = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage11.IsSuccessStatusCode)
            {
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.FuelE = values11.carCountByFuelElectric;

            }
            #endregion
            #region HigherThan50K
            var responseMessage12 = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarCountByKmHigherThan50kKm");
            if (responseMessage12.IsSuccessStatusCode)
            {
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.HigherThan50K = values12.carCountByKmHigherThan50kKm;

            }
            #endregion
            #region MostExpensiveCar
            var responseMessage13 = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage13.IsSuccessStatusCode)
            {
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.MostExpensiveCar = values13.carBrandAndModelByRentPriceDailyMax;

            }
            #endregion
            #region MostChipperCar
            var responseMessage14 = await client.GetAsync("https://localhost:7218/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.MostChipperCar = values14.carBrandAndModelByRentPriceDailyMin;

            }
            #endregion
            #region BrandNameMaxCar
            var responseMessage15 = await client.GetAsync("https://localhost:7218/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage15.IsSuccessStatusCode)
            {
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.BrandNameMaxCar = values15.brandNameByMaxCarCount;

            }
            #endregion
            #region BlogCommentMax
            var responseMessage16 = await client.GetAsync("https://localhost:7218/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage16.IsSuccessStatusCode)
            {
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.BlogCommentMax = values16.blogTitleByMaxBlogComment;

            }
            #endregion
            return View();
        }
    }
}
