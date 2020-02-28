import getpass
import json

with open('../FormulaOneScrapy/drivers.json') as data_file:
    data = json.load(data_file)
sqlQuery = """
INSERT INTO [dbo].[Drivers]
(
    Name,
    Team,
    Country,
    Podlumns,
    Points,
    GrandsPrixEntered,
    WorldChampionships,
    HighestRaceFinish,
    HighestGridPosition,
    DateOfBirth,
    PlaceOfBirth,
    PathImgSmall,
    PathImgLarge,
)
VALUES
"""
for drivers in data:
    sqlQuery+="("
    for items in drivers:
        sqlQuery += '"%s",'%(drivers[items])
    sqlQuery+=")\n"

text_file = open("Output/Output.txt", "w")
text_file.write(sqlQuery)
text_file.close()

sqlFile= open("C:/Users/"+ getpass.getuser() +"/Documents/MSSQLDatabase/FormulaOne/Drivers.sql", "w")
sqlFile.write(sqlQuery)
sqlFile.close()

print(sqlQuery)
