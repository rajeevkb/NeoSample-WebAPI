using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using NeoSample.DAL;

namespace NeoSample.Models
{
    /// <summary>
    /// Stores the data in a json file so that no database is required for this
    /// sample application
    /// </summary>
    public class ZooRepository
    {
        /// <summary>
        /// Creates a new product with default values
        /// </summary>
        /// <returns></returns>
        internal Zoo Create()
        {
            Zoo zoo = new Zoo();
            return zoo;
        }

        /// <summary>
        /// Retrieves the list of products.
        /// </summary>
        /// <returns></returns>
        internal List<Zoo> Retrieve()
        {
          // var filePath = HostingEnvironment.MapPath(@"~/data/zoo.json");

        //    var json = System.IO.File.ReadAllText(filePath);

          //  var zoos = JsonConvert.DeserializeObject<List<Zoo>>(json);

            ZooSightingDemoDb db = new ZooSightingDemoDb();
            
            return db.Zoos.ToList();
        }

    /*
        /// <summary>
        /// Saves a new product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        internal Zoo Save(Zoo product)
        {
            // Read in the existing products
            var products = this.Retrieve();

            // Assign a new Id
            var maxId = products.Max(p => p.ProductId);
            product.ProductId = maxId + 1;
            products.Add(product);

            WriteData(products);
            return product;
        }

        /// <summary>
        /// Updates an existing product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        internal Zoo Save(int id, Zoo product)
        {
            // Read in the existing products
            var products = this.Retrieve();

            // Locate and replace the item
            var itemIndex = products.FindIndex(p => p.ProductId == product.ProductId);
            if (itemIndex > 0)
            {
                products[itemIndex] = product;
            }
            else
            {
                return null;
            }

            WriteData(products);
            return product;
        }
*/
        private bool WriteData(List<Zoo> zoos)
        {
            // Write out the Json
            //var filePath = HostingEnvironment.MapPath(@"~/App_Data/zoo.json");

            //var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            //System.IO.File.WriteAllText(filePath, json);

            return true;
        }

    }
}