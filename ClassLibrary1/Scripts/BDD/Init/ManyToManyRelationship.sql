--  requete clunky mais fonctionelle


CREATE TABLE Menu_Product (
    MenuId int NOT NULL,
    ProductId int NOT NULL,
    FOREIGN KEY (MenuId) REFERENCES Menu(Id),
	FOREIGN KEY (ProductId) REFERENCES Command(Id)
); 


CREATE TABLE Command_Product (
    CommandId int NOT NULL,
    ProductId int NOT NULL,
    FOREIGN KEY (CommandId) REFERENCES Command(Id),
	FOREIGN KEY (ProductId) REFERENCES product(Id)
); 



CREATE TABLE Command_Menu (
    CommandId int NOT NULL,
    MenuId int NOT NULL,
    FOREIGN KEY (CommandId) REFERENCES Command(Id),
	FOREIGN KEY (MenuId) REFERENCES Menu(Id)
); 