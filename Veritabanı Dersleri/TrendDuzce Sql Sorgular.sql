insert into Marka values ('Adidas'),('Nike'),('Kinetix')
select * from Marka

insert into Kategori values('Ayakkabý')
select * from Kategori

insert into Kullanici values('Ýskender','Atalay','zeebody','12345')
select * from Kullanici

insert into Satici values('XZCorp','Duzce','Gorsel','1')
select * from Satici

insert into Urun values('1','1','1','SporAyakkabý')
select * from Urun

insert into SaticiUrun values('1','1','200')
select * from Marka
select * from Kategori
select * from Kullanici
select * from Satici
select * from Urun
select * from SaticiUrun

insert into Kullanici values('Ali','Veli','xene','7889')
select * from Kullanici

insert into Satici values('XZ','Duzce','Gorsel','2')
select * from Satici

insert into Urun values('3','2','1','GundelikAyakkabý')
select * from Urun

insert into SaticiUrun values('2','2','300')
select * from SaticiUrun

select * from Marka
select * from Kategori
select * from Kullanici
select * from Satici
select * from Urun
select * from SaticiUrun

select Marka.MarkaAdi,Kategori.KategoriAdi,Urun.Model from
Marka inner join 
Urun on
Marka.MarkaID = Urun.MarkaID
inner join
Kategori on 
Kategori.KategoriID=Urun.KategoriID

select Satici.FirmaAdi,Satici.Adres,Satici.FirmaGorsel,
Kullanici.Ad,Kullanici.Soyad,Kullanici.KullaniciAdi,Kullanici.Sifre from
Kullanici inner join
Satici on
Kullanici.KullaniciID=Satici.KullaniciID
