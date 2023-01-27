INSERT INTO Product (Name,Price,ProductCategory, Image) VALUES
('coca',1.5, 1, 'https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png'),
('burger', 4.5, 2, 'https://burgerkingfrance.twic.pics/img/products/f/37/f378eae5-61a3-459f-b40f-4057b4f88e96_?twic=v1/contain=700x700'),
('chips',2, 3, 'https://media.auchan.fr/MEDIASTEP74724443_1200x1200/B2CD/'),
('orangine',1.5, 1, 'https://media.auchan.fr/A0220141222000475486PRIMARY_1200x1200/B2CD/'),
('glace', 2, 3, 'https://www.artfromitaly.it/images/Articoli/1600x1200/Grossiste-cone-galce-dragees_543976_E.JPG'),
('fanta', 1.5, 1, 'https://s.cdnmpro.com/321239485/p/l/0/fanta-ananas-pack-6-x-33cl~2180.jpg')

INSERT INTO Menu (Name , Image) VALUES 
('gras','https://eu-images.contentstack.com/v3/assets/blt5004e64d3579c43f/blt4e32a970bffd0792/61d866010f60435c58f20a0a/big-mac.png?auto=webp&width=1280&disable=upscale'),
('gras++', 'http://pngimg.com/uploads/burger_sandwich/burger_sandwich_PNG4130.png')


INSERT INTO Menu_Product(MenuId, ProductId) VALUES 
(1, 1), (1,2), (2,1), (2,1), (2,2), (2,2)

