set serveroutput on;
declare 
    v_call_konyv_id int;
    v_konyv_id konyvek.konyv_id%type := '123456';
begin
v_call_konyv_id := sf_check_konyv_id(v_konyv_id);
    IF v_call_konyv_id = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Az alábbi könyvtári id helyes: '||v_konyv_id);
    ELSE 
        DBMS_OUTPUT.PUT_LINE('Az alábbi könyvtári id helytelen: '||v_konyv_id);    
    END IF;
END;