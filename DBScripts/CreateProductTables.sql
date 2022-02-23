CREATE TABLE IF NOT EXISTS "ProductDiscounts" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"ProductId"	INTEGER,
	"DiscountId"	INTEGER,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("ProductId") REFERENCES "Product"("Id"),
	FOREIGN KEY("DiscountId") REFERENCES "Discount"("Id")
);

CREATE TABLE IF NOT EXISTS "Product" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Code"	BLOB,
	"Name"	TEXT,
	"Description"	TEXT,
	"CategoryId"	INTEGER,
	"Price"	REAL,
	"Stock"	INTEGER,
	"IsDeleted"	INTEGER,
	"CreateTime"	TEXT,
	"ModifyTime"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);