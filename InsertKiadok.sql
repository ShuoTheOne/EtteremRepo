create or replace procedure sp_insertKiadok
(
    p_nev in kiadok.nev%type
)
authid definer
as
    v_id int;
begin
    select max(id) into v_id from kiadok;
	if v_id is null then		
		v_id := 0;
	end if;
    v_id := v_id + 1;
    insert into kiadok(id, nev)
    values(v_id, p_nev);
end sp_insertKiadok;