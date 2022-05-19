using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DesktopCRUD.MainPrograms;
using DesktopCRUD.Models;
using DesktopCRUD.Properties;

namespace DesktopCRUD.Forms;

public sealed partial class Flights : Form
{
    public Flights()
    {
        InitializeComponent();
        Text = @"CRUD рейсов";
        arrivalDateTime.MinDate = DateTime.Today;
        departureDateTime.MinDate = DateTime.Today;
        birthDayDateUsers.MaxDate = DateTime.Today;
        foreach (var musicName in Music.GetAllMusics())
            if (musicName.Split('\\').Last().Split('.')[1].Equals("mp3"))
                music.Items.Add(musicName.Split('\\').Last().Split('.')[0]);

        music.Text = music.Items[0].ToString();
    }

    private void createButton_Click(object sender, EventArgs e)
    {
        var error = false;
        var flight = new Flight();
        var client = new Client();

        if (!nameTextBox.Text.Equals(""))
            client.UserName = nameTextBox.Text;
        else
            error = true;
        if (!surnameTextBox.Text.Equals(""))
            client.UserSurname = surnameTextBox.Text;
        else
            error = true;
        if (!passportTextBox.Text.Equals(""))
            client.UserPassport = passportTextBox.Text;
        else
            error = true;
        if (!phoneTextBox.Text.Equals(""))
            client.UserPhone = phoneTextBox.Text;
        else
            error = true;
        if (!flightNumberTextBox.Text.Equals(""))
            flight.FlightNumber = flightNumberTextBox.Text;
        else
            error = true;
        if (!departureAirportTextBox.Text.Equals(""))
            flight.DepartureAirport = departureAirportTextBox.Text;
        else
            error = true;
        if (!arrivalAirportTextBox.Text.Equals(""))
            flight.ArrivalAirport = arrivalAirportTextBox.Text;
        else
            error = true;
        if (!priceTextBox.Text.Equals(""))
            flight.Price = Convert.ToDouble(priceTextBox.Text);
        else
            error = true;
        flight.DateDeparture = new DateTime(Convert.ToInt32(departureDateTime.Text.Split('-')[0]),
            Convert.ToInt32(departureDateTime.Text.Split('-')[1]),
            Convert.ToInt32(departureDateTime.Text.Split('-')[2]));
        flight.DateArrival = new DateTime(Convert.ToInt32(arrivalDateTime.Text.Split('-')[0]),
            Convert.ToInt32(arrivalDateTime.Text.Split('-')[1]), Convert.ToInt32(arrivalDateTime.Text.Split('-')[2]));
        client.UserBirthDay = new DateTime(Convert.ToInt32(birthDayDateUsers.Text.Split('-')[0]),
            Convert.ToInt32(birthDayDateUsers.Text.Split('-')[1]),
            Convert.ToInt32(birthDayDateUsers.Text.Split('-')[2]));
        if (!error)
        {
            DataBase.Add(flight, client);
            MessageBox.Show(@"Информация о клиенте и рейсе была успесшно добавлена.", @"Уведомление");
            ClearingFields();
        }
        else
        {
            MessageBox.Show(@"Заполните все поля!", @"Ошибка");
        }
    }

    private async void readFromID_Click(object sender, EventArgs e)
    {
        var asyncEnumerable = DataBase.Read(Convert.ToInt32(readIDTextBox.Text));
        await foreach (var clientFlight in asyncEnumerable)
            flightsDataGridView.Rows.Add(clientFlight.UserId, clientFlight.UserName, clientFlight.UserSurname,
                clientFlight.UserBirthDay, clientFlight.UserPassport, clientFlight.UserPhone, clientFlight.FlightNumber,
                clientFlight.DepartureAirport, clientFlight.ArrivalAirport, clientFlight.DateDeparture,
                clientFlight.DateArrival, clientFlight.Price);
    }

    private void fullClearButton_Click(object sender, EventArgs e)
    {
        flightsDataGridView.Rows.Clear();
        flightsDataGridView.Refresh();
    }

    private async void readAllData_Click(object sender, EventArgs e)
    {
        // var asyncEnumerable = DataBase.Read();
        // await foreach (var info in asyncEnumerable)
        // {
        //     //FlightsDataGridView.Rows.Add(info[0], info[1], info[2], info[3], info[4], info[5], info[6], info[7], info[8], info[9], info[10], info[11]);
        // }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        if (!deleteTextBox.Text.Equals(""))
            DataBase.Delete(Convert.ToInt32(deleteTextBox.Text));
    }

    private async void updateIDButton_Click(object sender, EventArgs e)
    {
        if (updateTextBox.Text.Equals("")) return;
        var asyncEnumerable = DataBase.Read(Convert.ToInt32(updateTextBox.Text));
        await foreach (var clientFlight in asyncEnumerable)
        {
            nameUpdateTextBox.Text = clientFlight.UserName;
            surnameUpdateTextBox.Text = clientFlight.UserSurname;
            birthDayUpdateDateTime.Value = clientFlight.UserBirthDay;
            passportUpdateTextBox.Text = clientFlight.UserPassport;
            phoneUpdateTextBox.Text = clientFlight.UserPhone;
            flightNumberUpdateTextBox.Text = clientFlight.FlightNumber;
            departureAirportUpdateTextBox.Text = clientFlight.DepartureAirport;
            arrivalAirportUpdateTextBox.Text = clientFlight.ArrivalAirport;
            departureUpdateDateTime.Value = clientFlight.DateDeparture;
            arrivalUpdateDateTime.Value = clientFlight.DateArrival;
            priceUpdateTextBox.Text = clientFlight.Price.ToString(CultureInfo.InvariantCulture);
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (updateTextBox.Text.Equals("")) return;
        var client = new Client();
        var flight = new Flight();
        client.UserName = nameUpdateTextBox.Text;
        client.UserSurname = surnameUpdateTextBox.Text;
        client.UserBirthDay = birthDayUpdateDateTime.Value;
        client.UserPassport = passportUpdateTextBox.Text;
        client.UserPhone = phoneUpdateTextBox.Text;
        flight.FlightNumber = flightNumberUpdateTextBox.Text;
        flight.DepartureAirport = departureAirportUpdateTextBox.Text;
        flight.ArrivalAirport = arrivalAirportUpdateTextBox.Text;
        flight.DateDeparture = departureUpdateDateTime.Value;
        flight.DateArrival = arrivalUpdateDateTime.Value;
        flight.Price = Convert.ToDouble(priceUpdateTextBox.Text);
        DataBase.Update(Convert.ToInt32(updateTextBox.Text), flight, client);
        ClearingFields();
        updateTextBox.Text = "";
    }

    private void play_pause_Click(object sender, EventArgs e)
    {
        if (Music.MusicPlayerStatus)
        {
            play_pause.Image = Resources.play;
            Music.MusicPlayerStatus = false;
            Music.Pause();
        }
        else
        {
            play_pause.Image = Resources.pause;
            Music.MusicPlayerStatus = true;
            Music.Play();
        }
    }

    private void volume_Scroll(object sender, EventArgs e)
    {
        volumeLabel.Text = @"Громкость: " + volume.Value;
        Music.Volume(volume.Value);
    }

    private void previous_Click(object sender, EventArgs e)
    {
        if (music.SelectedIndex <= music.Items.Count - 1 && music.SelectedIndex != 0)
            music.SelectedIndex--;
    }

    private void next_Click(object sender, EventArgs e)
    {
        if (music.SelectedIndex < music.Items.Count - 1)
            music.SelectedIndex++;
    }

    private void music_SelectedIndexChanged(object sender, EventArgs e)
    {
        Music.Play(music.SelectedItem + ".mp3");
    }

    private void ClearingFields()
    {
        nameUpdateTextBox.Text = "";
        surnameUpdateTextBox.Text = "";
        birthDayUpdateDateTime.Value = DateTime.Today;
        passportUpdateTextBox.Text = "";
        phoneUpdateTextBox.Text = "";
        flightNumberUpdateTextBox.Text = "";
        departureAirportUpdateTextBox.Text = "";
        arrivalAirportUpdateTextBox.Text = "";
        departureUpdateDateTime.Value = DateTime.Today;
        arrivalUpdateDateTime.Value = DateTime.Today;
        priceUpdateTextBox.Text = "";
    }
}