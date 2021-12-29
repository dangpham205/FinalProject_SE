create database cnpm
use cnpm
drop database cnpm
--CREATE TABLE
--accountant
create table accountant
(
	acc_username NVARCHAR (20)PRIMARY KEY,
	acc_pass NVARCHAR(20),
)
drop table accountant
INSERT INTO accountant VALUES ('admin123','admin123');
select * from accountant


--Goods received
create table receipt
(
	receipt_id NVARCHAR(20) not null PRIMARY KEY,
	receipt_name NVARCHAR(20) not null,
)


--Product
create table product
(
	prod_id NVARCHAR(20) not null PRIMARY KEY,
	prod_name NVARCHAR(20) not null,
	prod_unit NVARCHAR(20) not null,
	prod_price INT not null,
	prod_belong NVARCHAR(20)not null FOREIGN KEY REFERENCES receipt(receipt_id),
)