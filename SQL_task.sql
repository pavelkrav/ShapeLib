CREATE SCHEMA `product_schema`;

CREATE TABLE `product_schema`.`products` (
  `product_id` INT NOT NULL AUTO_INCREMENT,
  `product_name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`product_id`));

CREATE TABLE `product_schema`.`categories` (
  `category_id` INT NOT NULL AUTO_INCREMENT,
  `category_name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`category_id`));

CREATE TABLE `product_schema`.`product_category_cross` (
  `surrogate_id` BIGINT NOT NULL AUTO_INCREMENT,
  `category_id` INT NOT NULL,
  `product_id` INT NOT NULL,
  PRIMARY KEY (`surrogate_id`),
  CONSTRAINT `pcc_categories_fk`
    FOREIGN KEY (`category_id`)
    REFERENCES `product_schema`.`categories` (`category_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `pcc_products_fk`
    FOREIGN KEY (`product_id`)
    REFERENCES `product_schema`.`products` (`product_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

SELECT 
    products.product_name, categories.category_name
FROM
    product_category_cross
        RIGHT JOIN
    products ON products.product_id = product_category_cross.product_id
        LEFT JOIN
    categories ON categories.category_id = product_category_cross.category_id;