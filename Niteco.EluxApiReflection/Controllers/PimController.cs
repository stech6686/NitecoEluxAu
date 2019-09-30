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
        // GET api/values
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryEntity Category()
        {
            return EluxApiIntHelper.GetCategory();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductEntity Product()
        {
            return EluxApiIntHelper.GetProduct();
        }
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.AttachmentEntity Attachment()
        {
            return EluxApiIntHelper.GetAttachment();
        }
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.BaseCategoryEntity BaseCategory()
        {
            return EluxApiIntHelper.GetBaseCategory();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.BFAEntity BFA()
        {
            return EluxApiIntHelper.GetBFA();
        }
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.BrochureEntity Brochure()
        {
            return EluxApiIntHelper.GetBrochure();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.CategoryExtEntity CategoryExt()
        {
            return EluxApiIntHelper.GetCategoryExt();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.NewsletterEntity Newsletter()
        {
            return EluxApiIntHelper.GetNewsletter();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.ProductBasicEntity ProductBasic()
        {
            return EluxApiIntHelper.GetProductBasic();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.PromotionAttachmentEntity PromotionAttachment()
        {
            return EluxApiIntHelper.GetPromotionAttachment();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.PromotionEntity Promotion()
        {
            return EluxApiIntHelper.GetPromotion();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.PromotionEntity1 Promotion1()
        {
            return EluxApiIntHelper.GetPromotion1();
        }
        
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.RelationshipEntity Relationship()
        {
            return EluxApiIntHelper.GetRelationship();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.RelationshipGroupEntity RelationshipGroup()
        {
            return EluxApiIntHelper.GetRelationshipGroup();
        }
        
        [HttpGet]
        public Elux.ApiIntergration.EluxPim.SearchProductResultEntity SearchProductResult()
        {
            return EluxApiIntHelper.GetSearchProductResult();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.StockAvailabilityEntity StockAvailability()
        {
            return EluxApiIntHelper.GetStockAvailability();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.TechDataGroupEntity TechDataGroup()
        {
            return EluxApiIntHelper.GetTechDataGroup();
        }

        [HttpGet]
        public Elux.ApiIntergration.EluxPim.TechDataValueEntity TechDataValue()
        {
            return EluxApiIntHelper.GetTechDataValue();
        }

    }
}
