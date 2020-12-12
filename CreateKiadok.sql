drop table kiadok;
create table kiadok
(
    id int not null,
    nev varchar2(250) not null,
    
    constraint pk_kiadok primary key(id)
);