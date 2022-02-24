CREATE TABLE IF NOT EXISTS "Attachment" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"ProductId"	INTEGER,
	"Path"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("ProductId") REFERENCES "Product"("Id")
);