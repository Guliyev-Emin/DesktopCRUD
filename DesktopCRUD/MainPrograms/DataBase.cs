using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopCRUD.Models;
using Npgsql;

namespace DesktopCRUD.MainPrograms;

public static class DataBase
{
    private static NpgsqlConnection _connection;
    private static bool _nonExistentEntry;

    public static async void Connection()
    {
        const string connection = "Host=localhost;Username=postgres;Password=aza068;Database=flights";
        var npgsqlConnection = new NpgsqlConnection(connection);
        await npgsqlConnection.OpenAsync();
        _connection = npgsqlConnection;
    }

    public static async void CloseConnection()
    {
        await _connection.CloseAsync();
    }

    public static async void Add(Flight flight, Client client)
    {
        using var clientCmd =
            new NpgsqlCommand(
                "INSERT INTO clients(username, usersurname, userbirthday, userpassport, userphone) VALUES (@username, @usersurname, @userbirthday, @userpassport, @userphone)",
                _connection);
        clientCmd.Parameters.AddWithValue("username", client.UserName);
        clientCmd.Parameters.AddWithValue("usersurname", client.UserSurname);
        clientCmd.Parameters.AddWithValue("userbirthday",
            new DateTime(client.UserBirthDay.Year, client.UserBirthDay.Month, client.UserBirthDay.Day));
        clientCmd.Parameters.AddWithValue("userpassport", client.UserPassport);
        clientCmd.Parameters.AddWithValue("userphone", client.UserPhone);
        await clientCmd.ExecuteNonQueryAsync();
        clientCmd.Cancel();

        using var flightCmd =
            new NpgsqlCommand(
                "INSERT INTO flights(flightnumber, departureairport, arrivalairport, datedeparture, datearrival, price) VALUES (@flightnumber, @departureairport, @arrivalairport, @datedeparture, @datearrival, @price)",
                _connection);
        flightCmd.Parameters.AddWithValue("flightnumber", flight.FlightNumber);
        flightCmd.Parameters.AddWithValue("departureairport", flight.DepartureAirport);
        flightCmd.Parameters.AddWithValue("arrivalairport", flight.ArrivalAirport);
        flightCmd.Parameters.AddWithValue("datedeparture",
            new DateTime(flight.DateDeparture.Year, flight.DateDeparture.Month, flight.DateDeparture.Day));
        flightCmd.Parameters.AddWithValue("datearrival",
            new DateTime(flight.DateArrival.Year, flight.DateArrival.Month, flight.DateArrival.Day));
        flightCmd.Parameters.AddWithValue("price", Convert.ToDecimal(flight.Price));
        await flightCmd.ExecuteNonQueryAsync();
        flightCmd.Cancel();
    }

    public static async IAsyncEnumerable<ClientFlight> Read()
    {
        var readId = new List<string>();
        // using var command = new NpgsqlCommand("SELECT client.*, flightnumber, departureairport, arrivalairport, datedeparture, datearrival, price FROM clients client, flights.public.flights flight WHERE client.userid = flight.flightid", _connection);
        using var command = new NpgsqlCommand("SELECT * FROM clients, flights", _connection);
        await foreach (var result in Reader(command)) yield return result;
    }

    public static async IAsyncEnumerable<ClientFlight> Read(int id)
    {
        using var command = new NpgsqlCommand("", _connection);
        command.Parameters.Add(new NpgsqlParameter("@userID", id));
        command.CommandText =
            "SELECT client.*, flightnumber, departureairport, arrivalairport, datedeparture, datearrival, price FROM clients client, flights flight WHERE client.userid = @userID AND flight.flightid = @userID";
        await command.ExecuteNonQueryAsync();
        await foreach (var result in Reader(command)) yield return result;
    }

    private static async IAsyncEnumerable<ClientFlight> Reader(NpgsqlCommand command)
    {
        var clientFlight = new ClientFlight();
        await using var reader = await command.ExecuteReaderAsync();
        await reader.ReadAsync();
        if (reader.HasRows)
        {
            for (var ordinal = 0; ordinal < reader.FieldCount; ordinal++) 
            {
                switch (reader.GetName(ordinal))
                {
                    case "userid":
                        clientFlight.UserId = reader.GetInt32(ordinal);
                        break;
                    case "username":
                        clientFlight.UserName = reader.GetString(ordinal);
                        break;
                    case "usersurname":
                        clientFlight.UserSurname = reader.GetString(ordinal);
                        break;
                    case "userbirthday":
                        clientFlight.UserBirthDay = reader.GetDateTime(ordinal);
                        break;
                    case "userpassport":
                        clientFlight.UserPassport = reader.GetString(ordinal);
                        break;
                    case "userphone":
                        clientFlight.UserPhone = reader.GetString(ordinal);
                        break;
                    case "flightnumber":
                        clientFlight.FlightNumber = reader.GetString(ordinal);
                        break;
                    case "departureairport":
                        clientFlight.DepartureAirport = reader.GetString(ordinal);
                        break;
                    case "arrivalairport":
                        clientFlight.ArrivalAirport = reader.GetString(ordinal);
                        break;
                    case "datedeparture":
                        clientFlight.DateDeparture = reader.GetDateTime(ordinal);
                        break;
                    case "datearrival":
                        clientFlight.DateArrival = reader.GetDateTime(ordinal);
                        break;
                    case "price":
                        clientFlight.Price = (double) reader.GetDecimal(ordinal);
                        break;
                }
                
                //
                // switch (reader.GetPostgresType(ordinal).ToString())
                // {
                //     case "integer":
                //         readId.Add(Convert.ToString(reader.GetInt32(ordinal)));
                //         break;
                //     case "character":
                //         readId.Add(reader.GetString(ordinal));
                //         break;
                //     case "character varying":
                //         readId.Add(reader.GetString(ordinal));
                //         break;
                //     case "date":
                //         var date = Convert.ToString(reader.GetDateTime(ordinal), CultureInfo.InvariantCulture);
                //         date = date.Split(' ')[0];
                //         readId.Add(date);
                //         break;
                //     case "money":
                //         readId.Add(Convert.ToString(reader.GetDecimal(ordinal), CultureInfo.InvariantCulture));
                //         break;
                // }
                
            }
        }
        else
        {
            _nonExistentEntry = true;
            MessageBox.Show(@"Такой записи не существует.", @"Ошибка");
        }

        command.Cancel();
        await reader.CloseAsync();
        await Task.Delay(500);
        yield return clientFlight;
    }

    public static async void Delete(int id)
    {
        using var command = new NpgsqlCommand("", _connection);
        command.Parameters.Add(new NpgsqlParameter("@ID", id));
        command.CommandText = "SELECT * FROM clients, flights WHERE userid = @ID";
        await command.ExecuteNonQueryAsync();
        await foreach (var result in Reader(command))
        {
        }

        if (_nonExistentEntry)
        {
            MessageBox.Show(@"Ошибка удаления. Вероятнее данной записи не существует.", @"Уведомление");
            _nonExistentEntry = false;
            return;
        }

        command.CommandText = "DELETE FROM clients WHERE userid = @ID";
        await command.ExecuteNonQueryAsync();
        command.CommandText = "DELETE FROM flights WHERE flightid = @ID";
        await command.ExecuteNonQueryAsync();
        command.Cancel();
        MessageBox.Show(@"Удаление записи под уникальным ключом " + id + @" была выполнена успешно.",
            @"Уведомление");
    }

    public static async void Update(int id, Flight flight, Client client)
    {
        using var command = new NpgsqlCommand("", _connection);
        command.Parameters.Add(new NpgsqlParameter("@userName", client.UserName));
        command.Parameters.Add(new NpgsqlParameter("@userSurname", client.UserSurname));
        command.Parameters.Add(new NpgsqlParameter("@userBirthDay", client.UserBirthDay));
        command.Parameters.Add(new NpgsqlParameter("@userPassport", client.UserPassport));
        command.Parameters.Add(new NpgsqlParameter("@userPhone", client.UserPhone));
        command.Parameters.Add(new NpgsqlParameter("@flightNumber", flight.FlightNumber));
        command.Parameters.Add(new NpgsqlParameter("@departureAirport", flight.DepartureAirport));
        command.Parameters.Add(new NpgsqlParameter("@arrivalAirport", flight.ArrivalAirport));
        command.Parameters.Add(new NpgsqlParameter("@departureDate", flight.DateDeparture));
        command.Parameters.Add(new NpgsqlParameter("@arrivalDate", flight.DateArrival));
        command.Parameters.Add(new NpgsqlParameter("@price", Convert.ToDecimal(flight.Price)));
        command.Parameters.Add(new NpgsqlParameter("@id", id));
        command.CommandText = 
            "UPDATE clients SET username = @userName, usersurname = @userSurname, userbirthday = @userBirthday, userpassport = @userPassport, userphone = @userPhone WHERE userid = @id";
        await command.ExecuteNonQueryAsync();
        command.CommandText = 
            "UPDATE flights SET flightnumber = @flightNumber, departureairport = @departureAirport, arrivalairport = @arrivalAirport, datedeparture = @departureDate, datearrival = @arrivalDate, price = @price WHERE flightid = @id";
        await command.ExecuteNonQueryAsync();
        command.Cancel();

        MessageBox.Show(@"Запись успешно обнавлена.", @"Уведомление");
    }
}