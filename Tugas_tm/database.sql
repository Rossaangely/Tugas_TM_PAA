CREATE TABLE customer (
    id SERIAL PRIMARY KEY,
    nama_customer VARCHAR(100),
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);

CREATE TABLE layanan (
    id SERIAL PRIMARY KEY,
    nama_layanan VARCHAR(100),
    harga DECIMAL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);

CREATE TABLE transaksi (
    id SERIAL PRIMARY KEY,
    customer_id INT,
    layanan_id INT,
    total DECIMAL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    CONSTRAINT fk_customer
        FOREIGN KEY(customer_id) REFERENCES customer(id),
    CONSTRAINT fk_layanan
        FOREIGN KEY(layanan_id) REFERENCES layanan(id)
);