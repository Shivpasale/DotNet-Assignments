SELECT 
    c.name AS customer_name,
    s.sale_id,
    s.sale_date,
    m.name AS medicine,
    si.quantity,
    si.price,
    s.total_amount
FROM sales s
JOIN customers c ON s.customer_id = c.customer_id
JOIN sale_items si ON s.sale_id = si.sale_id
JOIN medicines m ON si.medicine_id = m.medicine_id
WHERE c.name = 'Shivam';



-- Fetch Specific Invoice
SELECT * FROM sales WHERE sale_id = 1;

-- Full Invoice Details
SELECT 
c.name AS customer_name,
s.sale_id,
s.sale_date,
m.name AS medicine,
si.quantity,
si.price,
s.total_amount
FROM sales s
JOIN customers c ON s.customer_id = c.customer_id
JOIN sale_items si ON s.sale_id = si.sale_id
JOIN medicines m ON si.medicine_id = m.medicine_id
WHERE s.sale_id = 1;