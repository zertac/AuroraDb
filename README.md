# AuroraDb - Simple MySql / SqlServer / Oracle Database Connection Library

## Using

* Add AuroraDb to your project as project reference
* Configure connection types and connection strings
* Set your queries on Aurora Config
* Call ExecuteCommand()

```cs

AuroraDb.Main.AddConnection(ConnectionTypes.SQL_SERVER, " Server = DESKTOP-serv\\SQLEXPRESS; Database =test_db; User Id = sertac;Password = 12345;");
AuroraDb.Main.AddQuery(ConnectionTypes.SQL_SERVER, "cards", "SELECT [TOTAL_CARD],[TOTAL_SOLD] ,[TOTAL_LEFT] FROM[example_table].[dbo].[v_card_stock]");

var res = AuroraDb.Main.ExecuteCommand(ConnectionTypes.SQL_SERVER, "cards", ReturnTypes.DataTable, new List<DbParam>());

tbl.DataSource = res;
```
