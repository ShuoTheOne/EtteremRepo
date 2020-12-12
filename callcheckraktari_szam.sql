set serveroutput on;
declare 
    v_call_raktari_szam int;
    v_raktari_szam konyvek.raktari_szam%type := 'BD12345678';
begin
v_call_raktari_szam := sf_check_raktari_szam(v_raktari_szam);
    IF v_call_raktari_szam = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Az alábbi raktári szám helyes: '||v_raktari_szam);
    ELSE 
        DBMS_OUTPUT.PUT_LINE('Az alábbi raktári szám helytelen: '||v_raktari_szam);    
    END IF;
END;