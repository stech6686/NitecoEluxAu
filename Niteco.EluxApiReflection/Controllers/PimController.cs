using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Elux.ApiIntergration;

namespace Niteco.EluxApiReflection.Controllers
{
    //[Route("api/pim")]
    public class PimController : ApiController
    {
        [HttpGet]
        public string[] GetAEGModelSuggestionWithBrand(string service, string modelNumber, string country, 
        int startIdx, int count, string[] consignmentModels, bool showObsolete)
        {
            return new string[]{"string value 1","string value 2"};
        }
        [HttpGet]
        public  Dictionary<string,Elux.ApiIntergration.EluxPim.StockAvailabilityEntity>  GetAvailabilitiesWithTTL (string[] modelNumbers, 
        string country, string state, string cacheTTL)
        {
            return new Dictionary<string, Elux.ApiIntergration.EluxPim.StockAvailabilityEntity>{
                {"string value 1",EluxApiIntHelper.GetStockAvailability()},
                {"string value 2",EluxApiIntHelper.GetStockAvailability()}

            };
        }

        [HttpGet]
        public double GetAvailability(string modelNumber, string country, string state, string ean)
        {
            return 0;
        }

        [HttpGet]
        public double GetAvailabilityWithTTL(string modelNumber, string country, string state, string ean,string cacheTTL)
        {
            return 0;
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryEntity GetServiceCategory(string service, string country)
        {
            return EluxApiIntHelper.GetCategory();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryEntity GetServiceCategoryByCategoryGuid(string service, string categoryGuid, string country)
        {
            return EluxApiIntHelper.GetCategory();
        }
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryEntity GetServiceCategoryByModelNumber(string service, string modelNumber, string country)
        {
            return EluxApiIntHelper.GetCategory();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductEntity GetServiceProductDetail(string service, string modelNumber, string country, string isBrandMobile)
        {
            return EluxApiIntHelper.GetProduct();
        }

         [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductEntity[] GetServiceProductDetails(string service, string[] modelNumbers, string country, string isBrandMobile)
        {
            return new Elux.ApiIntergration.EluxPim.ProductEntity[]{EluxApiIntHelper.GetProduct(),EluxApiIntHelper.GetProduct()};
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.AttachmentEntity GetServiceProductHeroImage(string service, string modelNumber, string country)
        {
            return EluxApiIntHelper.GetAttachment();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductBasicEntity[] GetServiceProducts(string service, string categoryGuid, string[] productStatus, string country)

        {
            return new Elux.ApiIntergration.EluxPim.ProductBasicEntity[]{EluxApiIntHelper.GetProductBasic(),EluxApiIntHelper.GetProductBasic()};
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.AttachmentEntity[] GetProductAttachment(string modelNumber, string publicationType, string country)
        {
            return new Elux.ApiIntergration.EluxPim.AttachmentEntity[] { EluxApiIntHelper.GetAttachment(), EluxApiIntHelper.GetAttachment() };
        }

        [HttpGet] 
        public Elux.ApiIntergration.EluxPim.AttachmentEntity[] GetProductBrochures(string modelNumber, string publicationType, string country)
        {
            return new Elux.ApiIntergration.EluxPim.AttachmentEntity[] { EluxApiIntHelper.GetAttachment(), EluxApiIntHelper.GetAttachment() };
        }
        
        [HttpGet] 
        public Elux.ApiIntergration.EluxPim.AttachmentEntity[] GetProductDimensionSheet(string modelNumber, string country)
        {
            return new Elux.ApiIntergration.EluxPim.AttachmentEntity[] { EluxApiIntHelper.GetAttachment(), EluxApiIntHelper.GetAttachment() };
        }

        [HttpGet] 
        public Elux.ApiIntergration.EluxPim.AttachmentEntity[] GetProductInstallationGuides(string modelNumber, string country)
        {
            return new Elux.ApiIntergration.EluxPim.AttachmentEntity[] { EluxApiIntHelper.GetAttachment(), EluxApiIntHelper.GetAttachment() };
        }

        [HttpGet]
        public  Elux.ApiIntergration.EluxPim.AttachmentEntity[] GetProductUserManuals(string modelNumber, string country)
        {
            return new Elux.ApiIntergration.EluxPim.AttachmentEntity[] { EluxApiIntHelper.GetAttachment(), EluxApiIntHelper.GetAttachment() };
        }
        
        [HttpGet]
        public string GetProductShortDescription(string modelNumber, string country)
        {
            return "string value";
        }

        [HttpGet]
        public Dictionary<string,string> GetProductShortDescriptions(string[] modelNumbers, string country)
        {
            return new Dictionary<string, string>{
                {"string key 1","string value 1"},
                {"string key 2","string value 2"}
            };
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductBasicEntity[] GetRecentServiceProducts(string service, string country)
        {
            return new Elux.ApiIntergration.EluxPim.ProductBasicEntity[]{ EluxApiIntHelper.GetProductBasic(),EluxApiIntHelper.GetProductBasic()};
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductBasicEntity[] GetRecentServiceProductsByCategory(string service, string categoryGuid, string country)
        {
            return new Elux.ApiIntergration.EluxPim.ProductBasicEntity[]{ EluxApiIntHelper.GetProductBasic(),EluxApiIntHelper.GetProductBasic()};
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.BrochureEntity[] GetBrochures(string brand, string country)
        {
            return new Elux.ApiIntergration.EluxPim.BrochureEntity[]{ EluxApiIntHelper.GetBrochure(),EluxApiIntHelper.GetBrochure()};
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryExtEntity GetCategoryExtension(string service, string country)
        {
            return EluxApiIntHelper.GetCategoryExt();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryExtEntity GetCategoryExtensionByGuid(string service, string categoryGuid, string country)
        {
            return EluxApiIntHelper.GetCategoryExt();
        }


        [HttpGet]
        public Elux.ApiIntergration.EluxPim.NewsletterEntity[] GetNewsletters(string service, string country, string site)
        {
            return new Elux.ApiIntergration.EluxPim.NewsletterEntity[]{EluxApiIntHelper.GetNewsletter(),EluxApiIntHelper.GetNewsletter()};
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.PromotionAttachmentEntity PromotionAttachment()
        {
            return EluxApiIntHelper.GetPromotionAttachment();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.PromotionEntity[] GetProductCurrentPromotions(string service, string modelNumber, string country)
        {
            return new Elux.ApiIntergration.EluxPim.PromotionEntity[]{EluxApiIntHelper.GetPromotion(),EluxApiIntHelper.GetPromotion()};
        }

        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.PromotionEntity1 Promotion1()
        // {
        //     return EluxApiIntHelper.GetPromotion1();
        // }
        
        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.RelationshipEntity Relationship()
        // {
        //     return EluxApiIntHelper.GetRelationship();
        // }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.RelationshipGroupEntity[] GetServiceRelationship(string service, string relationshipType, string modelNumber, string country)

        {
            return new Elux.ApiIntergration.EluxPim.RelationshipGroupEntity[]{ EluxApiIntHelper.GetRelationshipGroup(),EluxApiIntHelper.GetRelationshipGroup()  };
        }

        [HttpGet]
        public Dictionary<string,Elux.ApiIntergration.EluxPim.TechDataGroupEntity> GetTechDataGroupEntities(string service, string[] modelNumbers, 
        string country, string isBrandMobile)
        {
            return new Dictionary<string, Elux.ApiIntergration.EluxPim.TechDataGroupEntity>
            {
                {"string value 1",EluxApiIntHelper.GetTechDataGroup()},
                {"string value 2",EluxApiIntHelper.GetTechDataGroup()},
            }; 
        }

        [HttpGet]
        public string[] GetModelSuggestionWithBrand(string service, string modelNumber, 
        string country, int startIdx, int count)
        {
            return new string[]{"string value 1","string value 2"};
        }
        
        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.SearchProductResultEntity SearchProductResult()
        // {
        //     return EluxApiIntHelper.GetSearchProductResult();
        // }

        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.StockAvailabilityEntity StockAvailability()
        // {
        //     return EluxApiIntHelper.GetStockAvailability();
        // }

        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.TechDataValueEntity TechDataValue()
        // {
        //     return EluxApiIntHelper.GetTechDataValue();
        // }

        

        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.BaseCategoryEntity BaseCategory()
        // {
        //     return EluxApiIntHelper.GetBaseCategory();
        // }

        // [HttpGet]
        // public Elux.ApiIntergration.EluxPim.BFAEntity BFA()
        // {
        //     return EluxApiIntHelper.GetBFA();
        // }

    }
}
