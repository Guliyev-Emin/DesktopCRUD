CREATE TABLE flights
(
	FlightId SERIAL PRIMARY KEY,
	FlightNumber CHARACTER(6),
	DepartureAirport CHARACTER VARYING(50),
	ArrivalAirport CHARACTER VARYING(50),
	DateDeparture DATE,
	DateArrival DATE,
	Price MONEY
);