using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace QLBH.Connection
{
    public class MongoDBConnection
    {
        private IMongoDatabase _database;
        private MongoClient _client;

        public MongoDBConnection()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLBH";
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
        public List<T> Search<T>(string collectionName, FilterDefinition<T> filter)
        {
            var collection = GetCollection<T>(collectionName);
            return collection.Find(filter).ToList();
        }
        public List<T> ShowAll<T>(string collectionName)
        {
            var collection = GetCollection<T>(collectionName);
            return collection.Find(FilterDefinition<T>.Empty).ToList();
        }
        public void Insert<T>(string collectionName, T document)
        {
            var collection = GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
        public void Delete<T>(string collectionName, string tenLoaiSanPham)
        {
            var collection = GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("TenLoaiSanPham", tenLoaiSanPham);
            collection.DeleteOne(filter);
        }
        public void Update<T>(string collectionName, string tenLoaiSanPham, string updatedtenLoaiSanPham)
        {
            var collection = GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("TenLoaiSanPham", tenLoaiSanPham);
            var update = Builders<T>.Update.Set("TenLoaiSanPham", updatedtenLoaiSanPham);
            collection.UpdateOne(filter, update);
        }

    }
}
