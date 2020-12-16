create or replace procedure spUpdate_kiadok
(
	p_id  in kiadok.id%type,
	p_nev in kiadok.nev%type
)
authid definer
as
begin 
	update kiadok set nev = p_nev where id = p_id;
    commit;
  end spUpdate_kiadok;