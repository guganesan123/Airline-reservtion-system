create table tblflight(filghtid int primary key identity,takeofdate date,pick varchar(20),destination varchar(20))
select*from tblflight

use flight

create table passingers(pname varchar(20),flightid int foreign key references tblflight(filghtid),seatno int primary key ,src varchar(20),dest varchar(20))
select*from passingers

create table booked(pname varchar(20),flightid int foreign key references tblflight(filghtid),seatno int primary key ,src varchar(20),dest varchar(20))
