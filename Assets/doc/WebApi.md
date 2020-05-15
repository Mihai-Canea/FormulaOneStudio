# Web API

### Drivers
#### {year:int}/results - ./2016/drivers
```json
[
    {
        "driverId": 8,
        "forename": "Kimi",
        "surname": "Räikkönen",
        "constructor": "Ferrari",
        "number": 7,
        "dob": "1979-10-17T00:00:00",
        "nationality": "Finnish",
        "url": "en.wikipedia.org/wiki/Kimi_R%C3%A4ikk%C3%B6nen",
        "PathImgSmall": "https://www.formula1.com/content/dam/fom-website/drivers/K/KIMRAI01_Kimi_R%C3%A4ikk%C3%B6nen/kimrai01.png.transform/2col/image.png"
    },
	{
        "driverId": 3,
        "forename": "Nico",
        "surname": "Rosberg",
        "constructor": "Mercedes",
        "number": 6,
        "dob": "1985-06-27T00:00:00",
        "nationality": "German",
        "url": "en.wikipedia.org/wiki/Nico_Rosberg",
        "PathImgSmall": "https://e2.365dm.com/f1/drivers/h_full_521.png"
    },
	...
]
```

### Constructors
#### constructors/{id:int} - ./constructors/1
```json
{
    "constructorId": 131,
    "constructorRef": "mercedes",
    "name": "Mercedes",
    "nationality": "German",
    "url": "en.wikipedia.org/wiki/Mercedes-Benz_in_Formula_One",
    "PathImgSmall": "https://www.formula1.com/content/dam/fom-website/teams/2020/mercedes-logo.png.transform/2col/image.png"
}
```

### Races
#### {year:int}/races - ./2019/races/
```json
[
	{
		"year": 2019,
		"round": 1,
		"name": "Australian Grand Prix",
		"date": "2019-03-17T00:00:00",
		"time": "05:10:00",
		"circuitName": "Albert Park Grand Prix Circuit",
		"url": "en.wikipedia.org/wiki/2019_Australian_Grand_Prix",
		"PathImgSmall": "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Albert_Lake_Park_Street_Circuit_in_Melbourne%2C_Australia.svg/800px-Albert_Lake_Park_Street_Circuit_in_Melbourne%2C_Australia.svg.png"
	},
	{
		"year": 2019,
		"round": 2,
		"name": "Bahrain Grand Prix",
		"date": "2019-03-31T00:00:00",
		"time": "15:10:00",
		"circuitName": "Bahrain International Circuit",
		"url": "en.wikipedia.org/wiki/2019_Bahrain_Grand_Prix",
		"PathImgSmall": "https://upload.wikimedia.org/wikipedia/commons/2/29/Bahrain_International_Circuit--Grand_Prix_Layout.svg"
	},
	...
]
```

### Results
#### {year:int}/results/{round} - ./2016/results/1
```json
[
    {
        "forename": "Nico",
        "surname": "Rosberg",
        "number": 6,
        "position": 1,
        "positionText": "1",
        "positionOrder": 1,
        "laps": 57,
        "fastestLapTime": "1:30.557",
        "fastestLapSpeed": "210.815",
        "grid": 2,
        "points": 25.0
    },
    {
        "forename": "Lewis",
        "surname": "Hamilton",
        "number": 44,
        "position": 2,
        "positionText": "2",
        "positionOrder": 2,
        "laps": 57,
        "fastestLapTime": "1:30.646",
        "fastestLapSpeed": "210.608",
        "grid": 1,
        "points": 18.0
    },
	...
]
```

### Circuits
#### circuits/{id:int} - ./circuits/1
```json
{
    "circuitRef": "albert_park",
    "name": "Albert Park Grand Prix Circuit",
    "location": "Melbourne",
    "country": "Australia",
    "lat": -37.8497,
    "lng": 144.968,
    "alt": 10,
    "url": "en.wikipedia.org/wiki/Melbourne_Grand_Prix_Circuit",
    "PathImgSmall": "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Albert_Lake_Park_Street_Circuit_in_Melbourne%2C_Australia.svg/800px-Albert_Lake_Park_Street_Circuit_in_Melbourne%2C_Australia.svg.png"
}
```
