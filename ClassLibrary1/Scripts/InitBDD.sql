INSERT INTO Product (Name,Price,ProductCategory, Image) VALUES
('coca',1.5, 1, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('burger',15.5, 2, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('chips',15.5, 3, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('orangine',15.5, 1, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png')

INSERT INTO Menu (Name , Image) VALUES 
('gras','https://eu-images.contentstack.com/v3/assets/blt5004e64d3579c43f/blt4e32a970bffd0792/61d866010f60435c58f20a0a/big-mac.png?auto=webp&width=1280&disable=upscale'),
('gras++', 'https://4.bp.blogspot.com/-kfv55lheGr0/Xy89Ft1bL2I/AAAAAAABSys/nIlJnoCztb0IV0ZnB0c9qAqVfKJxF4Q_ACLcBGAsYHQ/s660/hamburger-et-cheeseburger.jpg')


INSERT INTO Menu_Product(MenuId, ProductId) VALUES 
(1, 1), (1,2), (2,1), (2,1), (2,2), (2,2)