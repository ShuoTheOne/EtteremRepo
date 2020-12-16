create or replace procedure spInsert_books
(
	p_raktari_szam in books.raktari_szam%type,
	p_kiado_id in books.kiado_id%type,
	p_cim in books.cim%type,
    p_mufaj in books.mufaj%type,
    p_kiadas_eve in books.kiadas_eve%type,
    p_out_rowcnt out int
)
authid definer
as
    v_id int;
begin
	p_out_rowcnt := 0;
    select max(id) into v_id from books;
	if v_id is null then		
		v_id := 0;
	end if;
    v_id := v_id + 1;
    insert into
    	books(id, raktari_szam, kiado_id, cim, mufaj,  kiadas_eve)
    values
    	(v_id, p_raktari_szam, p_kiado_id, p_cim, p_mufaj, p_kiadas_eve);
    p_out_rowcnt := SQL%rowcount;
    commit;
end spInsert_books;