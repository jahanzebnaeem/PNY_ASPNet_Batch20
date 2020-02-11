--select [Name] from country;
--select [Name] from city;
select Country.Name, City.Name 
	from Country inner join City 
	on Country.ID = City.CountryID;


