using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFloor.Classes
{
    public class PartnersWithDiscount : Model.Partners
    {
        public decimal? Discount { get; set; }
        private Model.MasterFloorDBEntities Context = Model.MasterFloorDBEntities.GetContext();
        public PartnersWithDiscount(Model.Partners partner)
        {
            this.AdressCityId = partner.AdressCityId;
            this.AdressHouseNum = partner.AdressHouseNum;
            this.AdressIndex = partner.AdressIndex;
            this.AdressRegionId = partner.AdressRegionId;
            this.AdressStreetId = partner.AdressStreetId;
            this.City = partner.City;
            this.DirectorName = partner.DirectorName;
            this.DirectorPatronym = partner.DirectorPatronym;
            this.DirectorSurname = partner.DirectorSurname;
            this.Email = partner.Email;
            this.Id = partner.Id;
            this.ITN = partner.ITN;
            this.PartnerName = partner.PartnerName;
            this.PartnerNameId = partner.PartnerNameId;
            this.PartnerProduct = partner.PartnerProduct;
            this.PartnerType = partner.PartnerType;
            this.PartnerTypeId = partner.PartnerTypeId;
            this.Phone = partner.Phone;
            this.Rating = partner.Rating;
            this.Region = partner.Region;
            this.Street = partner.Street;
            this.Discount = GetDiscount(partner);
        }
        private int GetDiscount(Model.Partners partner)
        {
            decimal? SumSales = (from p in Context.Partners
                                 join pp in Context.PartnerProduct on p.Id equals pp.PartnerId
                                 into ppGroup
                                 from pp in ppGroup.DefaultIfEmpty()
                                 join pr in Context.Product on pp.ProductId equals pr.Id
                                 into prGroup
                                 from pr in prGroup.DefaultIfEmpty()
                                 where p.Id == partner.Id
                                 select (decimal?)pr.MinCost * (decimal?)pp.ProductCount).Sum();
            if (SumSales != null)
            {
                if (SumSales >= 10000 && SumSales < 50000)
                {
                    return 5;
                }
                if (SumSales >= 50000 && SumSales < 300000)
                {
                    return 10;
                }
                if (SumSales >= 300000)
                {
                    return 15;
                }
            }
            return 0;
        }
    }
}
