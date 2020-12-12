create or replace function sf_check_raktari_szam
(
    p_raktari_szam  in konyvek.raktari_szam%type
)
return int
deterministic
as
    v_raktari_szam_char char(1);
    v_i int;
begin
    if p_raktari_szam is null then
        return 0;
    end if;

    if length(trim(p_raktari_szam)) = 10 then
        v_i := 1;
        while v_i <= 2 loop
            v_raktari_szam_char := substr(p_raktari_szam, v_i, 2);
            if not (ascii('A') <= ascii(v_rendszam_char) and ascii(v_raktari_szam_char) <= ascii('Z')) then
                return 0;            
            end if;
            v_i := v_i + 1;
        end loop;

        while v_i <= 8 loop
            v_raktari_szam_char := substr(p_raktari_szam, v_i, 1);
            if not (ascii('0') <= ascii(v_raktari_szam_char) and ascii(v_raktari_szam_char) <= ascii('9')) then
                return 0;            
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_raktari_szam;