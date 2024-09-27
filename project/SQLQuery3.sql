create table book(pname varchar(20),fligtid int,seat int,src varchar(20),dest varchar(20))
select*from book

create table tblflight(filghtid int primary key identity,takeofdate date,pick varchar(20),destination varchar(20))
select*from tblflight