create or replace function sf_check_konyv_id
(
    p_konyv_id  in konyvek.konyv_id%type
)
return int
deterministic
as
    v_konyv_id_char char(1);
    v_i int;
begin
    if p_konyv_id is null then
        return 0;
    end if;

    if length(trim(p_konyv_id)) = 6 then
        v_i := 1;
        while v_i <= 6 loop
            v_konyv_id_char := substr(p_konyv_id, v_i, 1);
            if not (ascii('1') <= ascii(v_konyv_id_char) and ascii(v_konyv_id_char) <= ascii('9')) then
                return 0;            
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_konyv_id;