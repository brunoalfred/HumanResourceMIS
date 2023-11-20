1 . To create database 
```sh
CREATE DATABASE EmployerDB_BRUNO;
```

Select the database
```sh
USE EmployerDB_BRUNO;
```

2. Create tables 

```sh
-- Create EmployerClasses table
CREATE TABLE EmployerClasses (
    EmployerClassID INT PRIMARY KEY,
    EmployerClassRef VARCHAR(50),
    EmployerClassType VARCHAR(50),
    EmployerClassName VARCHAR(255)
);

-- Create EmployerSubClasses table
CREATE TABLE EmployerSubClasses (
    EmployerSubClassID INT IDENTITY(1,1) PRIMARY KEY,
    EmployerSubClassCode VARCHAR(255), -- Adjust the data type accordingly
    EmployerSubClassDescription TEXT NULL,
    EmployerSubClassShortDescription TEXT NULL,
    ClassRef INT, -- This will be the foreign key column
    FOREIGN KEY (ClassRef) REFERENCES EmployerClasses(EmployerClassID)
);

```



3. Insert data into tables

```sh
INSERT INTO EmployerClasses (EmployerClassID, EmployerClassRef, EmployerClassType, EmployerClassName)
SELECT EmployerClassID, EmployerClassRef, EmployerClassType, EmployerClassName
FROM OPENROWSET(BULK'/Users/brunoalfred/Downloads/EmployerClasses.xls', SINGLE_CLOB) as ExcelData;
```

```sh
-- Insert data into EmployerSubClasses from Excel
INSERT INTO EmployerSubClasses (EmployerSubClassID, EmployerSubClassCode, EmployerSubClassDescription, ClassRef)
SELECT EmployerSubClassID, EmployerSubClassCode, EmployerSubClassDescription, EmployerSubClassShortDescription, ClassRef
FROM OPENROWSET(BULK'/Users/brunoalfred/Downloads/EmployerSubClasses.xls', SINGLE_CLOB) as ExcelData;
```