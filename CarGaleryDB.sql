--create database CarGallery


--use CarGallery


CREATE TABLE Customers
(
IdCustomers int primary key IDENTITY (1,1) NOT NULL,
[Name of Customers]  nvarchar(100) NOT NULL,
[Passwords of Customers]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Customers Check([Name of Customers] <>' '),
Constraint CK_Passwords_of_Customers Check([Passwords of Customers] <>' '),
Constraint UK_Passwords_of_Customers Unique([Passwords of Customers])
)


Insert into CarGallery.dbo.Customers(CarGallery.dbo.Customers.[Name of Customers], CarGallery.dbo.Customers.[Passwords of Customers])
values
(N'Customers_1', N'Customers_1p')

CREATE TABLE Admins
(
IdAdmins int primary key IDENTITY (1,1) NOT NULL,
[Name of Admins]  nvarchar(100) NOT NULL,
[Passwords of Admins]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Admins Check([Name of Admins] <>' '),
Constraint CK_Passwords_of_Admins Check([Passwords of Admins] <>' '),
Constraint UK_Passwords_of_Admins Unique([Passwords of Admins])
)



Insert into CarGallery.dbo.Admins(CarGallery.dbo.Admins.[Name of Admins], CarGallery.dbo.Admins.[Passwords of Admins])
values
(N'Admins_1', N'Admins_1p')




create table CarBrandsandModels
(
IdCarBrandsandModels int primary key IDENTITY (1,1) NOT NULL,
[BrandsandModels of car]  nvarchar(100) NOT NULL,
[Images of car]  nvarchar(max) NOT NULL,

Constraint CK_Name_of_Models_of_car Check([BrandsandModels of car] <>' ')
)


Insert into CarGallery.dbo.CarBrandsandModels(CarGallery.dbo.CarModels.[BrandsandModels of car], CarGallery.dbo.CarModels.[Images of car])
values
 -- Audi_1
(N'Audi A1', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A1.jpg'), --1
(N'Audi A3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A3.jpg'), --2
(N'Audi A4', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A4.jpg'), --3
(N'Audi A5', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A5.jpg'), --4
(N'Audi A6', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A6.jpg'), --5
(N'Audi A7', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A7.jpg'), --6
(N'Audi A8', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A8.jpg'), --7
(N'Audi A4 Allroad', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/A4%20Allroad.jpg'), --8
(N'Audi Q3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/Q3.jpg'), --9
(N'Audi Q5', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/Q5.jpg'), --10
(N'Audi Q7', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/Q7.jpg'), --11
(N'Audi Q8', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/Q8.jpg'), --12
(N'Audi RS3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/RS3.jpg'), --13
(N'Audi RS6', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/RS6.jpg'), --14
(N'Audi RS7', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/RS7.jpg'), --15
(N'Audi S5', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/S5.jpg'), --16
(N'Audi S8', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Audi/S8.jpg'), --17
 -- BMW_2
(N'BMW 118', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/118.jpg'), --18
(N'BMW 120d', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/120.jpg'), --19
(N'BMW 218i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/218i.jpg'), --19
(N'BMW 220d', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/220d.jpg'), --20
(N'BMW 316i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/316i.jpg'), --21
(N'BMW 318i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/318i.jpg'), --22
(N'BMW 320i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/323i.jpg'), --23
(N'BMW 323i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/220d.jpg'), --24
(N'BMW 324d', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/324d.jpg'), --25
(N'BMW 325i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/325i.jpg'), --26
(N'BMW 320d', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/320d.jpg'), --27
(N'BMW 325 GT', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/325%20gt.jpg'), --28
(N'BMW 328', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/328.jpg'), --29
(N'BMW 330i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/330i.jpg'), --30
(N'BMW 335i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/335i.jpg'), --31
(N'BMW 340i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/340i.jpg'), --32
(N'BMW 420i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/420i.jpg'), --33
(N'BMW 428i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/428i.jpg'), --34
(N'BMW 430i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/430i.jpg'), --35
(N'BMW 518d', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/518d.jpg'), --36
(N'BMW 520', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/520.jpg'),  --37
(N'BMW 523i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/523i.jpg'), --38
(N'BMW 525', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/525.jpg'), --39
(N'BMW 525i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/525i.jpg'), --40
(N'BMW 528i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/528i.jpg'), --41
(N'BMW 530i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/530i.jpg'), --42
(N'BMW 530e', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/530e.jpg'), --43
(N'BMW 535i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/535i.jpg'), --44
(N'BMW 535 GT', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/535%20gt.jpg'), --45
(N'BMW 540i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/540i.jpg'), --46
(N'BMW 545i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/545i.jpg'), --47
(N'BMW 550i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/550i.jpg'), --48
(N'BMW 640', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/640.jpg'),                         --49
(N'BMW 650', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/220d.jpg'),                         --50
(N'BMW 728i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/728i.jpg'),                         --51
(N'BMW 730d', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/730d.jpg'),                         --52
(N'BMW 735Li', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/735Li.jpg'),                         --53
(N'BMW 740Le', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/740Le.jpg'),                         --54
(N'BMW 745Li', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/745Li.jpg'),                         --55
(N'BMW 750i', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/750i.jpg'),                         --56
(N'BMW 760Li', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/760Li.JPG'),                         --57
(N'BMW F 800 GS', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/F800GS.jpg'),                    --58
(N'BMW R 1200 GS', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/R1200GS.JPG'),                   --59
(N'BMW S 1000 R', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/S1000R.jpg'),                    --60
(N'BMW M3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/M3.jpg'),                          --61
(N'BMW M4', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/M4.jpg'),                          --62
(N'BMW M5', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/M5.jpg'),                          --63
(N'BMW M6', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/M6.jpg'),                          --64
(N'BMW M8', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/M8.jpg'),                          --65
(N'BMW X5 M', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X5%20M.jpg'),                        --66
(N'BMW X6 M', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X6%20M.jpg'),                        --67
(N'BMW X1', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X1.jpg'),                          --68
(N'BMW X2', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X2.jpg'),                          --69 
(N'BMW X3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X3.jpg'),                          --70 
(N'BMW X4 M', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X4%20M.jpg'),                          --71 
(N'BMW X5', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X5.jpg'),                          --72 
(N'BMW X6', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X6.jpg'),                          --73
(N'BMW X7', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/X7.jpg'),                          --74
(N'BMW i3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/i3.jpg'),                          --75
(N'BMW i8', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/BMW/i8.JPG'),                     --76
-- Chevrolet_3
(N'Chevrolet Alero', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Alero.jpg'),                       --77 
(N'Chevrolet Aveo', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Aveo.jpg'),                        --78
(N'Chevrolet Camaro', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Camaro.jpg'),                      --79
(N'Chevrolet Captiva', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Captiva.jpg'),                     --80
(N'Chevrolet Cavalier', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Cavalier.jpg'),                    --81
(N'Chevrolet Cobalt', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Cobalt.jpg'),                      --82
(N'Chevrolet Colorado', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Colorado.jpg'),                    --83
(N'Chevrolet Cruze', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Cruze.jpg'),                       --84
(N'Chevrolet Epica', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Epica.jpg'),                       --85
(N'Chevrolet Equinox', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Equinox.jpg'),                     --86
(N'Chevrolet Express', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Express.jpg'),                     --87
(N'Chevrolet HHR', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/HHR.JPG'),                         --88
(N'Chevrolet Kalos', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Kalos.JPG'),                       --89
(N'Chevrolet Lacetti', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Lacetti.jpg'),                     --90
(N'Chevrolet Lanos', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Lanos.jpg'),                       --91
(N'Chevrolet Lumina', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Lumina.jpg'),                      --92
(N'Chevrolet Malibu', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Malibu.jpg'),                      --93
(N'Chevrolet Matiz', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Matiz.jpg'),                       --94
(N'Chevrolet Niva', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Niva.JPG'),                        --95
(N'Chevrolet Orlando', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Orlando.jpg'),                     --96
(N'Chevrolet Rezzo', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Rezzo.jpg'),                       --97
(N'Chevrolet Sonic', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Sonic.jpg'),                       --98
(N'Chevrolet Spark', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Spark.jpg'),                       --99
(N'Chevrolet Tahoe', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Tahoe.jpg'),                       --100
(N'Chevrolet Traverse', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Traverse.jpg'),                    --101
(N'Chevrolet Trax', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Trax.jpg'),                        --102
(N'Chevrolet Volt', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Chevrolet/Volt.jpg'),                        --103
-- Chrysler_4
(N'Chrysler 200', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/200.jpg'),                         --104
(N'Chrysler 300', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/300.jpg'),                         --105
(N'Chrysler 300C', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/300C.jpg'),                        --106
(N'Chrysler Crossfire', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/Crossfire.jpg'),                   --107
(N'Chrysler Neon', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/Neon.JPG'),                        --108
(N'Chrysler PT Cruiser', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/PT%20Cruiser.jpg'),                  --109
(N'Chrysler Sebring', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/Sebring.jpg'),                     --110
(N'Chrysler Voyager', N'https://github.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/blob/master/Global%20Images/Car%20Models/Chrysler/Voyager.jpg'),                     --111
-- Citroen_5
(N'Citroen C4', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Citroen/C4.jpg'),                          --112
(N'Citroen C4 Grand Picasso', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Citroen/C4%20Grand%20Picasso.jpg'),            --113
(N'Citroen C5', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Citroen/C5.jpg'),                          --114
(N'Citroen DS3', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Citroen/DS3.jpg'),                         --115
(N'Citroen Xsara', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Citroen/Xsara.jpg'),                       --116
-- Daewoo_6
(N'Daewoo BS090', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/BS090.jpg'),                       --117
(N'Daewoo Damas', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Damas.jpg'),                       --118
(N'Daewoo Espero', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Espero.jpg'),                      --119
(N'Daewoo Gentra', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Gentra.JPG'),                      --120
(N'Daewoo Lacetti', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Lacetti.jpg'),                    --121
(N'Daewoo Lanos', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Lanos.jpg'),                       --122
(N'Daewoo Leganza', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Leganza.jpg'),                     --123
(N'Daewoo Matiz', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Matiz.jpg'),                       --124
(N'Daewoo Nexia', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Nexia.jpg'),                       --125
(N'Daewoo Nubira', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Nubira.jpg'),                      --126
(N'Daewoo Prince', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Prince.jpg'),                      --127
(N'Daewoo Racer', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Racer.jpg'),                       --128
(N'Daewoo Super Salon', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Super%20Salon.jpg'),                 --129
(N'Daewoo Tico', N'https://raw.githubusercontent.com/MehrajLatifli/CarGallery-_-LINQ-to-SQL-with-MVVM/master/Global%20Images/Car%20Models/Daewoo/Tico.jpg')                        --130







create table ManufactureYears
(
IdManufactureYears int primary key IDENTITY (1,1) NOT NULL,
[Manufacture Years]  datetime NOT NULL,

Constraint CK_ManufactureofYears Check([Manufacture Years] >=(CAST(N'01/01/1949 00:00:00.000' as Datetime)))
)


Insert into CarGallery.dbo.ManufactureYears([Manufacture Years])
values
(CAST(N'01/01/2000 00:00:00.000' as Datetime)),
(CAST(N'01/01/2001 00:00:00.000' as Datetime)),
(CAST(N'01/01/2002 00:00:00.000' as Datetime)),
(CAST(N'01/01/2003 00:00:00.000' as Datetime)),
(CAST(N'01/01/2004 00:00:00.000' as Datetime)),
(CAST(N'01/01/2005 00:00:00.000' as Datetime)),
(CAST(N'01/01/2006 00:00:00.000' as Datetime)),
(CAST(N'01/01/2007 00:00:00.000' as Datetime)),
(CAST(N'01/01/2008 00:00:00.000' as Datetime)),
(CAST(N'01/01/2009 00:00:00.000' as Datetime)),
(CAST(N'01/01/2010 00:00:00.000' as Datetime)),
(CAST(N'01/01/2011 00:00:00.000' as Datetime)),
(CAST(N'01/01/2012 00:00:00.000' as Datetime)),
(CAST(N'01/01/2013 00:00:00.000' as Datetime)),
(CAST(N'01/01/2014 00:00:00.000' as Datetime)),
(CAST(N'01/01/2015 00:00:00.000' as Datetime)),
(CAST(N'01/01/2016 00:00:00.000' as Datetime)),
(CAST(N'01/01/2017 00:00:00.000' as Datetime)),
(CAST(N'01/01/2018 00:00:00.000' as Datetime)),
(CAST(N'01/01/2019 00:00:00.000' as Datetime)),
(CAST(N'01/01/2020 00:00:00.000' as Datetime))


create table CarBodyStyles --ban növü
(
IdCarBodyStyles int primary key IDENTITY (1,1) NOT NULL,
[Name of Car Body Styles]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Car_Body_Styles Check([Name of Car Body Styles]  <>' ')
)


Insert into CarGallery.dbo.CarBodyStyles([Name of Car Body Styles])
values
(N'Buggy'),
(N'Convertible / cabriolet'),
(N'Coupé'),
(N'Flower car'),
(N'Hatchback / Liftback'),
(N'Hearse / funeral coach'),
(N'Limousine'),
(N'Microvan'),
(N'Minivan'),
(N'Panel van'),
(N'Panel truck'),
(N'Pickup truck / pickup'),
(N'Roadster'),
(N'Sedan / saloon'),
(N'Shooting-brake'),
(N'Station wagon / estate car'),
(N'Targa top'),
(N'Ute / coupe utility'),
(N'Offroader'),
(N'Sports Car'),
(N'Sport Utility Vehicle')


create table CarColors
(
IdCarColors int primary key IDENTITY (1,1) NOT NULL,
[Name of Car Color]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Car_Colors Check([Name of Car Color]  <>' ')
)


Insert into CarGallery.dbo.CarColors([Name of Car Color])
values
(N'black'),
(N'white'),
(N'red'),
(N'green'),
(N'yellow'),
(N'blue'),
(N'brown'),
(N'orange'),
(N'pink'),
(N'purple'),
(N'grey')


create table CarEngines
(
IdCarEngines int primary key IDENTITY (1,1) NOT NULL,
[Number of Car Engine]  float NOT NULL,

Constraint CK_Name_of_Car_Engines Check([Number of Car Engine]  >0)
)


Insert into CarGallery.dbo.CarEngines([Number of Car Engine])
values
(CAST(N'0.5' as float)),
(CAST(N'1.0' as float)),
(CAST(N'1.1' as float)),
(CAST(N'1.2' as float)),
(CAST(N'1.3' as float)),
(CAST(N'1.4' as float)),
(CAST(N'1.5' as float)),
(CAST(N'1.6' as float)),
(CAST(N'1.7' as float)),
(CAST(N'1.8' as float)),
(CAST(N'1.9' as float)),
(CAST(N'2.0' as float)),
(CAST(N'2.1' as float)),
(CAST(N'2.2' as float)),
(CAST(N'2.3' as float)),
(CAST(N'2.4' as float)),
(CAST(N'2.5' as float)),
(CAST(N'2.6' as float)),
(CAST(N'2.7' as float)),
(CAST(N'2.8' as float)),
(CAST(N'2.9' as float)),
(CAST(N'3.0' as float)),
(CAST(N'3.1' as float)),
(CAST(N'3.2' as float)),
(CAST(N'3.3' as float)),
(CAST(N'3.4' as float)),
(CAST(N'3.5' as float)),
(CAST(N'3.6' as float)),
(CAST(N'3.7' as float)),
(CAST(N'3.8' as float)),
(CAST(N'3.9' as float)),
(CAST(N'4.0' as float)),
(CAST(N'4.1' as float)),
(CAST(N'4.2' as float)),
(CAST(N'4.3' as float)),
(CAST(N'4.4' as float)),
(CAST(N'4.5' as float)),
(CAST(N'4.6' as float)),
(CAST(N'4.7' as float)),
(CAST(N'4.8' as float)),
(CAST(N'4.9' as float)),
(CAST(N'5.0' as float)),
(CAST(N'5.1' as float)),
(CAST(N'5.2' as float)),
(CAST(N'5.3' as float)),
(CAST(N'5.4' as float)),
(CAST(N'5.5' as float)),
(CAST(N'5.6' as float)),
(CAST(N'5.7' as float)),
(CAST(N'5.8' as float)),
(CAST(N'5.9' as float)),
(CAST(N'6.0' as float))

SELECT *FROM CarEngines

create table CarEnginePowers 
(
IdCarEnginePowers int primary key IDENTITY (1,1) NOT NULL,
[Number of Car Engine Powers]  bigint NOT NULL,

Constraint CK_Name_of_Car_Engine_Powers Check([Number of Car Engine Powers]  >0)
)

Insert into CarGallery.dbo.CarEnginePowers([Number of Car Engine Powers])
values
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10),
(11),
(12),
(13),
(14),
(15),
(16),
(17),
(18),
(19),
(20),
(21),
(22),
(23),
(24),
(25),
(26),
(27),
(28),
(29),
(30),
(31),
(32),
(33),
(34),
(35),
(36),
(37),
(38),
(39),
(40),
(41),
(42),
(43),
(44),
(45),
(46),
(47),
(48),
(49),
(50),
(51),
(52),
(53),
(54),
(55),
(56),
(57),
(58),
(59),
(60),
(61),
(62),
(63),
(64),
(65),
(66),
(67),
(68),
(69),
(70),
(71),
(72),
(73),
(74),
(75),
(76),
(77),
(78),
(79),
(80),
(81),
(82),
(83),
(84),
(85),
(86),
(87),
(88),
(89),
(90),
(91),
(92),
(93),
(94),
(95),
(96),
(97),
(98),
(99),
(100),
(101),
(102),
(103),
(104),
(105),
(106),
(107),
(108),
(109),
(110),
(111),
(112),
(113),
(114),
(115),
(116),
(117),
(118),
(119),
(120),
(121),
(122),
(123),
(124),
(125),
(126),
(127),
(128),
(129),
(130),
(131),
(132),
(133),
(134),
(135),
(136),
(137),
(138),
(139),
(140),
(141),
(142),
(143),
(144),
(145),
(146),
(147),
(148),
(149),
(150),
(151),
(152),
(153),
(154),
(155),
(156),
(157),
(158),
(159),
(160),
(161),
(162),
(163),
(164),
(165),
(166),
(167),
(168),
(169),
(170),
(171),
(172),
(173),
(174),
(175),
(176),
(177),
(178),
(179),
(180),
(181),
(182),
(183),
(184),
(185),
(186),
(187),
(188),
(189),
(190),
(191),
(192),
(193),
(194),
(195),
(196),
(197),
(198),
(199),
(200),
(201),
(202),
(203),
(204),
(205),
(206),
(207),
(208),
(209),
(210),
(211),
(212),
(213),
(214),
(215),
(216),
(217),
(218),
(219),
(220),
(221),
(222),
(223),
(224),
(225),
(226),
(227),
(228),
(229),
(230),
(231),
(232),
(233),
(234),
(235),
(236),
(237),
(238),
(239),
(240),
(241),
(242),
(243),
(244),
(245),
(246),
(247),
(248),
(249),
(250),
(251),
(252),
(253),
(254),
(255),
(256),
(257),
(258),
(259),
(260),
(261),
(262),
(263),
(264),
(265),
(266),
(267),
(268),
(269),
(270),
(271),
(272),
(273),
(274),
(275),
(276),
(277),
(278),
(279),
(280),
(281),
(282),
(283),
(284),
(285),
(286),
(287),
(288),
(289),
(290),
(291),
(292),
(293),
(294),
(295),
(296),
(297),
(298),
(299),
(300),
(301),
(302),
(303),
(304),
(305),
(306),
(307),
(308),
(309),
(310),
(311),
(312),
(313),
(314),
(315),
(316),
(317),
(318),
(319),
(320),
(321),
(322),
(323),
(324),
(325),
(326),
(327),
(328),
(329),
(330),
(331),
(332),
(333),
(334),
(335),
(336),
(337),
(338),
(339),
(340),
(341),
(342),
(343),
(344),
(345),
(346),
(347),
(348),
(349),
(350),
(351),
(352),
(353),
(354),
(355),
(356),
(357),
(358),
(359),
(360),
(361),
(362),
(363),
(364),
(365),
(366),
(367),
(368),
(69),
(370),
(371),
(372),
(373),
(374),
(375),
(376),
(377),
(378),
(379),
(380),
(381),
(382),
(383),
(384),
(385),
(386),
(387),
(388),
(389),
(390),
(391),
(392),
(393),
(394),
(395),
(396),
(397),
(398),
(399),
(400)


create table CarFueltypes
(
IdCarFueltypes int primary key IDENTITY (1,1) NOT NULL,
[Name of Car Fueltypes]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Car_Fuel_types Check([Name of Car Fueltypes]  <>' ')
)


Insert into CarGallery.dbo.CarFueltypes([Name of Car Fueltypes])
values
(N'Petrol'),
(N'Diesel'),
(N'Hybrid'),
(N'Electric'),
(N'Alternative Fuels')


create table CarKilometres
(
IdCarKilometres int primary key IDENTITY (1,1) NOT NULL,
[Number of Car Kilometres]  bigint NOT NULL default(0),

Constraint CK_Number_of_Car_Kilometres Check([Number of Car Kilometres]  >=0)
)


Insert into CarGallery.dbo.CarKilometres([Number of Car Kilometres])
values
(0),
(1000.0),
(1500.0),
(2000.0),
(2500.0),
(3000.0),
(3500.0),
(4000.0),
(4500.0),
(5000.0),
(5500.0),
(6000.0),
(6500.0),
(7000.0),
(7500.0),
(8000.0),
(8500.0),
(9000.0),
(9500.0),
(10000.0)


create table CarGearboxes --sürət qutusu 
(
IdCarGearboxes int primary key IDENTITY (1,1) NOT NULL,
[Name of Car Gearboxes]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Car_Gearboxes Check([Name of Car Gearboxes]  <>' ')
)


Insert into CarGallery.dbo.CarGearboxes([Name of Car Gearboxes])
values
(N'Automated Manual Transmission'),
(N'Continuous Variable Transmission'),
(N'Dual Clutch Transmission'),
(N'Torque Converters'),
(N'Intelligent Manual Transmission')


create table CarTransmissions --ötürücü
(
IdCarTransmissions int primary key IDENTITY (1,1) NOT NULL,
[Name of Car Transmissions]  nvarchar(100) NOT NULL,

Constraint CK_Name_of_Car_Transmissions Check([Name of Car Transmissions]  <>' ')
)

Insert into CarGallery.dbo.CarTransmissions([Name of Car Transmissions])
values
(N'Front'),
(N'Back')


create table NewCars
(
IdNewCars int primary key IDENTITY (1,1) NOT NULL,
[New Car] bit NOT NULL
)


Insert into CarGallery.dbo.NewCars([New Car])
values
(N'False'),
(N'True')


create table CarPrices
(
IdCarPrices int primary key IDENTITY (1,1) NOT NULL,
[Number of Car Prices]  money NOT NULL default(0.00000),

Constraint CK_Number_of_Car_Prices Check([Number of Car Prices]  >=0)
)


Insert into CarGallery.dbo.CarPrices([Number of Car Prices])
values
(0.0),
(1000.0),
(1500.0),
(2000.0),
(2500.0),
(3000.0),
(3500.0),
(4000.0),
(4500.0),
(5000.0),
(5500.0),
(6000.0),
(6500.0),
(7000.0),
(7500.0),
(8000.0),
(8500.0),
(9000.0),
(9500.0),
(10000.0),
(15000.0),
(20000.0),
(25000.0),
(30000.0),
(35000.0),
(40000.0),
(45000.0),
(50000.0),
(55000.0),
(60000.0),
(65000.0),
(70000.0),
(75000.0),
(80000.0),
(85000.0),
(90000.0),
(95000.0),
(100000.0),
(150000.0),
(200000.0),
(250000.0),
(300000.0),
(350000.0),
(400000.0),
(450000.0),
(500000.0),
(550000.0),
(600000.0),
(650000.0),
(700000.0),
(750000.0),
(800000.0),
(850000.0),
(900000.0),
(950000.0),
(1000000.0),
(1500000.0)




create table CarQuantities
(
IdCarQuantities int primary key IDENTITY (1,1) NOT NULL,
[Quantity of Car]  int NOT NULL default(0),

Constraint CK_Quantity_of_Car Check([Quantity of Car]  >=0)
)


Insert into CarGallery.dbo.CarQuantities([Quantity of Car])
values
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10)


CREATE TABLE Cars
(
IdCars int primary key IDENTITY (1,1) NOT NULL,

CarBrandsandModelsId int NOT NULL,
ManufactureYearsId int NOT NULL,
CarBodyStylesId int NOT NULL,
CarColorsId int NOT NULL,
CarEnginesId int NOT NULL,
CarEnginePowersId int NOT NULL,
CarFueltypesId int NOT NULL,
CarKilometresId int NOT NULL,
CarGearboxesId int NOT NULL,
CarTransmissionsId int NOT NULL,
NewCarsId int NOT NULL,
CarPricesId int NOT NULL,
CarQuantitiesId int NOT NULL,
AdminsId int NOT NULL,


Constraint FK_CarBrandsandModelsId Foreign key (CarBrandsandModelsId) References CarBrandsandModels(IdCarBrandsandModels) On Delete CASCADE On Update CASCADE,
Constraint FK_ManufactureYearsId Foreign key (ManufactureYearsId) References ManufactureYears(IdManufactureYears) On Delete CASCADE On Update CASCADE,
Constraint FK_CarBodyStylesId Foreign key (CarBodyStylesId) References CarBodyStyles(IdCarBodyStyles) On Delete CASCADE On Update CASCADE,
Constraint FK_CarColorsId Foreign key (CarColorsId) References CarColors(IdCarColors) On Delete CASCADE On Update CASCADE,
Constraint FK_CarEnginesId Foreign key (CarEnginesId) References CarEngines(IdCarEngines) On Delete CASCADE On Update CASCADE,
Constraint FK_CarEnginePowersId Foreign key (CarEnginePowersId) References CarEnginePowers(IdCarEnginePowers) On Delete CASCADE On Update CASCADE,
Constraint FK_CarFueltypesId Foreign key (CarFueltypesId) References CarFueltypes(IdCarFueltypes) On Delete CASCADE On Update CASCADE,
Constraint FK_CarKilometresId Foreign key (CarKilometresId) References CarKilometres(IdCarKilometres) On Delete CASCADE On Update CASCADE,
Constraint FK_CarGearboxesId Foreign key (CarGearboxesId) References CarGearboxes(IdCarGearboxes) On Delete CASCADE On Update CASCADE,
Constraint FK_CarTransmissionsId Foreign key (CarTransmissionsId) References CarTransmissions(IdCarTransmissions) On Delete CASCADE On Update CASCADE,
Constraint FK_NewCarsId Foreign key (NewCarsId) References NewCars(IdNewCars) On Delete CASCADE On Update CASCADE,
Constraint FK_CarPricesId Foreign key (CarPricesId) References CarPrices(IdCarPrices) On Delete CASCADE On Update CASCADE,
Constraint FK_CarQuantitiesId Foreign key (CarQuantitiesId) References CarQuantities(IdCarQuantities) On Delete CASCADE On Update CASCADE,
Constraint FK_AdminsId Foreign key (AdminsId) References Admins(IdAdmins) On Delete CASCADE On Update CASCADE
)


Insert Into CarGallery.dbo.Cars(CarBrandsandModelsId, ManufactureYearsId,CarBodyStylesId,CarColorsId,CarEnginesId,CarEnginePowersId,
CarFueltypesId,CarKilometresId,CarGearboxesId,CarTransmissionsId,NewCarsId,CarPricesId,CarQuantitiesId,AdminsId)
values
(1,1,1,1,1,6,1,1,1,1,1,1,1,1),
(15,5,2,2,15,5,1,1,1,1,1,1,1,1),
(10,5,2,2,15,5,1,1,1,2,2,1,1,1),

(12,8,2,2,15,5,1,1,1,2,2,26,1,1),
(20,8,2,2,3,3,1,1,1,2,2,26,1,1),
(25,8,2,2,3,3,1,18,1,2,2,26,1,1)




