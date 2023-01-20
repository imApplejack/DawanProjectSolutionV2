INSERT INTO Product (Name,Price,ProductCategory, Image) VALUES
('coca',1.5, 1, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('burger',15.5, 2, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('chips',15.5, 3, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('orangine',15.5, 1, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png')

INSERT INTO Menu (Name) VALUES 
('gras'),
('gras++')

INSERT INTO Menu_Product(MenuId, ProductId) VALUES 
(1, 1), (1,2), (2,1), (2,1), (2,2), (2,2)