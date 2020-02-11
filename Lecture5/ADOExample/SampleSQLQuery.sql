Select * from country;
Select City.ID, City.Name, Country.Name 
	from City inner join Country
	On City.CountryID = Country.ID;