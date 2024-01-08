insert into Ogrenci(Ad,Soyad,OgrNo) values('Betul','Kara','123')
select * from Ogrenci

insert into Ogrenci values('Ali','Veli','345')
select * from Ogrenci

select Ad from Ogrenci
select Soyad from Ogrenci

select Soyad as OgrenciSoyad from Ogrenci

select Soyad from Ogrenci where OgrenciID=2

select * from Ogrenci where OgrenciID=2

insert into Ogrenci values('Ali',null,'345')

insert into Ogrenci values('Hasan','Mahmut','78')
select * from Ogrenci

update Ogrenci set Soyad='Ersoy' where OgrenciID=5
select * from Ogrenci where OgrenciID=5

update Ogrenci set Ad='Mehmet', Soyad='Akif' where OgrenciID=5
select * from Ogrenci where OgrenciID=5

update Ogrenci set Ad='Mehmet', Soyad='Akif' , OgrNo='132'
select * from Ogrenci 

delete from Ogrenci where OgrenciID=5
select * from Ogrenci 

insert into Ogrenci values('Mert','Can','789')
select * from Ogrenci 

delete from Ogrenci
select * from Ogrenci 

insert into Ogrenci values('Betül','Kara','123456')
select * from Ogrenci 

insert into Ogrenci values('Ali','Veli','9789')
select * from Ogrenci 

update Ogrenci set Ad='Betül' where OgrenciID=7
select * from Ogrenci 

insert into Ogrenci values('Ayse','Kaya','456')
select * from Ogrenci 

update Ogrenci set Ad='Seyma' where OgrenciID=9
select * from Ogrenci 

delete Ogrenci where OgrenciID=9
select * from Ogrenci 

insert into Ders values('BM101','Matematik'),('BM102','Fizik'),('BM103','Programlama Giris'),('BM104','Istatistik')
select * from Ders 
select * from Ogrenci

insert into OgrenciDers (OgrenciID,DersID) values (7,3),(8,1),(7,4)
select * from OgrenciDers

insert into OgrenciDers (OgrenciID,DersID) values (7,2),(7,1),(8,3)
select * from OgrenciDers

select * from Ogrenci 
inner join OgrenciDers on Ogrenci.OgrenciID=OgrenciDers.OgrenciID
inner join Ders on Ders.DersID=OgrenciDers.DersID

select * from Ders 
select * from Ogrenci
select * from OgrenciDers