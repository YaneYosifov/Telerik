## 01. Database Systems - Overview
### _Homework_

1.	What database models do you know?
    - Hierarchical Model
    - Network Model
    - Relational Model
    - Object-oriented Model
    - Object-relational Model
1.	Which are the main functions performed by a Relational Database Management System (RDBMS)?
	- A relational database allows the definition of data structures, storage and retrieval operations and integrity constraints. In such a database the data and relations between them are organised in tables.
1.	Define what is "table" in database terms.
    - The table is a collection of related data entries and it consists of columns and rows.  Each record in a table contains the same fields.
1.	Explain the difference between a primary and a foreign key.
    - A primary key is a field or combination of fields that uniquely identify a record in a table, so that an individual record can be located without confusion.
    - A foreign key (sometimes called a referencing key) is a key used to link two tables together. Typically you take the primary key field from one table and insert it into the other table where it becomes a foreign key (it remains a primary key in the original table).
1.	Explain the different kinds of relationships between tables in relational databases.
	- One-to-one: Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table.
	- One-to-many: The primary key table contains only one record that relates to none, one, or many records in the related table.
	- Many-to-many: Each record in both tables can relate to any number of records (or no records) in the other table. Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.
1.	When is a certain database schema normalized? What are the advantages of normalized databases?
	- Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy. Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.
1.	What are database integrity constraints and when are they used?
	- Data integrity contains guidelines for data retention, specifying or guaranteeing the length of time data can be retained in a particular database. It specifies what can be done with data values when their validity or usefulness expires. In order to achieve data integrity, these rules are consistently and routinely applied to all data entering the system, and any relaxation of enforcement could cause errors in the data. Implementing checks on the data as close as possible to the source of input (such as human data entry), causes less erroneous data to enter the system. Strict enforcement of data integrity rules causes the error rates to be lower, resulting in time saved troubleshooting and tracing erroneous data and the errors it causes algorithms. Data integrity also includes rules defining the relations a piece of data can have, to other pieces of data, such as a Customer record being allowed to link to purchased Products, but not to unrelated data such as Corporate Assets. Data integrity often includes checks and correction for invalid data, based on a fixed schema or a predefined set of rules. An example being textual data entered where a date-time value is required. Rules for data derivation are also applicable, specifying how a data value is derived based on algorithm, contributors and conditions. It also specifies the conditions on how the data value could be re-derived.
1.	Point out the pros and cons of using indexes in a database.
	- Advantages: use an index for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort. As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it.
	- Disadvantages: too index will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.
1.	What's the main purpose of the SQL language?
	- Structured Query Language (SQL) is a standard computer language for relational database management and data manipulation. SQL is used to query, insert, update and modify data. Most relational databases support SQL, which is an added benefit for database administrators (DBAs), as they are often required to support databases across several different platforms.
1.	What are transactions used for? Give an example.
	- A transaction is a unit of work that is performed against a database. Transactions are units or sequences of work accomplished in a logical order, whether in a manual fashion by a user or automatically by some sort of a database program. A transaction is the propagation of one or more changes to the database. For example, if you are creating a record or updating a record or deleting a record from the table, then you are performing transaction on the table. It is important to control transactions to ensure data integrity and to handle database errors. Practically, you will club many SQL queries into a group and you will execute all of them together as a part of a transaction.
1.	What is a NoSQL database?
	- NoSQL encompasses a wide variety of different database technologies that were developed in response to a rise in the volume of data stored about users, objects and products, the frequency in which this data is accessed, and performance and processing needs.
1.	Explain the classical non-relational data models.
	- Document databases pair each key with a complex data structure known as a document. Documents can contain many different key-value pairs, or key-array pairs, or even nested documents.
	- Graph stores are used to store information about networks, such as social connections. Graph stores include Neo4J and HyperGraphDB.
	- Key-value stores are the simplest NoSQL databases. Every single item in the database is stored as an attribute name (or "key"), together with its value. Examples of key-value stores are Riak and Voldemort. Some key-value stores, such as Redis, allow each value to have a type, such as "integer", which adds functionality.
	- Wide-column stores such as Cassandra and HBase are optimized for queries over large datasets, and store columns of data together, instead of rows.
1.	Give few examples of NoSQL databases and their pros and cons.
	- Pros:
		* Mostly open source.
		* Horizontal scalability. There’s no need for complex joins and data can be easily sharded and processed in parallel.
		* Support for Map/Reduce. This is a simple paradigm that allows for scaling computation on cluster of computing nodes.
		* No need to develop fine-grained data model – it saves development time.
		* Easy to use.
		* Very fast for adding new data and for simple operations/queries.
		* No need to make significant changes in code when data structure is modified.
		* Ability to store complex data types (for document based solutions) in a single item of storage.

	- Cons:
		* Immaturity. Still lots of rough edges.
		* Possible database administration issues. NoSQL often sacrifices features that are present in SQL solutions “by default” for the sake of performance. For example, one needs to check different data durability modes and journaling in order not to be caught by surprise after a cold restart of the system. Memory consumption is one more important chapter to read up on in the database manual because memory is usually heavily used.
		* No indexing support (Some solutions like MongoDB have indexing but it’s not as powerful as in SQL solutions).
		* No ACID (Some solutions have just atomicity support on single object level).
		* Bad reporting performance.
		* Complex consistency models (like eventual consistency). CAP theorem states that it’s not possible to achieve consistency, availability and partitioning tolerance at the same time. NoSQL vendors are trying to make their solutions as fast as possible and consistency is most typical trade-off.
		* Absence of standardization. No standard APIs or query language. It means that migration to a solution from different vendor is more costly. Also there are no standard tools (e.g. for reporting)