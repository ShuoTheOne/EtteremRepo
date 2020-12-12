drop table konyvek;
create table konyvek
(
    konyv_id char(6) not null,
    raktari_szam char(9) not null,
    kiado_id int not null,
    cim varchar2(100) not null,
    mufaj varchar2(60) not null,
    kiadas_eve date not null,
    
    constraint pk_konyvek primary key(konyv_id),
    constraint uq_konyvek_raktari_szam unique(raktari_szam),
    constraint fk_kiadok foreign key(kiado_id)
        references kiadok(id)
);
