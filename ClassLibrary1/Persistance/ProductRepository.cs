﻿using AssociationCRMDawanPoe.Entity;
using ProjectAPI.Persistance;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class ProductRepository : AbstractRepository, IProductRepository
    {
        public ProductRepository(string connexionString) : base(connexionString)
        {

        }

        public void Create(Product p)
        {
            int affected = this.EntityManager.Query("Product").InsertGetId<int>(new
            {
                Name = p.Name,
                Price = p.Price,
                ProductCategory = p.ProductCategory,
                Image = p.Image,
                

            });
            p.Id = affected;
        }

        public void Update(Product p)
        {
            int affected = this.EntityManager.Query("Product").Where("Id", p.Id).Update(new
            {
                Name = p.Name,
                Price = p.Price,
                ProductCategory = p.ProductCategory,
                Image = p.Image,

            });
        }

        public void RemoveById(int id)
        {
            int affected = this.EntityManager.Query("Product").Where("Id", id).Delete();
        }

        public Product GetById(int id)
        {
            return this.EntityManager.Query("Product").Where("Id", id).Get<Product>().First();
        }


        public List<Product> GetAll()
        {
             List<Product> retour = new List<Product>();
             var products = this.EntityManager.Query("Product").Get<Product>();
            foreach (Product product in products)
            {
                retour.Add(product);
            }
            return retour;
        }
    }
}
