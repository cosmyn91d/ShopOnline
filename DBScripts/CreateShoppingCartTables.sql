CREATE TABLE IF NOT EXISTS "ShoppingCart" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"CustomerId"	INTEGER,
	"CreateTime"	TEXT,
	"Total"	REAL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("CustomerId") REFERENCES "Customer"("Id")
);
CREATE TABLE IF NOT EXISTS "ShoppingCartItem" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"ShoppingCartId"	INTEGER NOT NULL,
	"ProductId"	INTEGER NOT NULL,
	"Quantity"	INTEGER,
	"ItemTotal"	REAL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("ShoppingCartId") REFERENCES "ShoppingCart"("Id")
);