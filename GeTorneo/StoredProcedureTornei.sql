create procedure AggiungiTorneo
	@Nome varchar(20),
	@Durata int,
	@Num_Max int,
	@Regolamento nvarchar(200),
	@Premio float,
	@Descrizione nvarchar(200)
as
	INSERT INTO Tornei(Nome,Durata,Num_Max,Regolamento,Premio,Descrizione) VALUES(@Nome,@Durata,@Num_Max,@Regolamento,@Premio,@Descrizione);
go
drop procedure AggiungiTorneo
go
