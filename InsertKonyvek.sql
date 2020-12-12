create or replace procedure spInsert_konyvek(
    p_konyv_id  in konyvek.konyv_id%type,
    p_raktari_szam in konyvek.raktari_szam%type,
    p_kiado    in kiadok.nev%type,
    p_mufaj     in konyvek.mufaj%type,
    p_cim in konyvek.cim%type,
    p_kiadas_eve   in konyvek.kiadas_eve%type,
    p_out_rowcnt out int
)
authid definer
as
    v_check_konyv_id int;
    v_kiado_id int;
begin
    p_out_rowcnt := 0;
    v_kiado_id := sf_getKiadoId(p_kiado);
    if v_kiado_id is null then
        sp_insertKiadok(p_kiado);
        v_kiado_id := sf_getKiadoId(p_kiado);
    end if;
    v_check_konyv_id := sf_check_konyv_id(p_konyv_id);
    if v_check_konyv_id = 1 then
        insert into konyvek
            (konyv_id, raktari_szam, kiado_id, mufaj, cim, kiadas_eve)
        values
            (p_kiado_id, p_raktari_szam, v_kiado_id, p_mufaj, p_cim, p_kiadas_eve);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
end spInsert_konyvek;