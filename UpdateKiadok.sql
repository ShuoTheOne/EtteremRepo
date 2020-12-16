create or replace procedure spUpdate_kiadok
(
	p_id in kiadok.id%type,
	p_nev in kiadok.nev%type
)
as
begin
	UPDATE kiadok SET nev = p_nev WHERE id = p_id;
end spUpdate_kiadok;