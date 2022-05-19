using System.Windows.Forms;
using DesktopCRUD.MainPrograms;

namespace DesktopCRUD.Forms
{
    sealed partial class Flights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                DataBase.CloseConnection();
                components.Dispose();
            }
            
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRUDTabControl = new System.Windows.Forms.TabControl();
            this.createTabPage = new System.Windows.Forms.TabPage();
            this.createButton = new System.Windows.Forms.Button();
            this.clientInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.birthDayDateUsers = new System.Windows.Forms.DateTimePicker();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.borthDayLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passportLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.flightInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.arrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.departureDateTime = new System.Windows.Forms.DateTimePicker();
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.departureAirportTextBox = new System.Windows.Forms.TextBox();
            this.dateArrivalLabel = new System.Windows.Forms.Label();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            this.dateDepartureLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.departureAirportLabel = new System.Windows.Forms.Label();
            this.arrivalAirportLabel = new System.Windows.Forms.Label();
            this.arrivalAirportTextBox = new System.Windows.Forms.TextBox();
            this.readTabPage = new System.Windows.Forms.TabPage();
            this.fullClearButton = new System.Windows.Forms.Button();
            this.readIDTextBox = new System.Windows.Forms.TextBox();
            this.readIDlabel = new System.Windows.Forms.Label();
            this.readFromID = new System.Windows.Forms.Button();
            this.readAllData = new System.Windows.Forms.Button();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepatrureAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.updateButton = new System.Windows.Forms.Button();
            this.clientUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.birthDayUpdateDateTime = new System.Windows.Forms.DateTimePicker();
            this.passportUpdateTextBox = new System.Windows.Forms.TextBox();
            this.phoneUpdateTextBox = new System.Windows.Forms.TextBox();
            this.surnameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.nameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flightUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.arrivalUpdateDateTime = new System.Windows.Forms.DateTimePicker();
            this.departureUpdateDateTime = new System.Windows.Forms.DateTimePicker();
            this.priceUpdateTextBox = new System.Windows.Forms.TextBox();
            this.priceUpdateLabel = new System.Windows.Forms.Label();
            this.arrivalAirportUpdateLabel = new System.Windows.Forms.Label();
            this.departureAirportUpdateTextBox = new System.Windows.Forms.TextBox();
            this.arrivalAirportUpdateTextBox = new System.Windows.Forms.TextBox();
            this.departureDateUpdateLabel = new System.Windows.Forms.Label();
            this.flightNumberUpdateTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateUpdateLabel = new System.Windows.Forms.Label();
            this.departureAirportUpdateLabel = new System.Windows.Forms.Label();
            this.flightNumberUpdateLabel = new System.Windows.Forms.Label();
            this.updateIDButton = new System.Windows.Forms.Button();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.updateLabel = new System.Windows.Forms.Label();
            this.deleteTabPage = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.musicTabPage = new System.Windows.Forms.TabPage();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TrackBar();
            this.next = new System.Windows.Forms.Button();
            this.play_pause = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.music = new System.Windows.Forms.ComboBox();
            this.CRUDTabControl.SuspendLayout();
            this.createTabPage.SuspendLayout();
            this.clientInformationGroupBox.SuspendLayout();
            this.flightInformationGroupBox.SuspendLayout();
            this.readTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.flightsDataGridView)).BeginInit();
            this.updateTabPage.SuspendLayout();
            this.clientUpdateGroupBox.SuspendLayout();
            this.flightUpdateGroupBox.SuspendLayout();
            this.deleteTabPage.SuspendLayout();
            this.musicTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.volume)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUDTabControl
            // 
            this.CRUDTabControl.Controls.Add(this.createTabPage);
            this.CRUDTabControl.Controls.Add(this.readTabPage);
            this.CRUDTabControl.Controls.Add(this.updateTabPage);
            this.CRUDTabControl.Controls.Add(this.deleteTabPage);
            this.CRUDTabControl.Controls.Add(this.musicTabPage);
            this.CRUDTabControl.Location = new System.Drawing.Point(12, 12);
            this.CRUDTabControl.Name = "CRUDTabControl";
            this.CRUDTabControl.SelectedIndex = 0;
            this.CRUDTabControl.Size = new System.Drawing.Size(800, 489);
            this.CRUDTabControl.TabIndex = 0;
            // 
            // createTabPage
            // 
            this.createTabPage.Controls.Add(this.createButton);
            this.createTabPage.Controls.Add(this.clientInformationGroupBox);
            this.createTabPage.Controls.Add(this.flightInformationGroupBox);
            this.createTabPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.createTabPage.Location = new System.Drawing.Point(4, 22);
            this.createTabPage.Name = "createTabPage";
            this.createTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createTabPage.Size = new System.Drawing.Size(792, 463);
            this.createTabPage.TabIndex = 0;
            this.createTabPage.Text = "Создать";
            this.createTabPage.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(639, 226);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(145, 32);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Добавить рейс";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clientInformationGroupBox
            // 
            this.clientInformationGroupBox.Controls.Add(this.birthDayDateUsers);
            this.clientInformationGroupBox.Controls.Add(this.passportTextBox);
            this.clientInformationGroupBox.Controls.Add(this.phoneTextBox);
            this.clientInformationGroupBox.Controls.Add(this.surnameTextBox);
            this.clientInformationGroupBox.Controls.Add(this.nameTextBox);
            this.clientInformationGroupBox.Controls.Add(this.borthDayLabel);
            this.clientInformationGroupBox.Controls.Add(this.phoneLabel);
            this.clientInformationGroupBox.Controls.Add(this.passportLabel);
            this.clientInformationGroupBox.Controls.Add(this.surnameLabel);
            this.clientInformationGroupBox.Controls.Add(this.nameLabel);
            this.clientInformationGroupBox.Location = new System.Drawing.Point(401, 6);
            this.clientInformationGroupBox.Name = "clientInformationGroupBox";
            this.clientInformationGroupBox.Size = new System.Drawing.Size(383, 214);
            this.clientInformationGroupBox.TabIndex = 14;
            this.clientInformationGroupBox.TabStop = false;
            // 
            // birthDayDateUsers
            // 
            this.birthDayDateUsers.CustomFormat = "yyyy-MM-dd";
            this.birthDayDateUsers.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDayDateUsers.Location = new System.Drawing.Point(6, 168);
            this.birthDayDateUsers.Name = "birthDayDateUsers";
            this.birthDayDateUsers.Size = new System.Drawing.Size(134, 29);
            this.birthDayDateUsers.TabIndex = 10;
            // 
            // passportTextBox
            // 
            this.passportTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.passportTextBox.Location = new System.Drawing.Point(197, 112);
            this.passportTextBox.MaxLength = 15;
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(175, 29);
            this.passportTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.phoneTextBox.Location = new System.Drawing.Point(197, 54);
            this.phoneTextBox.MaxLength = 20;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(175, 29);
            this.phoneTextBox.TabIndex = 8;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.surnameTextBox.Location = new System.Drawing.Point(6, 112);
            this.surnameTextBox.MaxLength = 50;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(175, 29);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Location = new System.Drawing.Point(6, 54);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 29);
            this.nameTextBox.TabIndex = 5;
            // 
            // borthDayLabel
            // 
            this.borthDayLabel.Location = new System.Drawing.Point(6, 144);
            this.borthDayLabel.Name = "borthDayLabel";
            this.borthDayLabel.Size = new System.Drawing.Size(138, 23);
            this.borthDayLabel.TabIndex = 4;
            this.borthDayLabel.Text = "Дата рождения";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(197, 27);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(151, 23);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Номер телефона";
            // 
            // passportLabel
            // 
            this.passportLabel.Location = new System.Drawing.Point(197, 86);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(151, 23);
            this.passportLabel.TabIndex = 2;
            this.passportLabel.Text = "Пасспорт";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Location = new System.Drawing.Point(6, 86);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(100, 23);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(6, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            // 
            // flightInformationGroupBox
            // 
            this.flightInformationGroupBox.Controls.Add(this.arrivalDateTime);
            this.flightInformationGroupBox.Controls.Add(this.departureDateTime);
            this.flightInformationGroupBox.Controls.Add(this.flightNumberTextBox);
            this.flightInformationGroupBox.Controls.Add(this.priceLabel);
            this.flightInformationGroupBox.Controls.Add(this.departureAirportTextBox);
            this.flightInformationGroupBox.Controls.Add(this.dateArrivalLabel);
            this.flightInformationGroupBox.Controls.Add(this.flightNumberLabel);
            this.flightInformationGroupBox.Controls.Add(this.dateDepartureLabel);
            this.flightInformationGroupBox.Controls.Add(this.priceTextBox);
            this.flightInformationGroupBox.Controls.Add(this.departureAirportLabel);
            this.flightInformationGroupBox.Controls.Add(this.arrivalAirportLabel);
            this.flightInformationGroupBox.Controls.Add(this.arrivalAirportTextBox);
            this.flightInformationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.flightInformationGroupBox.Name = "flightInformationGroupBox";
            this.flightInformationGroupBox.Size = new System.Drawing.Size(389, 214);
            this.flightInformationGroupBox.TabIndex = 13;
            this.flightInformationGroupBox.TabStop = false;
            // 
            // arrivalDateTime
            // 
            this.arrivalDateTime.CustomFormat = "yyyy-MM-dd";
            this.arrivalDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalDateTime.Location = new System.Drawing.Point(201, 112);
            this.arrivalDateTime.Name = "arrivalDateTime";
            this.arrivalDateTime.Size = new System.Drawing.Size(134, 29);
            this.arrivalDateTime.TabIndex = 16;
            // 
            // departureDateTime
            // 
            this.departureDateTime.CustomFormat = "yyyy-MM-dd";
            this.departureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureDateTime.Location = new System.Drawing.Point(201, 54);
            this.departureDateTime.Name = "departureDateTime";
            this.departureDateTime.Size = new System.Drawing.Size(134, 29);
            this.departureDateTime.TabIndex = 16;
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.flightNumberTextBox.Location = new System.Drawing.Point(9, 54);
            this.flightNumberTextBox.MaxLength = 6;
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(175, 29);
            this.flightNumberTextBox.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(200, 144);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 23);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Цена";
            // 
            // departureAirportTextBox
            // 
            this.departureAirportTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.departureAirportTextBox.Location = new System.Drawing.Point(9, 112);
            this.departureAirportTextBox.MaxLength = 50;
            this.departureAirportTextBox.Name = "departureAirportTextBox";
            this.departureAirportTextBox.Size = new System.Drawing.Size(175, 29);
            this.departureAirportTextBox.TabIndex = 12;
            // 
            // dateArrivalLabel
            // 
            this.dateArrivalLabel.Location = new System.Drawing.Point(200, 86);
            this.dateArrivalLabel.Name = "dateArrivalLabel";
            this.dateArrivalLabel.Size = new System.Drawing.Size(135, 23);
            this.dateArrivalLabel.TabIndex = 10;
            this.dateArrivalLabel.Text = "Дата прилета";
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.flightNumberLabel.Location = new System.Drawing.Point(9, 27);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(117, 24);
            this.flightNumberLabel.TabIndex = 1;
            this.flightNumberLabel.Text = "Номер рейса";
            // 
            // dateDepartureLabel
            // 
            this.dateDepartureLabel.Location = new System.Drawing.Point(200, 27);
            this.dateDepartureLabel.Name = "dateDepartureLabel";
            this.dateDepartureLabel.Size = new System.Drawing.Size(135, 23);
            this.dateDepartureLabel.TabIndex = 9;
            this.dateDepartureLabel.Text = "Дата вылета";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(200, 171);
            this.priceTextBox.MaxLength = 10;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(175, 29);
            this.priceTextBox.TabIndex = 6;
            // 
            // departureAirportLabel
            // 
            this.departureAirportLabel.Location = new System.Drawing.Point(9, 86);
            this.departureAirportLabel.Name = "departureAirportLabel";
            this.departureAirportLabel.Size = new System.Drawing.Size(157, 24);
            this.departureAirportLabel.TabIndex = 7;
            this.departureAirportLabel.Text = "Аэропорт вылета";
            // 
            // arrivalAirportLabel
            // 
            this.arrivalAirportLabel.Location = new System.Drawing.Point(6, 144);
            this.arrivalAirportLabel.Name = "arrivalAirportLabel";
            this.arrivalAirportLabel.Size = new System.Drawing.Size(181, 23);
            this.arrivalAirportLabel.TabIndex = 8;
            this.arrivalAirportLabel.Text = "Аэропорт прилета";
            // 
            // arrivalAirportTextBox
            // 
            this.arrivalAirportTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.arrivalAirportTextBox.Location = new System.Drawing.Point(9, 171);
            this.arrivalAirportTextBox.MaxLength = 50;
            this.arrivalAirportTextBox.Name = "arrivalAirportTextBox";
            this.arrivalAirportTextBox.Size = new System.Drawing.Size(175, 29);
            this.arrivalAirportTextBox.TabIndex = 2;
            // 
            // readTabPage
            // 
            this.readTabPage.Controls.Add(this.fullClearButton);
            this.readTabPage.Controls.Add(this.readIDTextBox);
            this.readTabPage.Controls.Add(this.readIDlabel);
            this.readTabPage.Controls.Add(this.readFromID);
            this.readTabPage.Controls.Add(this.readAllData);
            this.readTabPage.Controls.Add(this.flightsDataGridView);
            this.readTabPage.Location = new System.Drawing.Point(4, 22);
            this.readTabPage.Name = "readTabPage";
            this.readTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.readTabPage.Size = new System.Drawing.Size(792, 463);
            this.readTabPage.TabIndex = 1;
            this.readTabPage.Text = "Вывести";
            this.readTabPage.UseVisualStyleBackColor = true;
            // 
            // fullClearButton
            // 
            this.fullClearButton.Location = new System.Drawing.Point(686, 418);
            this.fullClearButton.Name = "fullClearButton";
            this.fullClearButton.Size = new System.Drawing.Size(100, 39);
            this.fullClearButton.TabIndex = 5;
            this.fullClearButton.Text = "Очистить таблицу";
            this.fullClearButton.UseVisualStyleBackColor = true;
            this.fullClearButton.Click += new System.EventHandler(this.fullClearButton_Click);
            // 
            // readIDTextBox
            // 
            this.readIDTextBox.Location = new System.Drawing.Point(82, 428);
            this.readIDTextBox.Name = "readIDTextBox";
            this.readIDTextBox.Size = new System.Drawing.Size(79, 20);
            this.readIDTextBox.TabIndex = 4;
            // 
            // readIDlabel
            // 
            this.readIDlabel.Location = new System.Drawing.Point(6, 431);
            this.readIDlabel.Name = "readIDlabel";
            this.readIDlabel.Size = new System.Drawing.Size(70, 23);
            this.readIDlabel.TabIndex = 3;
            this.readIDlabel.Text = "Введите ID:";
            // 
            // readFromID
            // 
            this.readFromID.Location = new System.Drawing.Point(167, 418);
            this.readFromID.Name = "readFromID";
            this.readFromID.Size = new System.Drawing.Size(100, 39);
            this.readFromID.TabIndex = 2;
            this.readFromID.Text = "Вывести отдельный ID";
            this.readFromID.UseVisualStyleBackColor = true;
            this.readFromID.Click += new System.EventHandler(this.readFromID_Click);
            // 
            // readAllData
            // 
            this.readAllData.Location = new System.Drawing.Point(521, 418);
            this.readAllData.Name = "readAllData";
            this.readAllData.Size = new System.Drawing.Size(103, 39);
            this.readAllData.TabIndex = 1;
            this.readAllData.Text = "Показать всю базу";
            this.readAllData.UseVisualStyleBackColor = true;
            this.readAllData.Click += new System.EventHandler(this.readAllData_Click);
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ID, this.UserName, this.UserSurname, this.BirthDay, this.Passport, this.Phone, this.FlightNumber, this.DepatrureAirport, this.ArrivalAirport, this.DateDeparture, this.DateArrival, this.Price});
            this.flightsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.Size = new System.Drawing.Size(780, 406);
            this.flightsDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserSurname
            // 
            this.UserSurname.HeaderText = "Фамилия";
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.ReadOnly = true;
            // 
            // BirthDay
            // 
            this.BirthDay.HeaderText = "Дата рождения";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // Passport
            // 
            this.Passport.HeaderText = "Номер паспорта";
            this.Passport.Name = "Passport";
            this.Passport.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Номер телефона";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // FlightNumber
            // 
            this.FlightNumber.HeaderText = "Номер рейса";
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.ReadOnly = true;
            // 
            // DepatrureAirport
            // 
            this.DepatrureAirport.HeaderText = "Аэропотр вылета";
            this.DepatrureAirport.Name = "DepatrureAirport";
            this.DepatrureAirport.ReadOnly = true;
            // 
            // ArrivalAirport
            // 
            this.ArrivalAirport.HeaderText = "Аэропорт прибытия";
            this.ArrivalAirport.Name = "ArrivalAirport";
            this.ArrivalAirport.ReadOnly = true;
            // 
            // DateDeparture
            // 
            this.DateDeparture.HeaderText = "Дата вылета";
            this.DateDeparture.Name = "DateDeparture";
            this.DateDeparture.ReadOnly = true;
            // 
            // DateArrival
            // 
            this.DateArrival.HeaderText = "Дата прилета";
            this.DateArrival.Name = "DateArrival";
            this.DateArrival.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Controls.Add(this.updateButton);
            this.updateTabPage.Controls.Add(this.clientUpdateGroupBox);
            this.updateTabPage.Controls.Add(this.flightUpdateGroupBox);
            this.updateTabPage.Controls.Add(this.updateIDButton);
            this.updateTabPage.Controls.Add(this.updateTextBox);
            this.updateTabPage.Controls.Add(this.updateLabel);
            this.updateTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateTabPage.Size = new System.Drawing.Size(792, 463);
            this.updateTabPage.TabIndex = 2;
            this.updateTabPage.Text = "Обновить";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(636, 286);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 49);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Обновить запись";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clientUpdateGroupBox
            // 
            this.clientUpdateGroupBox.Controls.Add(this.birthDayUpdateDateTime);
            this.clientUpdateGroupBox.Controls.Add(this.passportUpdateTextBox);
            this.clientUpdateGroupBox.Controls.Add(this.phoneUpdateTextBox);
            this.clientUpdateGroupBox.Controls.Add(this.surnameUpdateTextBox);
            this.clientUpdateGroupBox.Controls.Add(this.nameUpdateTextBox);
            this.clientUpdateGroupBox.Controls.Add(this.label5);
            this.clientUpdateGroupBox.Controls.Add(this.label4);
            this.clientUpdateGroupBox.Controls.Add(this.label3);
            this.clientUpdateGroupBox.Controls.Add(this.label2);
            this.clientUpdateGroupBox.Controls.Add(this.label1);
            this.clientUpdateGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.clientUpdateGroupBox.Location = new System.Drawing.Point(355, 51);
            this.clientUpdateGroupBox.Name = "clientUpdateGroupBox";
            this.clientUpdateGroupBox.Size = new System.Drawing.Size(385, 229);
            this.clientUpdateGroupBox.TabIndex = 4;
            this.clientUpdateGroupBox.TabStop = false;
            this.clientUpdateGroupBox.Text = "Информация о клиенте";
            // 
            // birthDayUpdateDateTime
            // 
            this.birthDayUpdateDateTime.CustomFormat = "yyyy-MM-dd";
            this.birthDayUpdateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDayUpdateDateTime.Location = new System.Drawing.Point(6, 170);
            this.birthDayUpdateDateTime.Name = "birthDayUpdateDateTime";
            this.birthDayUpdateDateTime.Size = new System.Drawing.Size(122, 29);
            this.birthDayUpdateDateTime.TabIndex = 9;
            // 
            // passportUpdateTextBox
            // 
            this.passportUpdateTextBox.Location = new System.Drawing.Point(194, 112);
            this.passportUpdateTextBox.Name = "passportUpdateTextBox";
            this.passportUpdateTextBox.Size = new System.Drawing.Size(168, 29);
            this.passportUpdateTextBox.TabIndex = 8;
            // 
            // phoneUpdateTextBox
            // 
            this.phoneUpdateTextBox.Location = new System.Drawing.Point(194, 54);
            this.phoneUpdateTextBox.Name = "phoneUpdateTextBox";
            this.phoneUpdateTextBox.Size = new System.Drawing.Size(168, 29);
            this.phoneUpdateTextBox.TabIndex = 7;
            // 
            // surnameUpdateTextBox
            // 
            this.surnameUpdateTextBox.Location = new System.Drawing.Point(6, 112);
            this.surnameUpdateTextBox.Name = "surnameUpdateTextBox";
            this.surnameUpdateTextBox.Size = new System.Drawing.Size(156, 29);
            this.surnameUpdateTextBox.TabIndex = 6;
            // 
            // nameUpdateTextBox
            // 
            this.nameUpdateTextBox.Location = new System.Drawing.Point(6, 54);
            this.nameUpdateTextBox.Name = "nameUpdateTextBox";
            this.nameUpdateTextBox.Size = new System.Drawing.Size(156, 29);
            this.nameUpdateTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(194, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пасспорт";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(194, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // flightUpdateGroupBox
            // 
            this.flightUpdateGroupBox.Controls.Add(this.arrivalUpdateDateTime);
            this.flightUpdateGroupBox.Controls.Add(this.departureUpdateDateTime);
            this.flightUpdateGroupBox.Controls.Add(this.priceUpdateTextBox);
            this.flightUpdateGroupBox.Controls.Add(this.priceUpdateLabel);
            this.flightUpdateGroupBox.Controls.Add(this.arrivalAirportUpdateLabel);
            this.flightUpdateGroupBox.Controls.Add(this.departureAirportUpdateTextBox);
            this.flightUpdateGroupBox.Controls.Add(this.arrivalAirportUpdateTextBox);
            this.flightUpdateGroupBox.Controls.Add(this.departureDateUpdateLabel);
            this.flightUpdateGroupBox.Controls.Add(this.flightNumberUpdateTextBox);
            this.flightUpdateGroupBox.Controls.Add(this.arrivalDateUpdateLabel);
            this.flightUpdateGroupBox.Controls.Add(this.departureAirportUpdateLabel);
            this.flightUpdateGroupBox.Controls.Add(this.flightNumberUpdateLabel);
            this.flightUpdateGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.flightUpdateGroupBox.Location = new System.Drawing.Point(6, 51);
            this.flightUpdateGroupBox.Name = "flightUpdateGroupBox";
            this.flightUpdateGroupBox.Size = new System.Drawing.Size(343, 229);
            this.flightUpdateGroupBox.TabIndex = 3;
            this.flightUpdateGroupBox.TabStop = false;
            this.flightUpdateGroupBox.Text = "Информация о рейсе";
            // 
            // arrivalUpdateDateTime
            // 
            this.arrivalUpdateDateTime.CustomFormat = "yyyy-MM-dd";
            this.arrivalUpdateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalUpdateDateTime.Location = new System.Drawing.Point(176, 112);
            this.arrivalUpdateDateTime.Name = "arrivalUpdateDateTime";
            this.arrivalUpdateDateTime.Size = new System.Drawing.Size(122, 29);
            this.arrivalUpdateDateTime.TabIndex = 11;
            // 
            // departureUpdateDateTime
            // 
            this.departureUpdateDateTime.CustomFormat = "yyyy-MM-dd";
            this.departureUpdateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureUpdateDateTime.Location = new System.Drawing.Point(176, 54);
            this.departureUpdateDateTime.Name = "departureUpdateDateTime";
            this.departureUpdateDateTime.Size = new System.Drawing.Size(122, 29);
            this.departureUpdateDateTime.TabIndex = 10;
            // 
            // priceUpdateTextBox
            // 
            this.priceUpdateTextBox.Location = new System.Drawing.Point(176, 170);
            this.priceUpdateTextBox.Name = "priceUpdateTextBox";
            this.priceUpdateTextBox.Size = new System.Drawing.Size(149, 29);
            this.priceUpdateTextBox.TabIndex = 9;
            // 
            // priceUpdateLabel
            // 
            this.priceUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.priceUpdateLabel.Location = new System.Drawing.Point(176, 144);
            this.priceUpdateLabel.Name = "priceUpdateLabel";
            this.priceUpdateLabel.Size = new System.Drawing.Size(58, 23);
            this.priceUpdateLabel.TabIndex = 5;
            this.priceUpdateLabel.Text = "Цена";
            // 
            // arrivalAirportUpdateLabel
            // 
            this.arrivalAirportUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.arrivalAirportUpdateLabel.Location = new System.Drawing.Point(6, 144);
            this.arrivalAirportUpdateLabel.Name = "arrivalAirportUpdateLabel";
            this.arrivalAirportUpdateLabel.Size = new System.Drawing.Size(161, 23);
            this.arrivalAirportUpdateLabel.TabIndex = 2;
            this.arrivalAirportUpdateLabel.Text = "Аэропорт прилета";
            // 
            // departureAirportUpdateTextBox
            // 
            this.departureAirportUpdateTextBox.Location = new System.Drawing.Point(6, 112);
            this.departureAirportUpdateTextBox.Name = "departureAirportUpdateTextBox";
            this.departureAirportUpdateTextBox.Size = new System.Drawing.Size(149, 29);
            this.departureAirportUpdateTextBox.TabIndex = 8;
            // 
            // arrivalAirportUpdateTextBox
            // 
            this.arrivalAirportUpdateTextBox.Location = new System.Drawing.Point(6, 170);
            this.arrivalAirportUpdateTextBox.Name = "arrivalAirportUpdateTextBox";
            this.arrivalAirportUpdateTextBox.Size = new System.Drawing.Size(149, 29);
            this.arrivalAirportUpdateTextBox.TabIndex = 7;
            // 
            // departureDateUpdateLabel
            // 
            this.departureDateUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.departureDateUpdateLabel.Location = new System.Drawing.Point(176, 28);
            this.departureDateUpdateLabel.Name = "departureDateUpdateLabel";
            this.departureDateUpdateLabel.Size = new System.Drawing.Size(114, 23);
            this.departureDateUpdateLabel.TabIndex = 3;
            this.departureDateUpdateLabel.Text = "Дата вылета";
            // 
            // flightNumberUpdateTextBox
            // 
            this.flightNumberUpdateTextBox.Location = new System.Drawing.Point(6, 54);
            this.flightNumberUpdateTextBox.Name = "flightNumberUpdateTextBox";
            this.flightNumberUpdateTextBox.Size = new System.Drawing.Size(149, 29);
            this.flightNumberUpdateTextBox.TabIndex = 6;
            // 
            // arrivalDateUpdateLabel
            // 
            this.arrivalDateUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.arrivalDateUpdateLabel.Location = new System.Drawing.Point(176, 86);
            this.arrivalDateUpdateLabel.Name = "arrivalDateUpdateLabel";
            this.arrivalDateUpdateLabel.Size = new System.Drawing.Size(122, 23);
            this.arrivalDateUpdateLabel.TabIndex = 4;
            this.arrivalDateUpdateLabel.Text = "Дата прилета";
            // 
            // departureAirportUpdateLabel
            // 
            this.departureAirportUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.departureAirportUpdateLabel.Location = new System.Drawing.Point(6, 86);
            this.departureAirportUpdateLabel.Name = "departureAirportUpdateLabel";
            this.departureAirportUpdateLabel.Size = new System.Drawing.Size(149, 23);
            this.departureAirportUpdateLabel.TabIndex = 1;
            this.departureAirportUpdateLabel.Text = "Аэропорт вылета";
            // 
            // flightNumberUpdateLabel
            // 
            this.flightNumberUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.flightNumberUpdateLabel.Location = new System.Drawing.Point(6, 28);
            this.flightNumberUpdateLabel.Name = "flightNumberUpdateLabel";
            this.flightNumberUpdateLabel.Size = new System.Drawing.Size(114, 23);
            this.flightNumberUpdateLabel.TabIndex = 0;
            this.flightNumberUpdateLabel.Text = "Номер рейса";
            // 
            // updateIDButton
            // 
            this.updateIDButton.Location = new System.Drawing.Point(512, 6);
            this.updateIDButton.Name = "updateIDButton";
            this.updateIDButton.Size = new System.Drawing.Size(100, 39);
            this.updateIDButton.TabIndex = 2;
            this.updateIDButton.Text = "Выбрать ID";
            this.updateIDButton.UseVisualStyleBackColor = true;
            this.updateIDButton.Click += new System.EventHandler(this.updateIDButton_Click);
            // 
            // updateTextBox
            // 
            this.updateTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.updateTextBox.Location = new System.Drawing.Point(388, 9);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(118, 29);
            this.updateTextBox.TabIndex = 1;
            // 
            // updateLabel
            // 
            this.updateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.updateLabel.Location = new System.Drawing.Point(3, 12);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(379, 26);
            this.updateLabel.TabIndex = 0;
            this.updateLabel.Text = "Введите ID для внесения изменений в запись:";
            // 
            // deleteTabPage
            // 
            this.deleteTabPage.Controls.Add(this.deleteButton);
            this.deleteTabPage.Controls.Add(this.deleteLabel);
            this.deleteTabPage.Controls.Add(this.deleteTextBox);
            this.deleteTabPage.Location = new System.Drawing.Point(4, 22);
            this.deleteTabPage.Name = "deleteTabPage";
            this.deleteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTabPage.Size = new System.Drawing.Size(792, 463);
            this.deleteTabPage.TabIndex = 3;
            this.deleteTabPage.Text = "Удалить";
            this.deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(507, 23);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 39);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.deleteLabel.Location = new System.Drawing.Point(6, 15);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(300, 51);
            this.deleteLabel.TabIndex = 1;
            this.deleteLabel.Text = "Введите ID рейса для дальнейшего\r\nудаления записи из базы данных:";
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.deleteTextBox.Location = new System.Drawing.Point(312, 28);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(189, 29);
            this.deleteTextBox.TabIndex = 0;
            // 
            // musicTabPage
            // 
            this.musicTabPage.Controls.Add(this.volumeLabel);
            this.musicTabPage.Controls.Add(this.volume);
            this.musicTabPage.Controls.Add(this.next);
            this.musicTabPage.Controls.Add(this.play_pause);
            this.musicTabPage.Controls.Add(this.previous);
            this.musicTabPage.Controls.Add(this.music);
            this.musicTabPage.Location = new System.Drawing.Point(4, 22);
            this.musicTabPage.Name = "musicTabPage";
            this.musicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.musicTabPage.Size = new System.Drawing.Size(792, 463);
            this.musicTabPage.TabIndex = 4;
            this.musicTabPage.Text = "Музыка";
            this.musicTabPage.UseVisualStyleBackColor = true;
            // 
            // volumeLabel
            // 
            this.volumeLabel.Location = new System.Drawing.Point(6, 93);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(100, 23);
            this.volumeLabel.TabIndex = 6;
            this.volumeLabel.Text = "Громкость: 25";
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(6, 45);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(295, 45);
            this.volume.TabIndex = 5;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume.Value = 25;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // next
            // 
            this.next.Image = global::DesktopCRUD.Properties.Resources.next;
            this.next.Location = new System.Drawing.Point(273, 6);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 33);
            this.next.TabIndex = 4;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // play_pause
            // 
            this.play_pause.Image = global::DesktopCRUD.Properties.Resources.pause;
            this.play_pause.Location = new System.Drawing.Point(239, 6);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(28, 33);
            this.play_pause.TabIndex = 3;
            this.play_pause.UseVisualStyleBackColor = true;
            this.play_pause.Click += new System.EventHandler(this.play_pause_Click);
            // 
            // previous
            // 
            this.previous.Image = global::DesktopCRUD.Properties.Resources.previous;
            this.previous.Location = new System.Drawing.Point(205, 6);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(28, 33);
            this.previous.TabIndex = 2;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // music
            // 
            this.music.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music.FormattingEnabled = true;
            this.music.Location = new System.Drawing.Point(6, 13);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(193, 21);
            this.music.TabIndex = 0;
            this.music.SelectedIndexChanged += new System.EventHandler(this.music_SelectedIndexChanged);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(819, 513);
            this.Controls.Add(this.CRUDTabControl);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Flights";
            this.CRUDTabControl.ResumeLayout(false);
            this.createTabPage.ResumeLayout(false);
            this.clientInformationGroupBox.ResumeLayout(false);
            this.clientInformationGroupBox.PerformLayout();
            this.flightInformationGroupBox.ResumeLayout(false);
            this.flightInformationGroupBox.PerformLayout();
            this.readTabPage.ResumeLayout(false);
            this.readTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.flightsDataGridView)).EndInit();
            this.updateTabPage.ResumeLayout(false);
            this.updateTabPage.PerformLayout();
            this.clientUpdateGroupBox.ResumeLayout(false);
            this.clientUpdateGroupBox.PerformLayout();
            this.flightUpdateGroupBox.ResumeLayout(false);
            this.flightUpdateGroupBox.PerformLayout();
            this.deleteTabPage.ResumeLayout(false);
            this.deleteTabPage.PerformLayout();
            this.musicTabPage.ResumeLayout(false);
            this.musicTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.volume)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label volumeLabel;

        private System.Windows.Forms.TrackBar volume;

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button play_pause;

        private System.Windows.Forms.Button next;

        private System.Windows.Forms.ComboBox music;

        private System.Windows.Forms.TabPage musicTabPage;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox nameUpdateTextBox;
        private System.Windows.Forms.TextBox surnameUpdateTextBox;
        private System.Windows.Forms.TextBox phoneUpdateTextBox;
        private System.Windows.Forms.TextBox passportUpdateTextBox;
        private System.Windows.Forms.DateTimePicker birthDayUpdateDateTime;

        private System.Windows.Forms.GroupBox clientUpdateGroupBox;

        private System.Windows.Forms.TextBox arrivalAirportUpdateTextBox;
        private System.Windows.Forms.TextBox departureAirportUpdateTextBox;
        private System.Windows.Forms.TextBox priceUpdateTextBox;
        private System.Windows.Forms.DateTimePicker departureUpdateDateTime;
        private System.Windows.Forms.DateTimePicker arrivalUpdateDateTime;

        private System.Windows.Forms.TextBox flightNumberUpdateTextBox;

        private System.Windows.Forms.GroupBox flightUpdateGroupBox;
        private System.Windows.Forms.Label flightNumberUpdateLabel;
        private System.Windows.Forms.Label departureAirportUpdateLabel;
        private System.Windows.Forms.Label arrivalAirportUpdateLabel;
        private System.Windows.Forms.Label departureDateUpdateLabel;
        private System.Windows.Forms.Label arrivalDateUpdateLabel;
        private System.Windows.Forms.Label priceUpdateLabel;

        private System.Windows.Forms.Button updateIDButton;

        private System.Windows.Forms.TextBox updateTextBox;

        private System.Windows.Forms.Label updateLabel;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Label deleteLabel;

        private System.Windows.Forms.Button fullClearButton;

        private System.Windows.Forms.Label readIDlabel;
        private System.Windows.Forms.TextBox readIDTextBox;

        private System.Windows.Forms.Button readFromID;
        private System.Windows.Forms.Button readAllData;

        private System.Windows.Forms.DateTimePicker birthDayDateUsers;

        private System.Windows.Forms.DateTimePicker arrivalDateTime;

        private System.Windows.Forms.DateTimePicker departureDateTime;

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepatrureAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;

        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;

        private System.Windows.Forms.DataGridView flightsDataGridView;

        private System.Windows.Forms.Button createButton;

        private System.Windows.Forms.TextBox passportTextBox;

        private System.Windows.Forms.GroupBox flightInformationGroupBox;
        private System.Windows.Forms.GroupBox clientInformationGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label borthDayLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;

        private System.Windows.Forms.TextBox departureAirportTextBox;

        private System.Windows.Forms.Label departureAirportLabel;

        private System.Windows.Forms.Label dateDepartureLabel;
        private System.Windows.Forms.Label dateArrivalLabel;
        private System.Windows.Forms.Label priceLabel;

        private System.Windows.Forms.TextBox arrivalAirportTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label arrivalAirportLabel;

        private System.Windows.Forms.Label flightNumberLabel;

        private System.Windows.Forms.TextBox flightNumberTextBox;

        private System.Windows.Forms.TabPage updateTabPage;
        private System.Windows.Forms.TabPage deleteTabPage;

        private System.Windows.Forms.TabControl CRUDTabControl;
        private System.Windows.Forms.TabPage createTabPage;
        private System.Windows.Forms.TabPage readTabPage;

        #endregion
    }
}