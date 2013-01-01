ReadMe for EnumCodeFirst
~~~~~~~~~~~~~~~~~~~~~~~~

Example code demonstrating some of the EF5 code first bits

Includes
  database creation
  table annotations
  table join
  enum support
  lazy loading
  seeding
  

To DO
~~~~~
Make work with localDB
Default column values:
  Can be done in migrations: http://msdn.microsoft.com/en-us/data/jj591621.aspx
  See: AddColumn("Blogs", "Rating", c => c.Int(nullable: false, defaultValue: 3))

unit test