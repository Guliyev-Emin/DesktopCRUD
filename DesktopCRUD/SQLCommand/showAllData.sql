SELECT client.*, flightnumber, departureairport, 
       arrivalairport, datedeparture, datearrival, 
       price 
FROM clients client, flights.public.flights flight 
WHERE client.userid = flight.flightid