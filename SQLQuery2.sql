CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
    [Name] NVARCHAR(50) NOT NULL,
    [Price] Money NOT NULL
);

GO

INSERT INTO Products ([Name] , [Price] ) 
VALUES ('Laptop', 1200),
       ('Smartphone', 799),
       ('Headphones', 199)