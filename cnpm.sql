create database cnpm
use cnpm
create table accountant
(
	acc_username NVARCHAR (20)PRIMARY KEY,
	acc_pass NVARCHAR(20),
)

create table receipt
(
	receipt_id NVARCHAR(20) not null PRIMARY KEY,
	receipt_name NVARCHAR(20) not null,
)
create table product
(
	prod_id NVARCHAR(20) not null PRIMARY KEY,
	prod_name NVARCHAR(20) not null,
	prod_unit NVARCHAR(20) not null,
	prod_cost INT not null,
	prod_price INT not null,
	prod_belong NVARCHAR(20),
)
INSERT INTO accountant VALUES ('admin123','admin123');
create table product2
(
	prod_id NVARCHAR(20) not null  ,
	prod_name NVARCHAR(20) not null,
	prod_unit INT not null,
	prod_price INT not null,
	prod_belong NVARCHAR(20) not null,
	PRIMARY KEY(prod_id, prod_belong)
)
create table bill
(
	bill_id NVARCHAR(20) not null PRIMARY KEY,
	cus_name NVARCHAR(20) not null,
	cus_address NVARCHAR(20) not null,
	bill_time NVARCHAR(20) not null,
	delivery_status NVARCHAR(20) not null,
	payment_status NVARCHAR(20) not null,
	bill_total INT not null,
)

select * from bill
select * from product2
delete from bill
delete from product2
drop table bill
drop table product2



drop database cnpm
drop table accountant
select * from accountant
select * from receipt
select * from product
delete from receipt
delete from product
drop table receipt
drop table product
