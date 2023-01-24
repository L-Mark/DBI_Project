IF EXISTS (SELECT * FROM sys.databases WHERE name = 'aether_db')
BEGIN
    DROP DATABASE aether_db
END

CREATE DATABASE aether_db
USE aether_db

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY (1,1),
    UserName VARCHAR(50) NOT NULL UNIQUE,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    Last_Online TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP

);

CREATE TABLE UserPreferences (
    UserPreferenceID INT PRIMARY KEY IDENTITY (1,1),
    UserID INT NOT NULL UNIQUE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    Language VARCHAR(255) NOT NULL,
    TimeZone VARCHAR(255) NOT NULL,
    Theme VARCHAR(255) NOT NULL
);

CREATE TABLE Devices (
    DeviceID INT PRIMARY KEY,
    UserID INT NOT NULL UNIQUE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    DeviceType VARCHAR(255) NOT NULL,
    DeviceName VARCHAR(255) NOT NULL
);

CREATE TABLE Commands (
    CommandID INT PRIMARY KEY IDENTITY (1,1),
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CommandText VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Responses (
    ResponseID INT PRIMARY KEY IDENTITY (1,1),
    CommandID INT NOT NULL UNIQUE,
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users (UserID),
    FOREIGN KEY (CommandID) REFERENCES Commands(CommandID),
    ResponseText VARCHAR(255) NOT NULL
);

CREATE TABLE History (
    UserID INT NOT NULL UNIQUE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    DeviceID INT NOT NULL UNIQUE,
    FOREIGN KEY (DeviceID) REFERENCES Devices(DeviceID),
    CommandID INT NOT NULL UNIQUE,
    FOREIGN KEY (CommandID) REFERENCES Commands(CommandID),
    ResponseID INT NOT NULL UNIQUE,
    FOREIGN KEY (ResponseID) REFERENCES Responses(ResponseID),
    Timestamp TIMESTAMP NOT NULL
);
