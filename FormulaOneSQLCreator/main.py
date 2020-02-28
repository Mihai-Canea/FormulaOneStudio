import sys
import getopt
import getpass
import json


def PrintOutput(sqlQuery, QueryName):
    text_file = open("Output/Output.txt", "w")
    text_file.write(sqlQuery)
    text_file.close()

    sqlFile = open("C:/Users/" + getpass.getuser() +
                   "/Documents/MSSQLDatabase/FormulaOne/{}00.sql".format(QueryName), "w")
    sqlFile.write(sqlQuery)
    sqlFile.close()


def SQLtable(TableName, JsonFile):
    lastTableColumn = 0
    queryContent = ""
    print("Name", TableName, "JSON", JsonFile)
    # "{}{}".format(s, y)
    with open('../FormulaOneScrapy/{}.json'.format(JsonFile)) as data_file:
        data = json.load(data_file)
    # print("Data:\n",json.dumps(data, indent=4))

    for drivers in data:
        sqlQuery = "INSERT INTO [dbo].[{}](\n".format(TableName)
        for num, items in enumerate(drivers, start=1):
            if num == lastTableColumn:
                sqlQuery += "\t{},".format(items)
            else:
                sqlQuery += "\t{},\n".format(items)
        lastTableColumn = num
        break

    for drivers in data:
        queryContent += "("
        for num, items in enumerate(drivers, start=1):
            if drivers[items].find("'") != -1:
                print("ELEMENTO: ", drivers[items])
                drivers[items] = drivers[items].replace("'", "''")
                print("TROVATO: ", drivers[items])
            if num == lastTableColumn:
                queryContent += "'{}'".format(drivers[items])
            else:
                queryContent += "'{}',".format(drivers[items])
        queryContent += ")\n"

    sqlQuery += "\n)\nVALUES\n{}".format(queryContent)
    PrintOutput(sqlQuery, TableName)
    print(sqlQuery)


def main(argv):
    inputfile = ''
    outputfile = ''
    try:
        opts, args = getopt.getopt(argv, "t:o:", ["iTable=", "ofile="])
        print("OPTS: ", opts, "ARGS ", args)
    except getopt.GetoptError:
        print('main.py -t <DB table name> -o <Output.txt>')
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-help':
            print('main.py -t <DB table name> -o <Output.txt>')
            sys.exit()
        elif opt in ("-t", "--iTable"):
            print("OPT ", opt, "ARG ", arg)
            inputfile = arg
        elif opt in ("-o", "--ofile"):
            print("OPT ", opt, "ARG ", arg)
            outputfile = arg

    SQLtable(inputfile, inputfile.casefold())
    # print('Input file is "', inputfile)
    # print('Output file is "', outputfile)


if __name__ == "__main__":
    main(sys.argv[1:])
