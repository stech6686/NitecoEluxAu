using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elux.ApiIntergration.EluxPim;

namespace Elux.ApiIntergration
{
    public static class EluxApiIntHelper
    {
        #region PIM

        public static EluxPim.AttachmentEntity GetAttachment()
        {
            return new AttachmentEntity { Thumbnails = new ThumbnailItem[] { new ThumbnailItem { } } };
        }

        public static EluxPim.BaseCategoryEntity GetBaseCategory()
        {
            return new BaseCategoryEntity { };
        }

        public static EluxPim.BFAEntity GetBFA()
        {
            return new BFAEntity { Attachments = new AttachmentEntity[] { new AttachmentEntity { Thumbnails = new ThumbnailItem[] { new ThumbnailItem { } } } } };
        }

        public static EluxPim.BrochureEntity GetBrochure()
        {
            return new BrochureEntity
            {

            };
        }

        public static EluxPim.CategoryEntity GetCategory()
        {
            return new CategoryEntity
            {
                SubCategory = new CategoryEntity[] { new CategoryEntity { }, }
            };
        }

        public static EluxPim.CategoryExtEntity GetCategoryExt()
        {
            return new CategoryExtEntity
            {
                SubCategory = new CategoryExtEntity[] { new CategoryExtEntity() },
                Products = new ProductBasicEntity[]{
                    new ProductBasicEntity
                    {
                        Features = new BFAEntity[]
                        {
                            new BFAEntity
                            {
                                Attachments = new AttachmentEntity[]
                                {
                                    new AttachmentEntity
                                    {
                                        Thumbnails =new ThumbnailItem[]
                                        {
                                            new ThumbnailItem{}
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        public static EluxPim.NewsletterEntity GetNewsletter()
        {
            return new NewsletterEntity
            {

            };
        } 

        public static EluxPim.ProductBasicEntity GetProductBasic()
        {
            return new ProductBasicEntity
                    {
                        Features = new BFAEntity[]
                        {
                            new BFAEntity
                            {
                                Attachments = new AttachmentEntity[]
                                {
                                    new AttachmentEntity
                                    {
                                        Thumbnails =new ThumbnailItem[]
                                        {
                                            new ThumbnailItem{}
                                        }
                                    }
                                }
                            }
                        }
                    };
        }

        public static EluxPim.ProductEntity GetProduct()
        {
            return new ProductEntity
            {
                Accessories = new ProductEntity[] { new ProductEntity() },
                Awards = new BFAEntity[] {
                    new BFAEntity() {
                        Attachments = new AttachmentEntity[] {new AttachmentEntity{ Thumbnails = new ThumbnailItem[] { new ThumbnailItem() } } } } }
            };
        }

        public static EluxPim.PromotionAttachmentEntity GetPromotionAttachment()
        {
            return new PromotionAttachmentEntity
            {

            };
        }

        public static EluxPim.PromotionEntity GetPromotion()
        {
            return new PromotionEntity
            {
                PromotionAttachmentEntities = new PromotionAttachmentEntity[]{new PromotionAttachmentEntity()}
            };
        }

        public static EluxPim.PromotionEntity1 GetPromotion1()
        {
            return new PromotionEntity1
            {

            };
        }

        public static EluxPim.RelationshipEntity GetRelationship()
        {
            return new RelationshipEntity
            {

            };
        }

        public static EluxPim.RelationshipGroupEntity GetRelationshipGroup()
        {
            return new RelationshipGroupEntity
            {
                Relationships = new RelationshipEntity[]{new RelationshipEntity()}
            };
        }

        public static EluxPim.SearchProductResultEntity GetSearchProductResult()
        {
            return new SearchProductResultEntity
            {
                ProductBasics = new ProductBasicEntity[] 
                {   
                    new ProductBasicEntity
                    {
                        Features = new BFAEntity[]
                        {
                            new BFAEntity
                            {
                                Attachments = new AttachmentEntity[]
                                {
                                    new AttachmentEntity
                                    {
                                        Thumbnails =new ThumbnailItem[]
                                        {
                                            new ThumbnailItem{}
                                        }
                                    }
                                }
                            }
                        }
                    } 
                }
            };
        }

        public static EluxPim.StockAvailabilityEntity GetStockAvailability()
        {
            return new StockAvailabilityEntity
            {

            };
        }

        public static EluxPim.TechDataGroupEntity GetTechDataGroup()
        {
            return new TechDataGroupEntity
            {
                SubGroups = new TechDataGroupEntity[]{new TechDataGroupEntity()},
                Values = new TechDataValueEntity[]{new TechDataValueEntity()}
            };
        }

        public static EluxPim.TechDataValueEntity GetTechDataValue()
        {
            return new TechDataValueEntity
            {

            };
        }
        
        public static double GetStockAvailable(string emailAddress,string modelNumber,string ean)
        {
            return new double();
        }

        #endregion
    }
}
