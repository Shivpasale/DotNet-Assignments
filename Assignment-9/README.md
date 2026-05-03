--- Medical Store Database Project ---

// Description

This project is a simple Medical Store Management System using MySQL.
It stores customer details, medicines, sales, and sale items.

---

// Tables Used

* **customers** → Customer details (name, phone, address)
* **medicines** → Medicine details (name, price, stock)
* **sales** → Sales information (customer, date, total amount)
* **sale_items** → Items included in each sale

---

// Features

* Add customers
* Manage medicines stock
* Record sales transactions
* Generate sales report using JOIN queries

---

// Technologies Used

* MySQL
* SQL (DDL, DML, JOIN)

---

// How to Run

1. Open MySQL / SQLTools
2. Run:

//  `USE medical_store;`
3. Execute table creation queries
4. Insert sample data
5. Run SELECT query to get output

---

// Sample Output

Shows:

* Customer Name
* Sale ID
* Date
* Medicine Name
* Quantity
* Price
* Total Amount

---

// Author

Shivam Pasale
B.Tech Computer Science Engineering (2024)


// Output

Invoice Generated Successfully:

Customer: Shivam  
Medicines:
- Paracetamol (Qty: 1, Price: 50)
- Crocin (Qty: 2, Price: 60)

Total Amount: 110

// Concepts Used
- SQL Joins
- Foreign Keys
- CRUD Operations
- Invoice Generation