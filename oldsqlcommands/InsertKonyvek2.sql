create or replace procedure spInsert_books(
	p_konyv_id in books.konyv_id%type,
	p_raktari_szam in books.raktari_szam%type,
	p_kiado in kiadok.nev%type,
    p_mufaj in books.mufaj%type,
    p_cim in books.cim%type,
    p_kiadas_eve in books.kiadas_eve%type
)	
authid definer
as
	v_id int;
    v_kiado_id int;
	v_check_konyv_id int;
begin
	select max(konyv_id) into v_id from books;
		if v_id is null then
			v_id :=0;
		end if;
	v_id := v_id + 1;
	v_kiado_id := sf_GetKiadoId(p_kiado);
	v_check_konyv_id := sf_check_konyv_id(p_konyv_id);
	if v_kiado_id is not null and v_check_konyv_id = 0 then	 
		insert into books(konyv_id, raktari_szam, kiado_id, mufaj, cim, kiadas_eve)
			values(v_id, p_raktari_szam, v_kiado_id, p_mufaj, p_cim, p_kiadas_eve);		
	end if;
	commit;
end spInsert_books;