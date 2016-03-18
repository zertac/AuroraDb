# AuroraDb - Simple MySql / SqlServer / Oracle Database Connection Library

#### Supported databases : MySql , MSSql Server , Oracle
#### Return Types : JSON , List(object) , DataTable , XML

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
## Using with parameters
```cs
 var prms = new List<DbParam>
            {
                new DbParam{ key = "USER_NAME",value = "test"},
                new DbParam{ key = "PASS",value = "12345"}
            };

var res = AuroraDb.Main.ExecuteCommand(ConnectionTypes.SQL_SERVER, "cards", ReturnTypes.JsonString, prms);
```
