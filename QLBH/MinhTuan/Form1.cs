using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using QLBH.Connection;

namespace QLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void LoadDataIntoTextBox()
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "LoaiSanPham";
            var allData = dbConnection.ShowAll<BsonDocument>(collectionName);

            textBox3.Clear();

            if (allData.Count > 0)
            {
                foreach (var data in allData)
                {
                    if (data.Contains("TenLoaiSanPham")) 
                    {
                        textBox3.Text += data["TenLoaiSanPham"].AsString + Environment.NewLine;
                    }
                }
            }
            else
            {
                textBox3.Text = "Không có dữ liệu trong bộ sưu tập.";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "LoaiSanPham";
            var filter = Builders<BsonDocument>.Filter.Eq("TenLoaiSanPham", textBox2.Text);
            var searchResults = dbConnection.Search(collectionName, filter);

            textBox1.Clear();

            if (searchResults.Count > 0)
            {
                foreach (var result in searchResults)
                {
                    textBox1.Text = (result.ToString() + "\n");
                }
            }
            else
            {
                textBox1.Text= ("Không tìm thấy dữ liệu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataIntoTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "LoaiSanPham";
            var newDocument = new BsonDocument{{ "TenLoaiSanPham", textBox4.Text } };

            dbConnection.Insert(collectionName, newDocument);
            LoadDataIntoTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "LoaiSanPham";

            dbConnection.Delete<BsonDocument>(collectionName, textBox5.Text);
            LoadDataIntoTextBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "LoaiSanPham";
            string tenLoaiSanPhamToUpdate = textBox6.Text;

            dbConnection.Update<BsonDocument>(collectionName, tenLoaiSanPhamToUpdate, textBox7.Text);
            LoadDataIntoTextBox();
        }
    }
}
