using BKBProductManagement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BKBProductManagement.Service
{
    public class ServiceTest
    {
        string Baseurl = "https://localhost:44377/";
        public HttpClient client { get; set; }

        public ServiceTest()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region User
        public async Task<List<User>> GetAllUsers()
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.GetAsync("api/User");
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<List<User>>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new List<User>();
            }
        }
        #endregion

        #region Product
        public async Task<List<Product>> GetAllProducts()
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.GetAsync("api/Product");
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<List<Product>>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new List<Product>();
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.GetAsync("api/Product/" + id);
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<Product>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new Product();
            }
        }

        public async Task<bool> DeleteProductById(int id)
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.DeleteAsync("api/Product/" + id);
                    if (Res.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    //TODO: Mensagem erro
                }

                return false;
            }
        }

        public async Task<Product> PostProduct(Product product)
        {
            using (client)
            {
                try
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage Res = await client.PostAsync("api/Product/", httpContent);
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<Product>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new Product();
            }
        }

        public async Task<Product> EditProduct(Product product)
        {
            using (client)
            {
                try
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage Res = await client.PutAsync("api/Product/", httpContent);
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<Product>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new Product();
            }
        }
        #endregion

        #region Supplier
        public async Task<List<Supplier>> GetAllSuppliers()
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.GetAsync("api/Supplier");
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<List<Supplier>>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new List<Supplier>();
            }
        }

        public async Task<Supplier> GetSupplierById(int id)
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.GetAsync("api/Supplier/" + id);
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<Supplier>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new Supplier();
            }
        }

        public async Task<bool> DeleteSupplierById(int id)
        {
            using (client)
            {
                try
                {
                    HttpResponseMessage Res = await client.DeleteAsync("api/Supplier/" + id);
                    if (Res.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    //TODO: Mensagem erro
                }

                return false;
            }
        }

        public async Task<Supplier> PostSupplier(Supplier supplier)
        {
            using (client)
            {
                try
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(supplier), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage Res = await client.PostAsync("api/Supplier/", httpContent);
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<Supplier>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new Supplier();
            }
        }

        public async Task<Supplier> EditSupplier(Supplier supplier)
        {
            using (client)
            {
                try
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(supplier), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage Res = await client.PutAsync("api/Supplier/", httpContent);
                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<Supplier>(response);
                    }
                }
                catch (Exception ex)
                {
                }

                return new Supplier();
            }
        }
        #endregion
    }
}