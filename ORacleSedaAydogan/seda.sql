CREATE TABLE TblOgrenci (
         TcNo     VARCHAR2(11)  NOT NULL,
         Adi      VARCHAR2(50),
         Soyadi     VARCHAR2(50),
         OgrenciNo       VARCHAR2(10),
         KayitTarihi   DATE DEFAULT (sysdate),
		 BolumId    int,
		 Sinif      VARCHAR2(10),
		 Adres      VARCHAR2(150),
		 CepTel    VARCHAR2(15),
		 DogumTarihi  DATE,
         ResimYolu     BLOB,
          CONSTRAINT TcNo_pk PRIMARY KEY (TcNo),
  CONSTRAINT frk_Bolumid
    FOREIGN KEY (BolumId)
    REFERENCES TblBolum(BolumId)
);
   
  CREATE TABLE TblOgrenciNot (
		 Id    int,
		 OgrenciTc  VARCHAR2(11),
		 DersId     int,
		 Vize       int,
		 Final      int,
		 Ortalama   int,
		 Harf       VARCHAR(2),
          CONSTRAINT Id_pk PRIMARY KEY (Id),
  CONSTRAINT fk_OgrenciTc
    FOREIGN KEY (OgrenciTc)
    REFERENCES TblOgrenci(TcNo),
	CONSTRAINT fk_DersId
    FOREIGN KEY (DersId)
    REFERENCES TblDers(DersId)
	
);
    
	  CREATE TABLE TblDers (
		 DersId    int NOT NULL,
		 DersAdi  VARCHAR2(50),
		 BolumId     int,
          CONSTRAINT DersId_pk PRIMARY KEY (DersId),
  CONSTRAINT fk_BolumId
    FOREIGN KEY (BolumId)
    REFERENCES TblBolum(BolumId)
);

	  CREATE TABLE TblBolum (
		 BolumId    int NOT NULL,
		 BolumAdi   VARCHAR2(50),
          CONSTRAINT BolumId_pk PRIMARY KEY (BolumId)
);

 INSERT INTO TblBolum
(BolumId,BolumAdi)
VALUES
(seq_id.NEXTVAL,'Makina Mühendisliði' );

select * from TblBolum;

ALTER TABLE TblBolum
  ADD TelNo varchar2(45);
  
  ALTER TABLE TblBolum
  ADD email varchar2(70);
  
  
  insert into TBLBOLUM(BolumId,BolumAdi,TelNo,email) values( seq_id.NEXTVAL,'','','')
  select * from TBLBOLUM
  delete from TBLBOLUM
  where BOLUMID=6
  
  DECLARE  
  CURSOR dept_cursor IS     
  SELECT BOLUMID   
  FROM TBLBOLUM      
  ORDER BY BOLUMID;
  BEGIN   
  FOR v_dept_record IN dept_cursor     
  LOOP      
  DBMS_OUTPUT.PUT_LINE( v_dept_record.BOLUMID);       
  END LOOP; 
  END; 
  
  
  select * from TBLOGRENCI;
DELETE  FROM TBLDERS WHERE DERSID=41



ALTER TABLE TBLOGRENCINOT
  ADD ogrenci_id int
  
  ALTER TABLE customers
  ADD customer_name varchar2(45);
  
  ALTER TABLE  TBLOGRENCINOT
ADD CONSTRAINT fk_ogrenci
  FOREIGN KEY (OGRENCI_ID)
  REFERENCES TBLOGRENCI(IDOGRENCI);
  
ALTER TABLE TBLOGRENCINOT
ADD CONSTRAINT fk_ogrenci FOREIGN KEY (ogrenci_id);

ALTER TABLE TBLOGRENCI
ADD CONSTRAINT tcno UNIQUE (TCNO);

INSERT INTO TblBolum
(,BolumAdi)
VALUES
(seq_id.NEXTVAL,'Makina Mühendisliði' );
delete from TBLOGRENCI
ALTER TABLE products
DROP CONSTRAINT fk_supplier;
select* from TBLOGRENCI

SELECT TCNO,ADI,SOYADI,OGRENCINO,KAYITTARIHI,BOLUMADI,SINIF,ADRES,CEPTEL,DOGUMTARIHI,IDOGRENCI FROM TBLOGRENCI INNER JOIN TBLBOLUM ON TBLOGRENCI.BOLUMID = TBLBOLUM.BOLUMID

UPDATE TBLOGRENCI SET TCNO='38947187850',ADI='SEDA',SOYADI='AY',OGRENCINO='1410020',KAYITTARIHI='',BOLUMID=40,SINIF='3',ADRES='',CEPTEL='',DOGUMTARIHI='' WHERE IDOGRENCI=71

ALTER TABLE TBLOGRENCI
  MODIFY TCNO varchar2(200) 
  
  ALTER TABLE TBLOGRENCI
  ADD  CONSTRAINT ck_tel 
  CHECK  (CEPTEL like '0([0-9][0-9][0-9]) [0-9][0-9][0-9] [0-9][0-9] [0-9][0-9]')