using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Onixa.Core.DataAccess.EntityFramework;
using Onixa.DataAccess.Abstract;
using Onixa.Entity;
using Onixa.Entity.ComplexTypes;

namespace Onixa.DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Products, SitedbContext>, IProductDal
    {
        public MyBasket GetMyBaskets(int id)
        {
            using (SitedbContext context=new SitedbContext())
            {
                var result = (from urun in context.Products where urun.Product_Id==id 
                    select new MyBasket{ MainImage = urun.MainImage, Name = urun.Name,Product_Id = urun.Product_Id}).SingleOrDefault();
                return result;
            }
        }

        public List<ProductsLite> GetProductIndexList()
        {
            using (SitedbContext context = new SitedbContext())
            {
                var result = from p in context.Products
                             select new ProductsLite
                             {
                                 Product_Id = p.Product_Id,
                                 Name = p.Name,
                                 Category_Id = p.Category_Id,
                                 MainImage = p.MainImage
                             };
                return result.ToList();
            }
        }

        public List<ProductsLite> GetProductIndexListbyCategoryID(int? id)
        {
            using (SitedbContext context = new SitedbContext())
            {


                var anabaslik = (from cat in context.Categories
                    join product in context.Products on cat.Category_Id equals product.Category_Id
                    where cat.ParentID == id
                    select new ProductsLite
                    {
                        Category_Id = product.Category_Id,
                        MainImage = product.MainImage,
                        Name = product.Name,
                        Product_Id = product.Product_Id
                    }).ToList();

               
                if (anabaslik.Count() > 0)
                {

                    return anabaslik;
                }
                else
                {
                    var result = from p in context.Products
                                 where p.Category_Id == id
                                 select new ProductsLite
                                 {
                                     Product_Id = p.Product_Id,
                                     Name = p.Name,
                                     Category_Id = p.Category_Id,
                                     MainImage = p.MainImage
                                 };
                    return result.ToList();
                }

            }
        }



        public List<ProductsLite> GetProductIndexListbyStyleID(int? id)
        {
            using (SitedbContext context = new SitedbContext())
            {
                var result = from p in context.ProductDetails
                             join s in context.Styles on p.Style equals s.Id
                             join produc in context.Products on p.Product_Id equals produc.Product_Id
                             where s.Id == id
                             select new ProductsLite
                             {
                                 Category_Id = produc.Category_Id,
                                 MainImage = produc.MainImage,
                                 Name = produc.Name,
                                 Product_Id = produc.Product_Id,
                                 Style_Name = s.Name
                             };
                return result.ToList();

            }
        }

        public List<Productimages> GetProductsImageNamesListbyProductId(int? id)
        {
            using (SitedbContext context = new SitedbContext())
            {
                var result = from urun in context.Products
                             join resim in context.ProductsImageName on urun.Product_Id equals resim.Product_Id
                             join urundetay in context.ProductDetails on urun.Product_Id equals urundetay.Product_Id
                             where urun.Product_Id == id


                             select new Productimages()
                             {
                                 Product_Id = urun.Product_Id,
                                 Name = urun.Name,
                                 Path = resim.Path,
                                 AddedDate = urun.AddedDate,
                                 Category_Id = urun.Category_Id,
                                 Description = urun.Description,
                                 IsContinued = urun.IsContinued,
                                 ModifiedDate = urun.ModifiedDate,
                                 Price = urun.Price,
                                 StartGivenMemberCount = urun.StartGivenMemberCount,
                                 StartPoint = urun.StartPoint,
                                 UnıtInStock = urun.UnıtInStock,
                                 UserBy = urun.UserBy,
                                 Platform = urundetay.Platform,
                                 Product_Tag = urundetay.Product_Tag,
                                 Size = urundetay.Size,
                                 //Style=urundetay.Style,
                                 Color = urundetay.Color


                             };
                return result.ToList();
            }
        }

        public List<Project> GetProjects()
        {
            using (SitedbContext context=new SitedbContext())
            {
                List<Project> result = context.Project.ToList();
               
                return result;
            }
        }
    }
}
