# SQL Mass Insert
 
Tool to help create mass insert statements for SQL Server.


## Usage

> * The values coming from a file / database can be "declared" by enclosing "col" + # of column in angle brackets, as in: "&lt;col1&gt;".
 > * Any value not in angle brackets will be taken literally
 > * You can separate the values with space or a comma
 > * You can put the values in any order, i.e. "&lt;col3&gt;,&lt;col1&gt;,5,&lt;col2&gt;"


## Roadmap

* Windows Forms GUI
* CLI
* Obtain data from a csv file
* Obtain data from databases
* Insert data into a table
* Write to a csv file
