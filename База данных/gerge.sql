USE [dmitriichuk_kp]
GO
/****** Object:  View [dbo].[Raschet_skidki]    Script Date: 12/18/2023 00:47:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Дмитрийчук Антон 4-МД-15

CREATE VIEW [dbo].[Raschet_skidki]

	as

	select dbo.Пациенты.Код_пациента, dbo.Пациенты.Фамилия, dbo.Пациенты.Имя, dbo.Пациенты.Отчество, dbo.Пациенты.Номер_паспорта, dbo.Пациенты.Контингент, 
	(
		Case dbo.Пациенты.Контингент 
			when 'ДМС' then 0
			when 'Ветеран ВОВ' then 50
			when 'Инвалид 1 группы' then 40
			when 'Инвалид 2 группы' then 45
			when 'Инвалид 3 группы' then 50
			when 'Пенсионер' then 50 
		End
	) as Скидка
	from dbo.Пациенты
GO
/****** Object:  View [dbo].[ProfitPerMonth]    Script Date: 12/18/2023 00:47:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProfitPerMonth]
	AS 
	
	SELECT (case DATEPART(mm, dbo.Учет_платных_услуг.Дата_начала_оказания_услуг)
			when '12' then 'Декабрь'
			when '11' then 'Ноябрь'
			when '10' then 'Октябрь'
			when '9' then 'Сентябрь'
			when '8' then 'Август'
			when '7' then 'Июль'
			when '6' then 'Июнь'
			when '5' then 'Май'
			when '4' then 'Апрель'
			when '3' then 'Март'
			when '2' then 'Февраль'
			when '1' then 'Январь'
		end
	) as Месяц,  sum(dbo.Учет_платных_услуг.Итоговая_стоимость) as Рублей_в_месяц
	from dbo.Учет_платных_услуг
	group by dbo.Учет_платных_услуг.Дата_начала_оказания_услуг
GO
/****** Object:  View [dbo].[MonthStatistic]    Script Date: 12/18/2023 00:47:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Дмитрийчук Антон 4-МД-15

CREATE VIEW [dbo].[MonthStatistic]
	AS 
	SELECT (
		case DATEPART(mm, dbo.Учет_платных_услуг.Дата_начала_оказания_услуг)
			when '12' then 'Декабрь'
			when '11' then 'Ноябрь'
			when '10' then 'Октябрь'
			when '9' then 'Сентябрь'
			when '8' then 'Август'
			when '7' then 'Июль'
			when '6' then 'Июнь'
			when '5' then 'Май'
			when '4' then 'Апрель'
			when '3' then 'Март'
			when '2' then 'Февраль'
			when '1' then 'Январь'
		end
	) as Месяц, count(dbo.Учет_платных_услуг.Код_услуги) as Количество_за_период
	from dbo.Учет_платных_услуг
	group by dbo.Учет_платных_услуг.Дата_начала_оказания_услуг
GO
/****** Object:  View [dbo].[Contracts]    Script Date: 12/18/2023 00:47:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Contracts]
	AS 

	select REPLACE(Convert(nvarchar, dbo.Учет_платных_услуг.Дата_начала_оказания_услуг) +  
	Convert(nvarchar,dbo.Учет_платных_услуг.Код_пациента), '-', '') as Номер_договора, 
	
	dbo.Пациенты.Фамилия + ' ' + dbo.Пациенты.Имя + ' ' + dbo.Пациенты.Отчество as [ФИО пациента],

	dbo.Пациенты.Номер_паспорта + ' ' + dbo.Пациенты.Серия_паспорта as [Номер\Серия паспорта],

	dbo.Пациенты.Адрес_проживания as [Адрес проживания],

	dbo.Учет_платных_услуг.Дата_начала_оказания_услуг as [Дата заключения договора],

	sum(dbo.Учет_платных_услуг.Итоговая_стоимость) as [Итоговая стоимость],

	string_agg(dbo.Услуги.Наименование_услуги, '; ') as [Заказанные услуги]

	from dbo.Учет_платных_услуг, dbo.Пациенты, dbo.Услуги
	where dbo.Учет_платных_услуг.Код_пациента = dbo.Пациенты.Код_пациента 
	AND dbo.Учет_платных_услуг.Код_услуги = dbo.Услуги.Код_услуги
	group by dbo.Учет_платных_услуг.Дата_начала_оказания_услуг, dbo.Учет_платных_услуг.Код_пациента, 
	dbo.Пациенты.Фамилия, dbo.Пациенты.Имя, dbo.Пациенты.Отчество,
	dbo.Пациенты.Номер_паспорта, dbo.Пациенты.Серия_паспорта, dbo.Пациенты.Код_пациента, dbo.Пациенты.Адрес_проживания
GO
/****** Object:  StoredProcedure [dbo].[Add_in_contract]    Script Date: 12/18/2023 00:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Дмитрийчук Антон 4-МД-15

CREATE PROCEDURE [dbo].[Add_in_contract]

	@NumP nvarchar (20),
	@usluga nvarchar (150),
	@surname_doctor nvarchar (20),
	@specialization nvarchar (50),
	@type_name_uslugi nvarchar (150),
	@doctor_position nvarchar (50),
	@scope_of_services nvarchar (20),
	@skidka nvarchar(10),
	@cost nvarchar(20),
	@date_start Date,
	@date_end Date

AS
	insert into dbo.Учет_платных_услуг 
	(Код_пациента, Код_сотрудника, Код_услуги, Код_вида_услуги, Код_должности, Код_специализации,
	 Объем_услуг, Скидка_процент, Итоговая_стоимость, Дата_начала_оказания_услуг, Дата_окончания_оказания_услуг)
	values 
	(
		(select dbo.Пациенты.Код_пациента
		 from dbo.Пациенты
		 where dbo.Пациенты.Номер_паспорта = @NumP),
		(select dbo.Сотрудники.Код_сотрудника
		 from dbo.Сотрудники
		 where dbo.Сотрудники.Фамилия = @surname_doctor),
		(select dbo.Услуги.Код_услуги
		 from dbo.Услуги
		 where dbo.Услуги.Наименование_услуги = @usluga),
		(select dbo.Вид_услуги.Код_вида_услуги
		 from dbo.Вид_услуги
		 where dbo.Вид_услуги.Наименование_вида_услуги = @type_name_uslugi),
		(select dbo.Должности.Код_должности
		 from dbo.Должности
		 where dbo.Должности.Наименование_должности = @doctor_position),
		(select dbo.Реестр_специализаций.Код_специализации
		 from dbo.Реестр_специализаций
		 where dbo.Реестр_специализаций.Наименование_специализации = @specialization),
		 @scope_of_services, @skidka, @cost, @date_start, @date_end
	)
GO
/****** Object:  StoredProcedure [dbo].[add_client]    Script Date: 12/18/2023 00:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Дмитрийчук Антон 4-МД-15

CREATE PROCEDURE [dbo].[add_client]

	@surname nvarchar(20),
	@name nvarchar(20),
	@patronimyc nvarchar(20),
	@contingent nvarchar(40),
	@date_of_birth date,
	@address nvarchar(50),
	@NumP nvarchar(20),
	@series_passport nvarchar(20),
	@phone nvarchar(20),
	@kod_pacienta smallint = null
AS

select @kod_pacienta = max(dbo.Пациенты.Код_пациента)
from dbo.Пациенты

insert into Пациенты (Код_пациента, Фамилия, Имя, Отчество, Контингент, Дата_рождения,
Адрес_проживания, Номер_паспорта, Серия_паспорта, Номер_телефона)

values ((@kod_pacienta +1), @surname, @name, @patronimyc, @contingent, @date_of_birth,
@address, @NumP, @series_passport, @phone)
GO
/****** Object:  StoredProcedure [dbo].[Raschet_stoimosti]    Script Date: 12/18/2023 00:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Дмитрийчук Антон 4-МД-15

CREATE PROCEDURE [dbo].[Raschet_stoimosti]
	@num_passport nvarchar(20),
	@name_uslugi nvarchar(200)

AS

	Select dbo.Пациенты.Номер_паспорта, dbo.Услуги.Код_услуги, dbo.Raschet_skidki.Скидка as skidka, 
	(
		case 
			when dbo.Raschet_skidki.Скидка = 0 then dbo.Услуги.Цена_услуги
			when dbo.Raschet_skidki.Скидка > 0 then dbo.Услуги.Цена_услуги - (dbo.Услуги.Цена_услуги * dbo.Raschet_skidki.Скидка/100) 
		end
	) as finCost
	from dbo.Пациенты, dbo.Raschet_skidki, dbo.Услуги
	where dbo.Пациенты.Номер_паспорта = @num_passport 
	AND dbo.Raschet_skidki.Контингент = dbo.Пациенты.Контингент 
	AND dbo.Услуги.Наименование_услуги = @name_uslugi
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [T1]
	ON [dbo].[Пациенты]
	FOR INSERT
	AS
	BEGIN

		if (select count(*) from inserted where Дата_рождения between N'01.01.1753' 
		and N'01.01.1900') >0
			BEGIN 
				Raiserror (N'Дата рождения указана некорректно', 16, 1)
				rollback transaction
			END
		if (select count(*) from inserted where Номер_паспорта like '%[A-Za-zА-Яа-я]%' or
		    Серия_паспорта like '%[A-Za-zА-Яа-я]%') > 0
			begin
				Raiserror (N'Номер или серия паспорта указаны некорректно. Допустимые значения 0-9', 16, 1)
				rollback transaction
			end

	END
GO