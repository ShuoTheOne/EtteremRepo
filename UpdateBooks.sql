create or replace procedure spUpdate_books
(
	p_id in books.id%type,
	p_raktari_szam in books.raktari_szam%type,
	p_kiado_id in books.kiado_id%type,
	p_cim in books.cim%type,
    p_mufaj in books.mufaj%type,
    p_kiadas_eve in books.kiadas_eve%type
)
as
begin
	UPDATE books SET raktari_szam = p_raktari_szam, kiado_id = p_kiado_id, cim = p_cim, mufaj = p_mufaj, kiadas_eve = p_kiadas_eve WHERE id = p_id;
end spUpdate_books;