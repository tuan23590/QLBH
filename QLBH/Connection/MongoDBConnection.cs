using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Data;
using QLBH.ThanhTuan;

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
        public void ThemThongTinBaoHanhTheoTenSP(string tenSP, string tenKH, string sdt, string email, string ngayMua, string tp, string quan, string phuong, string soNhaTenDuong)
        {
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");


            var filter = Builders<BsonDocument>.Filter.Eq("TenSP", tenSP);

            BsonDocument baoHanhDocument = new BsonDocument
            {
                { "TenKH", tenKH },
                { "SDT", sdt },
                { "Email", email },
                { "NgayMua", ngayMua },
                { "DiaChi", new BsonDocument
                    {
                        { "TP", tp },
                        { "Quan", quan },
                        { "Phuong", phuong },
                        { "SoNhaTenDuong", soNhaTenDuong }
                    }
                }
            };
            var update = Builders<BsonDocument>.Update.Push("BaoHanh", baoHanhDocument);
            collection.UpdateOne(filter, update);

            MessageBox.Show("Thêm thông tin bảo hành thành công!");
        }
        public List<string> LayDanhSachPhanLoai()
        {
            List<string> danhSachPhanLoai = new List<string>();
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");
            var distinctPhanLoai = collection.Distinct<string>("PhanLoai", new BsonDocument()).ToList();
            danhSachPhanLoai.AddRange(distinctPhanLoai);
            return danhSachPhanLoai;
        }
        public List<string> LayDanhSachTenSPTheoInput(string inputValue)
        {

            List<string> danhSachTenSP = new List<string>();
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");
            var filter = Builders<BsonDocument>.Filter.Regex("PhanLoai", new BsonRegularExpression(inputValue, "i"));
            var documents = collection.Find(filter).ToList();
            foreach (var document in documents)
            {
                danhSachTenSP.Add(document["TenSP"].AsString);
            }
            return danhSachTenSP;
        }
        public void ThemSanPham(string tenSP, List<string> phanLoai, string thoiGianBaoHanh, string namSX)
        {
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");
            BsonDocument document = new BsonDocument
            {
                { "TenSP", tenSP },
                { "PhanLoai", new BsonArray(phanLoai) },
                { "ThoiGianBaoHanh", thoiGianBaoHanh },
                { "NamSX", namSX }
            };
            collection.InsertOne(document);

            MessageBox.Show("Thêm sản phẩm thành công!");
        }
        public Tuple<string, string> LayThoiGianBaoHanhVaNamSXTheoTenSP(string tenSP)
        {
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");

            var filter = Builders<BsonDocument>.Filter.Eq("TenSP", tenSP);

            var result = collection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                string thoiGianBaoHanh = result["ThoiGianBaoHanh"].AsString;
                string namSX = result["NamSX"].AsString;

                return Tuple.Create(thoiGianBaoHanh, namSX);
            }

            return Tuple.Create(string.Empty, string.Empty);
        }
        public List<string> LayDanhSachTenKH()
        {
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");


            var filter = Builders<BsonDocument>.Filter.Empty;


            var results = collection.Find(filter).ToList();


            List<string> danhSachTenKH = new List<string>();


            foreach (var result in results)
            {
                if (result.Contains("BaoHanh") && result["BaoHanh"].IsBsonArray)
                {
                    var baoHanhArray = result["BaoHanh"].AsBsonArray;

                    foreach (var baoHanh in baoHanhArray)
                    {
                        if (baoHanh["TenKH"] != BsonNull.Value)
                        {
                            danhSachTenKH.Add(baoHanh["TenKH"].AsString);
                        }
                    }
                }
            }

            return danhSachTenKH;
        }
        public List<List<string>> LayThongTinTheoPhanLoai(string phanLoai)
        {
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");


            var filter = Builders<BsonDocument>.Filter.Eq("PhanLoai", phanLoai);


            var results = collection.Find(filter).ToList();


            List<List<string>> resultMatrix = new List<List<string>>();


            foreach (var result in results)
            {
                List<string> row = new List<string>
            {
                result["TenSP"].AsString,
                result["PhanLoai"][0].AsString,
                result["ThoiGianBaoHanh"].AsString,
                result["NamSX"].AsString
            };
                try
                {
                    int baoHanhCount = result["BaoHanh"].AsBsonArray.Count;
                    row.Add(baoHanhCount.ToString());
                }
                catch (Exception ex)
                {
                    row.Add("0");
                }
                try
                {
                    int traBHCount = result["BaoHanh"].AsBsonArray.Count(bh => !string.IsNullOrEmpty(bh["ThoiGianTraBH"].AsString));
                    row.Add(traBHCount.ToString());
                }
                catch (Exception ex)
                {
                    row.Add("0");
                }

                resultMatrix.Add(row);
            }

            return resultMatrix;
        }
        public void CapNhatDuLieuTheoTenSP(string tenSP, string thoiGianBaoHanh, string namSX)
        {
            IMongoCollection<BsonDocument> collection = _database.GetCollection<BsonDocument>("sp");

            var filter = Builders<BsonDocument>.Filter.Eq("TenSP", tenSP);

            BsonDocument updateDoc = new BsonDocument
            {
                { "ThoiGianBaoHanh", thoiGianBaoHanh },
                { "NamSX", namSX }
            };
            var update = Builders<BsonDocument>.Update.Set("ThoiGianBaoHanh", updateDoc["ThoiGianBaoHanh"])
                                                      .Set("NamSX", updateDoc["NamSX"]);

            collection.UpdateOne(filter, update);

            MessageBox.Show("Dữ liệu đã được cập nhật!");
        }
    }
}
