using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgPriceForDailyCount { get; set; }
        public decimal avgPriceForWeeklyCount { get; set; }
        public decimal avgPriceForMontlyCount { get; set; }
        public int carCountByTransmissionAuto { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public int carCountByKmHigherThan50kKm { get; set; }
        public string carBrandAndModelByRentPriceDailyMin { get; set; }
        public string carBrandAndModelByRentPriceDailyMax { get; set; }
        public string brandNameByMaxCarCount { get; set; }
        public string blogTitleByMaxBlogComment { get; set; }



    }
}
