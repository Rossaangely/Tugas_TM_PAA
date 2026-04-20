Tugas_tm - REST API Laundry

Deskripsi

Project ini merupakan REST API sederhana yang dibuat menggunakan ASP.NET Core dengan database PostgreSQL. API ini digunakan untuk mengelola data pada sistem laundry, meliputi data customer, layanan, dan transaksi. Setiap data dapat dilakukan operasi CRUD (Create, Read, Update, Delete) melalui endpoint yang tersedia.

Selain itu, project ini juga menerapkan relasi antar tabel, dimana tabel transaksi terhubung dengan tabel customer dan layanan menggunakan foreign key. API ini dilengkapi dengan Swagger untuk mempermudah proses pengujian endpoint.



Struktur Database

Tabel Customer

| Kolom         | Tipe Data    | Keterangan     |
| ------------- | ------------ | -------------- |
| id            | SERIAL       | Primary Key    |
| nama_customer | VARCHAR(100) | Nama customer  |
| created_at    | TIMESTAMP    | Tanggal dibuat |
| updated_at    | TIMESTAMP    | Tanggal update |

---

Tabel Layanan

| Kolom        | Tipe Data    | Keterangan     |
| ------------ | ------------ | -------------- |
| id           | SERIAL       | Primary Key    |
| nama_layanan | VARCHAR(100) | Nama layanan   |
| harga        | DECIMAL      | Harga layanan  |
| created_at   | TIMESTAMP    | Tanggal dibuat |
| updated_at   | TIMESTAMP    | Tanggal update |

---

### Tabel Transaksi

| Kolom       | Tipe Data | Keterangan              |
| ----------- | --------- | ----------------------- |
| id          | SERIAL    | Primary Key             |
| customer_id | INT       | Foreign Key ke customer |
| layanan_id  | INT       | Foreign Key ke layanan  |
| total       | DECIMAL   | Total harga             |
| created_at  | TIMESTAMP | Tanggal dibuat          |
| updated_at  | TIMESTAMP | Tanggal update          |

---

## Endpoint API

### Customer

* GET /api/customer → menampilkan semua data customer
* GET /api/customer/{id} → menampilkan data berdasarkan id
* POST /api/customer → menambahkan data customer
* PUT /api/customer/{id} → mengupdate data customer
* DELETE /api/customer/{id} → menghapus data customer

---

### Transaksi

* GET /api/transaksi → menampilkan semua data transaksi beserta relasi
* GET /api/transaksi/{id} → menampilkan data berdasarkan id
* POST /api/transaksi → menambahkan data transaksi
* PUT /api/transaksi/{id} → mengupdate data transaksi
* DELETE /api/transaksi/{id} → menghapus data transaksi

---

## Teknologi yang Digunakan

* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL (pgAdmin)
* Swagger

---

## Cara Menjalankan Project

1. Buka project di Visual Studio
2. Pastikan PostgreSQL sudah berjalan
3. Sesuaikan connection string pada file appsettings.json
4. Jalankan project (F5)
5. Akses Swagger untuk mencoba API

---

## Kesimpulan

REST API ini berhasil mengimplementasikan fitur CRUD serta relasi antar tabel menggunakan ASP.NET Core dan PostgreSQL. Dengan adanya API ini, data dapat dikelola dengan lebih terstruktur dan mudah diakses melalui endpoint yang tersedia.
