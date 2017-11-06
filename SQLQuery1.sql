Create Table Animals
(
Animal_Id int identity(1,1) Primary Key,
Species varchar(50) NOT NULL,
Room_Num int,
Price int,
Adoption_Status Bit,
Shot_Status Bit,
Food_Quantity int,
)