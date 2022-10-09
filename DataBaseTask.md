CREATE TABLE Products(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE Category(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE ProdCat(products_id INT NOT NULL, category_id INT NOT NULL);

INSERT INTO Products VALUES(1, 'сантиметр'), (2, 'строительная каска'), (3, 'Гаичный ключ');
INSERT INTO Category VALUES(1, 'инструменты Строителя'), (2, 'инструменты автослесаря');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2);

SELECT prod.name, cat.name FROM Products prod
    LEFT JOIN ProdCat prodcat ON prod.id = prodcat.products_id
    INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;
