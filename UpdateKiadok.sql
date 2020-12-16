create or replace procedure spUpdate_kiadok
(
	p_id  in kiadok.id%type,
	p_nev in kiadok.nev%type,
	p_out_rowcnt out int
)
authid definer
as
	v_id int;
begin 
	p_out_rowcnt := 0;
	select id into v_id from kiadok;
	if v_id is null then		
		v_id := 0;
	end if;
	update kiadok set nev = p_nev where id = p_id;
	p_out_rowcnt := SQL%rowcount;
    commit;
  end spUpdate_kiadok;
