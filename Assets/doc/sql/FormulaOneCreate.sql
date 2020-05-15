CREATE TABLE [dbo].[circuits] (
  "circuitId" int NOT NULL IDENTITY,
  "circuitRef" varchar(255) NOT NULL DEFAULT '',
  "name" varchar(255) NOT NULL DEFAULT '',
  "location" varchar(255) DEFAULT NULL,
  "country" varchar(255) DEFAULT NULL,
  "lat" float DEFAULT NULL,
  "lng" float DEFAULT NULL,
  "alt" int DEFAULT NULL,
  "url" varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY ("circuitId"),
);

CREATE TABLE [dbo].[constructors] (
  "constructorId" INT NOT NULL IDENTITY,
  "constructorRef" varchar(255) NOT NULL DEFAULT '',
  "name" varchar(255) NOT NULL DEFAULT '',
  "nationality" varchar(255) DEFAULT NULL,
  "url" varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY ("constructorId"),
);

CREATE TABLE [dbo].[drivers] (
  "driverId" INT NOT NULL IDENTITY,
  "driverRef" varchar(255) NOT NULL DEFAULT '',
  "number" INT DEFAULT NULL,
  "code" varchar(3) DEFAULT NULL,
  "forename" varchar(255) NOT NULL DEFAULT '',
  "surname" varchar(255) NOT NULL DEFAULT '',
  "dob" date DEFAULT NULL,
  "nationality" varchar(255) DEFAULT NULL,
  "url" varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY ("driverId"),
);

CREATE TABLE [dbo].[races] (
  "raceId" INT NOT NULL IDENTITY,
  "year" INT NOT NULL DEFAULT '0',
  "round" INT NOT NULL DEFAULT '0',
  "circuitId" INT NOT NULL DEFAULT '0',
  "name" varchar(255) NOT NULL DEFAULT '',
  "date" date NOT NULL DEFAULT '0000-00-00',
  "time" time DEFAULT NULL,
  "url" varchar(255) DEFAULT NULL,
  PRIMARY KEY ("raceId"),
);

CREATE TABLE [dbo].[results] (
  "resultId" INT NOT NULL IDENTITY,
  "raceId" INT NOT NULL DEFAULT '0',
  "driverId" INT NOT NULL DEFAULT '0',
  "constructorId" INT NOT NULL DEFAULT '0',
  "number" INT DEFAULT NULL,
  "grid" INT NOT NULL DEFAULT '0',
  "position" INT DEFAULT NULL,
  "positionText" varchar(255) NOT NULL DEFAULT '',
  "positionOrder" INT NOT NULL DEFAULT '0',
  "points" float NOT NULL DEFAULT '0',
  "laps" INT NOT NULL DEFAULT '0',
  "time" varchar(255) DEFAULT NULL,
  "milliseconds" INT DEFAULT NULL,
  "fastestLap" INT DEFAULT NULL,
  "rank" INT DEFAULT '0',
  "fastestLapTime" varchar(255) DEFAULT NULL,
  "fastestLapSpeed" varchar(255) DEFAULT NULL,
  "statusId" INT NOT NULL DEFAULT '0',
  PRIMARY KEY ("resultId")
);