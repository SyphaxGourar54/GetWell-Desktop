use getwell

select * from medecin where Username = 'Mohamed54'



EXEC NonValidatedRvList @Id_Doc = 2

select * from rendezvous 

--
--Add this to the hosted database
declare @salt uniqueidentifier; 
set @salt = newid(); 

insert into medecin(Username,Password, salt, Nom, Prenom, Tel, Email, Nbrpatients, ville, Adresse, Facebook, Instagram, latitude, longitude) 
values('AhmedMoulay',HASHBYTES('sha2_512','azerty' + CAST(@salt as nvarchar(50))), @salt , 'Moulay', 'Ahmed', '0642966972', 'Mohammed.Gourar10@gmail.com', 10, 'Safi', 'Saida1, 1092, Safi', 'facebook.com', 'instagram.com', 32.29390352355257,  -9.236294690915447); 



alter table patient alter column Email varchar(35); 
alter table rendezvous add validation bit; 

insert into patient values('EE93930', 'Ahmed', 'Mansour', '2000-03-12', '0653228478', 'Ahmed.Ahmed@gmail.com')
insert into patient values('EE92290', 'Mahmoud', 'Aalian', '1990-04-02', '0698278726', 'Mahmoud15@gmail.com')
insert into categorie values('la radiologie', 'diagnostiques et thérapeutiques utilisant les rayons X', 2); 
insert into rendezvous(Date, dateprise, temp_rdv, #Id_patient, #Id_doc, #Id_cat) values('2021-05-12', '2021-05-02', '09:00', 2, 2, 2)
insert into rendezvous(Date, dateprise, temp_rdv, #Id_patient, #Id_doc, #Id_cat) values('2021-05-12', '2021-05-01', '11:00', 3, 2, 2)


insert into rendezvous(Date, dateprise, temp_rdv, #Id_patient, #Id_doc, #Id_cat) values('2021-05-12', '2021-05-01', '14:00', 3, 2, 2)
insert into rendezvous(Date, dateprise, temp_rdv, #Id_patient, #Id_doc, #Id_cat) values('2021-05-12', '2021-05-01', '16:00', 3, 2, 2)

insert into rendezvous(Date, dateprise, temp_rdv, #Id_patient, #Id_doc, #Id_cat) values('2021-05-22', '2021-05-21', '15:00', 3, 2, 2)
insert into rendezvous(Date, dateprise, temp_rdv, #Id_patient, #Id_doc, #Id_cat) values('2021-05-22', '2021-05-21', '14:00', 3, 2, 2)





create proc NewRv @Id_Doc int

as
begin

select count(*) from rendezvous where #Id_doc = @Id_Doc and validation is NULL

end


create proc NonValidatedRvList @Id_Doc int
as
begin
select rendezvous.Id_rv as 'Id', rendezvous.Date, rendezvous.dateprise as 'DatePrise', rendezvous.temp_rdv as 'Temp', CONCAT( patient.Nom, ' ', patient.Prenom) as patient, categorie.Nom as 'Categorie', rendezvous.validation from rendezvous inner join patient on rendezvous.#Id_patient = patient.Id_patient inner join categorie on categorie.#Id_doc = rendezvous.#Id_cat where rendezvous.#Id_doc = @Id_Doc and rendezvous.validation is NULL order by rendezvous.dateprise DESC; 
end



create proc AcceptRv @Id_rv int
as 
begin
update rendezvous set validation = 1 where rendezvous.Id_rv = @Id_rv; 
end

create proc RefuserRv @Id_rv int
as 
begin
update rendezvous set validation = 0 where rendezvous.Id_rv = @Id_rv; 
end





