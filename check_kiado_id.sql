create or replace function sf_check_kiado_id
(
    p_id  in kiadok.id%type
)
return int
deterministic
as
    v_id_char char(1);
    v_i int;
begin
    if p_id is null then
        return 0;
    end if;

    return 1;
end sf_check_konyv_id;