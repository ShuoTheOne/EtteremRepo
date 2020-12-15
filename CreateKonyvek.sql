drop table books;
create table books
(
    konyv_id char(4) not null,
    raktari_szam char(10) not null,
    kiado_id int not null,
    cim varchar2(100) not null,
    mufaj varchar2(60) not null,
    kiadas_eve date not null,
    
    constraint pk_books primary key(konyv_id),
    constraint uq_books_raktari_szam unique(raktari_szam),
    constraint fk_kiadok foreign key(kiado_id)
        references kiadok(id)
);
