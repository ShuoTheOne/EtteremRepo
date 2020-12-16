drop table books;
create table books
(
    id int not null,
    raktari_szam char(10) not null,
    kiado_id varchar2(250) not null,
    cim varchar2(100) not null,
    mufaj varchar2(60) not null,
    kiadas_eve date not null,
    
    constraint pk_books primary key(id),
    constraint uq_books_raktari_szam unique(raktari_szam),
    constraint fk_kiadok foreign key(kiado_id)
        references kiadok(id)
);
