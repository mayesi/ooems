using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            // Test logging class
            Logging.LogMsg("TestHarness", "Test1", "This is a test of the Log method");

            // Testing the database
            // Start up the database system.
            //bool result = Database.StartDatabaseSystem();
            //Console.WriteLine("Database.StartDatabaseSystem() {0}", result);

            // Add a new database to the system
            //result = Database.CreateNewDatabase("test_database", 512, "test");
            //Console.WriteLine("Database.CreateNewDatabase('test_database', 512, 'test') {0}", result);

            // Test constructor and get methods
            //Database testdb = new Database("test_database");
            //Console.WriteLine("GetDatabaseName() {0}", testdb.GetDatabaseName());
            //Console.WriteLine("GetRecordSize() {0}", testdb.GetRecordSize());
            //Console.WriteLine("GetKey() {0}", testdb.GetKey());

            // Test adding a record to the database - currently does not check for duplicate keys
            //string newRecord = "001|value";
            //result = testdb.AddRecord(newRecord);
            //Console.WriteLine("AddRecord() {0}", result);

            // Test loading the database into the dictionary, this requires setting GetDatabase() and
            // the database field to public
            //testdb.GetDatabase();
            //foreach(KeyValuePair<string, string> pair in testdb.database)
            //{
            //    Console.WriteLine("Key: {0}    Value: {1}", pair.Key, pair.Value);
            //}

            //string record = testdb.GetRecord("001");
            //Console.WriteLine("GetRecord 001: {0}", record);

            // Update a record
            //result = testdb.UpdateRecord("001", "001|new value");
            //Console.WriteLine("UpdateRecord() {0}", result);
            //foreach (KeyValuePair<string, string> pair in testdb.database)
            //{
            //    Console.WriteLine("Key: {0}    Value: {1}", pair.Key, pair.Value);
            //}

            //

            // Test find line static method
            //string strResult = FileSupport.FindLineByBytes("test1.txt", "pear", 4);
            //Console.WriteLine("FindLineByBytes() {0}", strResult);
            int a = 10;
            int b = 56;
            int result = b / a;
            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }
    }
}
