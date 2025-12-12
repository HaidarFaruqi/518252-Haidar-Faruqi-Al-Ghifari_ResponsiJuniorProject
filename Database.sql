DROP TABLE IF EXISTS proyek;
CREATE TABLE proyek(
	id_proyek SERIAL PRIMARY KEY,
	nama_proyek VARCHAR(100) NOT NULL,
	client VARCHAR(50) NOT NULL,
	budget int NOT NULL
);

DROP TABLE IF EXISTS developer;
CREATE TABLE developer(
	id_dev SERIAL PRIMARY KEY,
	nama_dev VARCHAR(100) NOT NULL,
	status_kontrak VARCHAR(50) NOT NULL,
	fitur_selesai int NOT NULL,
	jumlah_bug int NOT NULL,
	id_proyek INT REFERENCES proyek(id_proyek)
);

INSERT INTO developer (nama_dev. status_kontrak, fitur_selesai, jumlah_bug, id_proyek) VALUES
('Haha', 'Selesai',12, 2, 1),
('Hihi', 'Selesai',12, 4, 2),
('Huhu', 'Belu,',15, 3, 3),
('Hehe', 'Selesai',17, 1, 4),
('Hoho', 'Belum',13, 2, 5);

INSERT INTO proyek (nama_proyek, client, budget) VALUES
('Web Company Profile', 'CV Sejahtera',8000),
('Sistem Parkir QR', 'Dinas Perhubungan',15000),
('IoT Agriculture App', 'Tani Maju Indonesia',25000),
('E-Commerce Startup', 'PT Maju Mundur',100000),
('AI Fraud Detection', 'Unicorn Fintech',150000);

CREATE OR REPLACE FUNCTION dev_insert(_nama VARCHAR, _status VARCHAR, _fitur INT, _bug INT, _id_proyek INT)
RETURNS INT AS $$
BEGIN
INSERT INTO developer (nama_dev, status_kontrak, fitur_selesai, jumlah_bug, id_proyek);
RETURN 1;
EXCEPTION WHEN OTHERS THEN RETURN 0;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION dev_update(_id_dev INT,_nama VARCHAR, _status VARCHAR, _fitur INT, _bug INT, _id_proyek INT)
RETURNS INT AS $$
BEGIN
UPDATE developer
SET nama_dev =_nama , status_kontrak =_status, fitur_selesai =_fitur, jumlah_bug = _bug, id_proyek = _id_proyek WHERE id_dev = _id_dev;
RETURN 1;
EXCEPTION WHEN OTHERS THEN RETURN 0;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION dev_delete(_id_dev INT)
RETURNS INT AS $$
BEGIN
delete FROM developer WHERE id_dev = _id_dev;
RETURN 1;
EXCEPTION WHEN OTHERS THEN RETURN 0;
END;
$$ LANGUAGE plpgsql;