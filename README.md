Tugas_tm - REST API Laundry

Deskripsi
Project ini merupakan REST API sederhana yang dibuat menggunakan ASP.NET Core dan PostgreSQL. API ini digunakan untuk mengelola data pada sistem laundry, meliputi data customer, layanan, dan transaksi.

Struktur Database
Project ini menggunakan 3 tabel utama:
Customer → menyimpan data pelanggan
Layanan → menyimpan jenis layanan laundry
Transaksi → menyimpan data transaksi yang menghubungkan customer dan layanan

Relasi:
Transaksi memiliki foreign key ke tabel Customer
Transaksi memiliki foreign key ke tabel Layanan
Teknologi yang Digunakan
ASP.NET Core Web API
Entity Framework Core
PostgreSQL (pgAdmin)
Swagger (untuk testing API)
Endpoint API
Customer
GET /api/customer → menampilkan semua data customer
GET /api/customer/{id} → menampilkan data berdasarkan id
POST /api/customer → menambahkan data customer
PUT /api/customer/{id} → mengupdate data customer
DELETE /api/customer/{id} → menghapus data customer
Transaksi
GET /api/transaksi → menampilkan semua data transaksi beserta relasi
GET /api/transaksi/{id} → menampilkan transaksi berdasarkan id
POST /api/transaksi → menambahkan transaksi
PUT /api/transaksi/{id} → mengupdate transaksi
DELETE /api/transaksi/{id} → menghapus transaksi

Cara Menjalankan Project
Buka project di Visual Studio
Pastikan PostgreSQL sudah berjalan
Sesuaikan connection string pada file appsettings.json
Jalankan project (F5)
Akses Swagger untuk testing API

Kesimpulan
REST API ini dapat digunakan untuk mengelola data laundry dengan fitur CRUD lengkap serta relasi antar tabel. API ini juga memanfaatkan Entity Framework Core untuk mempermudah pengolahan data dan integrasi dengan database PostgreSQL.
