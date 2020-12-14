create or replace procedure spInsert_kiadok
(
    p_nev in kiadok.nev%type,
    p_out_rowcnt out int
)
authid definer
as
    v_id int;
begin
	p_out_rowcnt := 0;
    select max(id) into v_id from kiadok;
	if v_id is null then		
		v_id := 0;
	end if;
    v_id := v_id + 1;
    insert into
    	kiadok(id, nev)
    values
    	(v_id, p_nev);
    p_out_rowcnt := SQL%rowcount;
    commit;
end sp_insertKiadok;