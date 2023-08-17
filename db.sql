-- Create the database
CREATE DATABASE hotel_management;

-- Switch to the newly created database
USE hotel_management;

-- Create the "rooms" table
CREATE TABLE rooms (
    room_id INT AUTO_INCREMENT PRIMARY KEY,
    room_number VARCHAR(10) NOT NULL,
    room_type VARCHAR(50),
    capacity INT,
    rate DECIMAL(10, 2),
    is_available BOOLEAN
);

-- Create the "customers" table
CREATE TABLE customers (
    customer_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100),
    phone_number VARCHAR(20),
    nationality VARCHAR(50)
);

-- Create the "reservations" table
CREATE TABLE reservations (
    reservation_id INT AUTO_INCREMENT PRIMARY KEY,
    customer_id INT,
    room_id INT,
    check_in_date DATE,
    check_out_date DATE,
    total_amount DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY (room_id) REFERENCES rooms(room_id)
);

-- Insert sample data into the "rooms" table
INSERT INTO rooms (room_number, room_type, capacity, rate, is_available)
VALUES
    ('101', 'Single', 1, 100.00, true),
    ('201', 'Double', 2, 150.00, true),
    ('301', 'Suite', 4, 250.00, true);

-- Insert sample data into the "customers" table
INSERT INTO customers (first_name, last_name, email, phone_number, nationality)
VALUES
    ('John', 'Doe', 'john@example.com', '+1234567890', 'USA'),
    ('Jane', 'Smith', 'jane@example.com', '+9876543210', 'UK'),
    ('Michael', 'Johnson', 'michael@example.com', '+5555555555', 'Canada');

-- Insert sample data into the "reservations" table
INSERT INTO reservations (customer_id, room_id, check_in_date, check_out_date, total_amount)
VALUES
    (1, 1, '2023-08-15', '2023-08-20', 500.00),
    (2, 2, '2023-08-18', '2023-08-22', 600.00),
    (3, 3, '2023-08-20', '2023-08-25', 1000.00);
