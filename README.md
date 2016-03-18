# AuroraDb
### Simple MySql / SqlServer / Oracle Database Connection Library for .NET

> **Supported databases:** MySql , MSSql Server , Oracle

> **Return Types:** JSON , List(object) , DataTable , XML (not yet)

## Using

* Add AuroraDb to your project as project reference
* Configure connection types and connection strings
* Set your queries on Aurora Config
* Call ExecuteCommand()

```cs

AuroraDb.Main.AddConnection(ConnectionTypes.SQL_SERVER, "[CONNECTION_STRING]");
AuroraDb.Main.AddQuery(ConnectionTypes.SQL_SERVER, "[UNIQUE_QUERY_ID]", "[QUERY_STRING]");

var res = AuroraDb.Main.ExecuteCommand(ConnectionTypes.SQL_SERVER, "[UNIQUE_QUERY_ID]", ReturnTypes.DataTable, new List<DbParam>());

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
