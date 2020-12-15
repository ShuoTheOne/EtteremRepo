create or replace function sf_check_konyv_id
(
    p_konyv_id  in books.konyv_id%type
)
return int
deterministic
as
begin
    if p_konyv_id is null then
        return 0;
    end if;
        if length(trim(p_konyv_id)) = 4 then
            if p_konyv_id >999 and p_konyv_id < 10000 then 
                return 1;
            end if;
    end if;
    return 0;
end sf_check_konyv_id;