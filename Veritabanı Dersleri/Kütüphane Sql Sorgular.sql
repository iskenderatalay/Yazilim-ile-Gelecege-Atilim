insert into Dil values ('Türkçe'),('Ýngilizce'),('Almanca')
select * from Dil

insert into YayinEv values ('ÝþBank'),('YapýKredi')
select * from YayinEv

insert into Yazar values ('Tess','Gerritsen'),('Burak','Aksak')
select * from Yazar

insert into Tur values ('Polisiye'),('Siyasi')
select * from Tur

insert into Kitaplik values ('1','1'),('1','2')
select * from Kitaplik

insert into KullaniciTur values ('Ýskender','Atalay' ,'Ogrenci'),('Betül','Kara','Personel')
select * from KullaniciTur

update KullaniciTur set KTuru = 'Ogrenci' where KTID=1

insert into Kitap values ('Leyla ile Mecnun','2','Dizinin Kitabý','1','1','1','1')
select * from Kitap

insert into Ver values ('1','1','04.01.2024','05.01.2024','04.01.2024')
select * from Ver

select Kitap.KAd, Yazar.YAd, Yazar.YSoyad, Kitap.KAciklama, YayinEv.YEvAd, Tur.TAd, Dil.DAd, Kitaplik.KNo, Kitaplik.KRafNo from
Kitap inner join
Yazar on
Kitap.KYazarID = Yazar.YID
inner join
YayinEv on
Kitap.KYayinEvID = YayinEv.YEvID
inner join
Tur on
Kitap.TurID = Tur.TID
inner join
Dil on
Kitap.DilID = Dil.DilID
inner join
Kitaplik on
Kitap.KitaplikID = Kitaplik.KitaplikID

select KullaniciTur.KAd, KullaniciTur.KSoyad, KullaniciTur.KTuru, Kitap.KAd, Ver.VTarih, Ver.ATarih, Ver.ITarih from
Ver inner join
KullaniciTur on
Ver.KTID = KullaniciTur.KTID
inner join
Kitap on
Ver.KID = Kitap.KID




select * from Dil
select * from YayinEv
select * from Yazar
select * from Tur
select * from Kitaplik
select * from KullaniciTur
select * from Ogrenci
select * from Personel
select * from Kitap
select * from Ver