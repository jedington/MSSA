
-- comment

--   C r e a t e   D a t a b a s e
 
USE master;
 
DROP DATABASE IF EXISTS VehicleRecordsDb;
 
CREATE DATABASE VehicleRecordsDb;
 
USE VehicleRecordsDb;


--   C r e a t e   V e h i c l e   T a b l e
 
CREATE TABLE Vehicle
(
   year    INT			  NOT NULL,
   make    NVARCHAR(20)   NOT NULL,
   model   NVARCHAR(20)   NOT NULL,
   color   NVARCHAR(10)   NULL,
   vin     NVARCHAR(20)   NULL
);

--   A d d   D a t a   I n t o   V e h i c l e   T a b l e
 
INSERT
   INTO Vehicle
      (year, make,     model,      color,   vin)
   VALUES
      (2001, 'Honda',  'CR-V',     'Black', NULL    ),
      (2008, 'Subaru', 'Forester', 'Gold',  NULL    ),
      (2012, 'Mazda',  '3',        'Blue',  'ABC123');
