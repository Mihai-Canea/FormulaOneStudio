import scrapy

# ─── TO EXECUTE SPIDER ──────────────────────────────────────────────────────────
# Write in command line
# scrapy crawl drivers -o drivers.json


class Drivers(scrapy.Spider):
    name = "drivers"
    
    start_urls = [
        "https://www.formula1.com/en/drivers/lewis-hamilton.html",
        "https://www.formula1.com/en/drivers/valtteri-bottas.html",
        "https://www.formula1.com/en/drivers/charles-leclerc.html",
        "https://www.formula1.com/en/drivers/max-verstappen.html",
        "https://www.formula1.com/en/drivers/sebastian-vettel.html",
        "https://www.formula1.com/en/drivers/pierre-gasly.html",
        "https://www.formula1.com/en/drivers/carlos-sainz.html",
        "https://www.formula1.com/en/drivers/alexander-albon.html",
        "https://www.formula1.com/en/drivers/daniel-ricciardo.html",
        "https://www.formula1.com/en/drivers/daniil-kvyat.html",
        "https://www.formula1.com/en/drivers/nico-hulkenberg.html",
        "https://www.formula1.com/en/drivers/lando-norris.html",
        "https://www.formula1.com/en/drivers/kimi-raikkonen.html",
        "https://www.formula1.com/en/drivers/sergio-perez.html",
        "https://www.formula1.com/en/drivers/lance-stroll.html",
        "https://www.formula1.com/en/drivers/kevin-magnussen.html",
        "https://www.formula1.com/en/drivers/romain-grosjean.html",
        "https://www.formula1.com/en/drivers/antonio-giovinazzi.html",
        "https://www.formula1.com/en/drivers/robert-kubica.html",
        "https://www.formula1.com/en/drivers/george-russell.html",
    ]
# body > div.site-wrapper > main > article > div > header > section.profile > div > figure > figcaption > h1

    def parse(self, response):
        driverName = ""
        for item in response.css("figcaption.driver-details"):
            driverName = item.css("h1.driver-name::text").get()
            """ yield{
                "Name": driverName,
            } """

        for questions in response.css("table.stat-list"):
            yield{
                "Name": driverName,
                "Team": questions.css("tbody>tr:nth-child(1)>td::text").get(),
                "Country": questions.css("tbody>tr:nth-child(2)>td::text").get(),
                "Podlumns": questions.css("tbody>tr:nth-child(3)>td::text").get(),
                "Points": questions.css("tbody>tr:nth-child(4)>td::text").get(),
                "GrandsPrixEntered": questions.css("tbody>tr:nth-child(5)>td::text").get(),
                "WorldChampionships": questions.css("tbody>tr:nth-child(6)>td::text").get(),
                "HighestRaceFinish": questions.css("tbody>tr:nth-child(7)>td::text").get(),
                "HighestGridPosition": questions.css("tbody>tr:nth-child(8)>td::text").get(),
                "DateOfBirth": questions.css("tbody>tr:nth-child(9)>td::text").get(),
                "PlaceOfBirth": questions.css("tbody>tr:nth-child(10)>td::text").get(),
            }


class Teams(scrapy.Spider):
    name = "teams"
    start_urls = [
        "https://www.formula1.com/en/teams/Alfa-Romeo-Racing.html",
        "https://www.formula1.com/en/teams/Haas-F1-Team.html",
        "https://www.formula1.com/en/teams/Racing-Point.html",
        "https://www.formula1.com/en/teams/Williams.html",
        "https://www.formula1.com/en/teams/AlphaTauri.html",
        "https://www.formula1.com/en/teams/McLaren.html",
        "https://www.formula1.com/en/teams/Red-Bull-Racing.html",
        "https://www.formula1.com/en/teams/Ferrari.html",
        "https://www.formula1.com/en/teams/Mercedes.html",
        "https://www.formula1.com/en/teams/Renault.html",
    ]

    def parse(self, response):
        teamName = ""
        # body > div.site-wrapper > main > article > div > header:nth-child(1) > h1
        for item in response.css("div.inner-wrap.group>header:nth-child(1)"):
            teamName = item.css("h1.headline::text").get()

        for questions in response.css("table.stat-list"):
            # body > div.site-wrapper > main > article > div > header.team-details > section.stats > div > table > tbody > tr:nth-child(1) > td
            yield{
                "Name": teamName,
                "FullTeamName": questions.css("tbody>tr:nth-child(1)>td::text").get(),
                "Base": questions.css("tbody>tr:nth-child(2)>td::text").get(),
                "TeamChief": questions.css("tbody>tr:nth-child(3)>td::text").get(),
                "TechnicalChief": questions.css("tbody>tr:nth-child(4)>td::text").get(),
                "Chassis": questions.css("tbody>tr:nth-child(5)>td::text").get(),
                "PowerUnit": questions.css("tbody>tr:nth-child(6)>td::text").get(),
                "FirstTeamEntry": questions.css("tbody>tr:nth-child(7)>td::text").get(),
                "WorldChampionships": questions.css("tbody>tr:nth-child(8)>td::text").get(),
                "HighestRaceFinish": questions.css("tbody>tr:nth-child(9)>td::text").get(),
                "PolePosition": questions.css("tbody>tr:nth-child(10)>td::text").get(),
                "FastestLaps": questions.css("tbody>tr:nth-child(11)>td::text").get(),
            }


class FixClass(scrapy.Spider):
    name = "sas"
    domain = "https://www.formula1.com"
    start_urls = ["https://www.formula1.com/en/teams.html"]

    def parse(self, response):
        for questions in response.css("div.container.listing.team-listing > div.row > div"):
            self.start_urls.append(self.domain + questions.css("a::attr(href)").get())

        self.start_urls.remove(self.start_urls[0])
        print("----------------------------------\n{}-----------------------\n".format(self.start_urls))

        for questions in response.css("table.stat-list"):
            # body > div.site-wrapper > main > article > div > header.team-details > section.stats > div > table > tbody > tr:nth-child(1) > td
            yield{
                "FullTeamName": questions.css("tbody>tr:nth-child(1)>td::text").get(),
                "Base": questions.css("tbody>tr:nth-child(2)>td::text").get(),
                "TeamChief": questions.css("tbody>tr:nth-child(3)>td::text").get(),
                "TechnicalChief": questions.css("tbody>tr:nth-child(4)>td::text").get(),
                "Chassis": questions.css("tbody>tr:nth-child(5)>td::text").get(),
                "PowerUnit": questions.css("tbody>tr:nth-child(6)>td::text").get(),
                "FirstTeamEntry": questions.css("tbody>tr:nth-child(7)>td::text").get(),
                "WorldChampionships": questions.css("tbody>tr:nth-child(8)>td::text").get(),
                "HighestRaceFinish": questions.css("tbody>tr:nth-child(9)>td::text").get(),
                "PolePosition": questions.css("tbody>tr:nth-child(10)>td::text").get(),
                "FastestLaps": questions.css("tbody>tr:nth-child(11)>td::text").get(),
            }

#  div.container.listing.team-listing > div > div:nth-child(1) > a > fieldset > div > div.listing-info > div.name.f1-bold--m > span.f1-color--black
