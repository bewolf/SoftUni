CREATE  DATABASE IF NOT EXISTS shop;

USE shop;

CREATE TABLE IF NOT EXISTS categories(
  category_id int(12) NOT NULL AUTO_INCREMENT,
  category_name VARCHAR(255) NOT NULL,
  PRIMARY KEY(category_id)
);

CREATE TABLE IF NOT EXISTS products(
  product_id int(12) NOT NULL AUTO_INCREMENT,
  product_name VARCHAR(255) NOT NULL,
  product_price DECIMAL(6,2) DEFAULT 0,
  product_description text,
  product_create_date DATETIME DEFAULT CURRENT_TIMESTAMP,
  category_id int(11),
  CONSTRAINT `category_id` FOREIGN KEY (category_id) REFERENCES CATEGORIES(category_id),
  PRIMARY KEY(product_id)
);

INSERT INTO categories (category_name) VALUES
('drinks'),( 'food'),( 'others');

INSERT INTO products (product_name, product_description, product_price, category_id)
VALUES ('coffe', null,5.50, 1),
       ('burger', 'food for fools', 3.14, 2),
       ('tea', 'black tea', 4.24, 1),
       ('asddsa', 'dsadsa',1.11 , 3);
