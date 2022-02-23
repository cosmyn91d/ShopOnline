CREATE TABLE IF NOT EXISTS "Category" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"CategoryParentId"	INTEGER,
	"Name"	TEXT,
	"IsDeleted"	INTEGER,
	PRIMARY KEY("Id"),
	FOREIGN KEY("CategoryParentId") REFERENCES "Category"("Id")
);