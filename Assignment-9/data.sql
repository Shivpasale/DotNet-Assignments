USE medical_store;

DELETE FROM sale_items;
DELETE FROM sales;
DELETE FROM medicines;
DELETE FROM customers;

ALTER TABLE customers AUTO_INCREMENT = 1;
ALTER TABLE medicines AUTO_INCREMENT = 1;
ALTER TABLE sales AUTO_INCREMENT = 1;
ALTER TABLE sale_items AUTO_INCREMENT = 1;

INSERT INTO customers (name, phone, address)
VALUES ('Shivam', '8530984699', 'Pune');

INSERT INTO medicines (name, price, stock)
VALUES 
('Paracetamol', 50, 100),
('Crocin', 30, 200);

INSERT INTO sales (customer_id, sale_date, total_amount)
VALUES (1, CURDATE(), 110);

INSERT INTO sale_items (sale_id, medicine_id, quantity, price)
VALUES 
(1, 1, 1, 50),
(1, 2, 2, 60);


-- Insert
INSERT INTO sales (customer_id, sale_date, total_amount)
VALUES (1, CURDATE(), 200);

-- Update
UPDATE sales
SET total_amount = 300
WHERE sale_id = 1;

-- Delete
--DELETE FROM sale_items WHERE sale_id = 1;
--DELETE FROM sales WHERE sale_id = 1;