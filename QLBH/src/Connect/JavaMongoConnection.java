package Connect;

import com.mongodb.MongoClient;
import com.mongodb.MongoClientURI;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoCursor;
import com.mongodb.client.MongoDatabase;
import java.util.ArrayList;
import java.util.List;

import org.bson.Document;

public class JavaMongoConnection {
    private MongoClient mongoClient;
    private MongoDatabase database;

    public JavaMongoConnection() {
        String connectionString = "mongodb://localhost:27017";
        String databaseName = "admin";
        // Kết nối tới MongoDB Server
        MongoClientURI mongoURI = new MongoClientURI(connectionString);
        mongoClient = new MongoClient(mongoURI);
        // Chọn database
        database = mongoClient.getDatabase(databaseName);
    }

    public void insertData(String collectionName, Document document) {
        // Chọn collection cụ thể
        MongoCollection<Document> collection = database.getCollection(collectionName);
        collection.insertOne(document);
    }

    public void showData(String collectionName) {
        // Chọn collection cụ thể
        MongoCollection<Document> collection = database.getCollection(collectionName);

        // Lấy dữ liệu từ collection và hiển thị nó
        MongoCursor<Document> cursor = collection.find().iterator();
        while (cursor.hasNext()) {
            Document document = cursor.next();
            System.out.println(document.toJson());
        }
    }

    public void closeConnection() {
        // Đóng kết nối tới MongoDB
        mongoClient.close();
    }
    public String getDataAsJsonString(String collectionName) {
    // Chọn collection cụ thể
    MongoCollection<Document> collection = database.getCollection(collectionName);

    // Lấy dữ liệu từ collection và chuyển nó thành một chuỗi JSON với dấu xuống dòng sau mỗi tài liệu
    StringBuilder jsonData = new StringBuilder();
    MongoCursor<Document> cursor = collection.find().iterator();
    while (cursor.hasNext()) {
        Document document = cursor.next();
        jsonData.append(document.toJson());
        jsonData.append("\n"); // Thêm dấu xuống dòng
    }

    return jsonData.toString();
    }
    public static void main(String[] args) {
        JavaMongoConnection mongoDBHandler = new JavaMongoConnection();

        // Chọn collection
        String collectionName = "LoaiSanPham";

        // Insert dữ liệu vào collection
        Document documentToInsert = new Document("TenLoaiSanPham", "Dui cui");
        mongoDBHandler.insertData(collectionName, documentToInsert);
        // Hiển thị dữ liệu từ collection
        System.out.println("Dữ liệu trong collection " + collectionName + ":");
        mongoDBHandler.showData(collectionName);

        // Đóng kết nối tới MongoDB
        mongoDBHandler.closeConnection();
    }
}
