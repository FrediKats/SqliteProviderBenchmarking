// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using SqliteProviderBenchmarking;

var databaseSqliteProvider = new DatabaseSqliteProvider();

var stopwatch2 = Stopwatch.StartNew();
databaseSqliteProvider.InitWithMsSqlite();
stopwatch2.Start();
Console.WriteLine($"MS: {stopwatch2.Elapsed}");

var stopwatch = Stopwatch.StartNew();
databaseSqliteProvider.InitWithSqlite();
stopwatch.Start();
Console.WriteLine($"Not ms: {stopwatch.Elapsed}");