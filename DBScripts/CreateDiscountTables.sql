CREATE TABLE IF NOT EXISTS "DiscountType" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Name"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Discount" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Value"	REAL,
	"DiscountTypeId"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("DiscountTypeId") REFERENCES "DiscountType"("Id")
);