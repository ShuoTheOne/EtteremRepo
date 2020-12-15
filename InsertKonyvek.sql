create or replace procedure spInsert_books
(
    p_id in books.id%type,
	p_raktari_szam in books.raktari_szam%type,
	p_kiado in kiadok.nev%type,
    p_mufaj in books.mufaj%type,
    p_cim in books.cim%type,
    p_kiadas_eve in books.kiadas_eve%type,
    p_out_rowcnt out int
)
authid definer
as
    v_id int;
    v_kiado_id int;
begin
	p_out_rowcnt := 0;
    select max(id) into v_id from books;
	if v_id is null then		
		v_id := 0;
	end if;
    v_id := v_id + 1;
    v_kiado_id := sf_GetKiadoId(p_kiado);
    insert into
    	books(id, raktari_szam, kiado_id, mufaj, cim, kiadas_eve)
    values
    	(v_id, p_raktari_szam, v_kiado_id, p_mufaj, p_cim, p_kiadas_eve);
    p_out_rowcnt := SQL%rowcount;
    commit;
end spInsert_books;