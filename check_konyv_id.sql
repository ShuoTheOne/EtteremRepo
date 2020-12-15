create or replace function sf_check_konyv_id
(
    p_id  in books.id%type
)
return int
deterministic
as
begin
    if p_id is null then
        return 0;
    end if;

    return 1;
end sf_check_konyv_id;