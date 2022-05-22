# SqliteProviderBenchmarking

Motivation: I was using SQL as a database for unit tests in my selfmade ORM. I notised that database creating is very slow process. I tried to compare perfomance between System.Data.SQLite and Microsoft.Data.Sqlite on creating Chinook database.

![image](https://user-images.githubusercontent.com/22368203/169697327-95c8560f-db42-4bb0-bf01-b4b0450a4d53.png)

System.Data.SQLite has string preprocessing before executing - some trimming, replacing and UTF converting. The problem is that database creating script is about 15k lines of SQL code. And this make MS.Data about x60 faster in this test.
