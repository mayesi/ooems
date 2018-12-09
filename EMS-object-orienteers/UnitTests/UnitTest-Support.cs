using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestSupport
    {
        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_StartDatabaseSystem_CreateFiles
        /// Description         : to see that the Databases folder and DatabasList.txt file are created if they do not exist
        /// Performed           : Manual: The Databases folder and DatabaseList.txt files must NOT exist in the same folder as the exe. Run the method.
        /// Type                : functional
        /// Expected outcome    : Database folder and DatabaseList.txt files are created. Method returns 'true'.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_StartDatabaseSystem_CreateFiles()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_StartDatabaseSystem_DoesNotCreateFiles
        /// Description         : to see that the Databases folder and DatabasList.txt file are not affected if they exist
        /// Performed           : Manual: The Databases folder and DatabaseList.txt files must exist in the same folder as the exe. Run the method.
        /// Type                : functional
        /// Expected outcome    : Existing Database folder and DatabaseList.txt files are not changed. Method returns 'true'.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_StartDatabaseSystem_DoesNotCreateFiles()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_CreateNewDatabase_WhenActuallyNew
        /// Description         : to see that a new database file is created and the information is added to the DatabaseList.txt file correctly
        /// Performed           : Manual: After starting the database system, run the function with a database name that does not already exist.
        /// Type                : functional
        /// Expected outcome    : A new database file will be created, the parameters in the databaselist.txt file
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_CreateNewDatabase_WhenActuallyNew()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_CreateNewDatabase_WhenActuallyExists
        /// Description         : to see that an exception is thrown when the database already exists
        /// Performed           : Automated: Add a new database, Run the method again with the same database name.
        /// Type                : exception
        /// Expected outcome    : The object will be instantiated properly.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_CreateNewDatabase_WhenActuallyExists()
        {
        }


        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_Constructor_CreateObject
        /// Description         : to see that an exception is thrown when the database already exists
        /// Performed           : Automated: Add a new database, Run the method again with the same database name.
        /// Type                : exception
        /// Expected outcome    : an argumentexception is thrown indicating that the database already exists
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_Constructor_CreateObject()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_Constructor_DatabasesFolderMissing
        /// Description         : to see that an exception is thrown when the Databases folder is missing
        /// Performed           : Automated: Delete the database folder if it exists, call the constructor method normally.
        /// Type                : exception
        /// Expected outcome    : A DirectoryNotFoundException will be thrown.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_Constructor_DatabasesFolderMissing()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_Constructor_DatabaseListMissingDatabase
        /// Description         : to see that an exception is thrown when the DatabasesList.txt file is missing
        /// Performed           : Automated: Delete DatabasesList.txt if it exists, call the constructor method normally.
        /// Type                : exception
        /// Expected outcome    : A FileNotFoundException will be thrown.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_Constructor_DatabaseListMissingDatabase()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_Constructor_DatabaseDoesNotExist
        /// Description         : to see that an exception is thrown when the database does not exist
        /// Performed           : Automated: Delete the selected database.txt file if it exists, call the constructor method with that database name.
        /// Type                : exception
        /// Expected outcome    : An exception will be thrown saying the database does not exist.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_Constructor_DatabaseDoesNotExist()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetDatabaseName_ReturnsName
        /// Description         : verify that the name is returned correctly
        /// Performed           : Automated: Instantiate an object with an existing database name. Call the method.
        /// Type                : functional
        /// Expected outcome    : The name will be returned properly.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetDatabaseName_ReturnsName()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetRecordSize_ReturnsSize
        /// Description         : verify that the maximum size of a record is returned correctly
        /// Performed           : Automated: Instantiate an object with an existing database name. Call the method.
        /// Type                : functional
        /// Expected outcome    : the size will be returned properly
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetRecordSize_ReturnsSize()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetKey_ReturnsKey
        /// Description         : verify that the primary key for the records are returned correctly
        /// Performed           : Automated: Instantiate an object with an existing database name. Call the method.
        /// Type                : functional
        /// Expected outcome    : the primary key will be returned properly
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetKey_ReturnsKey()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetDatabase_PopulatesDictionaryProperly
        /// Description         : verify that all lines of a database file are read and parsed correctly into the Dictionary container.
        /// Performed           : Automated: Instantiate an object with an existing database name (test1db). Print out the key and value pairs of the dictionary.
        /// Type                : Functional
        /// Expected outcome    : the first field in test1db.txt will be the key, the whole line will be the value. All lines are accounted for.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetDatabase_PopulatesDictionaryProperly()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetDatabase_DuplicatePrimaryKeyValue
        /// Description         : verify that an exception will be thrown, saying that the database is corrupted
        /// Performed           : Automated: Instantiate and object with an existing database name (test2db).
        /// Type                : exception
        /// Expected outcome    : An exception will be thrown saying the database is corrupted.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetDatabase_DuplicatePrimaryKeyValue()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetDatabase_EmptyDatabase
        /// Description         : verify that there are not exceptions when there are no records in a database.
        /// Performed           : Automated: Instantiate an object with an existing database name (emptydb). Print out count of objects in database dictionary.
        /// Type                : functional
        /// Expected outcome    : no exception is thrown, count is zero
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetDatabase_EmptyDatabase()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetDatabaseInfo_ReturnsInfoProperly
        /// Description         : verify that the recordSize and primaryKey fields are set properly when an object is instantated.
        /// Performed           : Automated: Instantiate an object with an existing database name (test1db). Call methods GetKey and GetRecordSize.
        /// Type                : functional
        /// Expected outcome    : the fields match what is in the databaseList.txt file
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetDatabaseInfo_ReturnsInfoProperly()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetDatabaseInfo_DatabaseNotInList
        /// Description         : verify that an exception will be thrown, saying that the database is corrupted
        /// Performed           : Automated: Instantiate an object with a database that is missing from the list (notrealdb).
        /// Type                : exception
        /// Expected outcome    : An exception will be thrown saying the database is corrupted.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetDatabaseInfo_DatabaseNotInList()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_UpdateDatabaseFile_SuccessfullyChangedExistingEntry
        /// Description         : verity that an existing record is changed when calling the method
        /// Performed           : Automated: Instantiate an object with test1db. Make a new record using an existing record but change the fruit. 
        ///                       Call the method with the new record and the records primary key. Compare lines in file to expected.
        /// Type                : functional
        /// Expected outcome    : only the fruit will change in the database for the selected record.
        /// 
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_UpdateDatabaseFile_SuccessfullyChangedExistingEntry()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_UpdateDatabaseFile_PrimaryKeyValueNotInDatabase
        /// Description         : verify that an exception will be thrown, saying that the record does not exist
        /// Performed           : Automated: Instantiate an object with test1db. Make a new record with a new primary key. 
        ///                       Call the method with the new primary key and new record.
        /// Type                : exception
        /// Expected outcome    : an exception will be thrown.
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_UpdateDatabaseFile_PrimaryKeyValueNotInDatabase()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_AddNewRecord_AddsNewRecord
        /// Description         : verify that an exception will be thrown, saying that the record does not exist
        /// Performed           : Automated: Instantiate an object with test1db. Make a new record with a new primary key. 
        ///                       Call the method with the record. Compare lines in file to expected.
        /// Type                : functional
        /// Expected outcome    : the new record is added to the database file.
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_AddNewRecord_AddsNewRecord()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_AddNewRecord_PrimaryKeyValueAlreadyExists
        /// Description         : verify that an exception will be thrown indicating that the primary key value already exists.
        /// Performed           : Automated: Instantiate an object with test1db. Make a new record with an existing primary key value. 
        ///                       Call the method with the new record.
        /// Type                : exception
        /// Expected outcome    : an exception will be thrown.
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_AddNewRecord_PrimaryKeyValueAlreadyExists()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_ParseRecord_GetsKeyValue
        /// Description         : verify that the key value is parsed from the record
        /// Performed           : part of the test GetDatabase_PopulatesDictionaryProperly
        /// Type                : functional
        /// Expected outcome    : the first field in test1db.txt will be the key, the whole line will be the value. All lines are accounted for.
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_ParseRecord_GetsKeyValue()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_ParseRecord_RecordIsAnEmptyString
        /// Description         : verify that an exception is thrown indicating that the database is corrupted
        /// Performed           : part of the test GetDatabase_PopulatesDictionaryProperly
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_ParseRecord_RecordIsAnEmptyString()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_ParseRecord_RecordIsAnEmptyString
        /// Description         : verify that the method can find and return an existing record
        /// Performed           : Automated: Instantiate an object with test1db. Call the method looking for an existing value (eg. 1). 
        ///                       Compare result to expected.
        /// Type                : functional
        /// Expected outcome    : it will find the correct record.
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetRecord_FindsAndReturnsARecord()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetRecord_DoesNotFindAMatch
        /// Description         : verify that the method can function without throwing an exception when there is no match.
        /// Performed           : Automated: Instantiate an object with test1db. Call the method looking for a non existent value (eg. 10). 
        ///                       Compare result to expected.
        /// Type                : functional
        /// Expected outcome    : it will return an empty string.
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetRecord_DoesNotFindAMatch()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : DATABASE_TEST_GetRecord_SearchTermIsEmpty
        /// Description         : verify that the method will throw an exception when the search term is an empty string
        /// Performed           : Automated: Instantiate an object with test1db.Call the method using an empty string.
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void DATABASE_TEST_GetRecord_SearchTermIsEmpty()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : LOGGING_TEST_Logging_LogMsg
        /// Description         : to see that a message is logged correctly
        /// Performed           : Automated: Call the method with three strings as parameters.
        /// Type                : functional
        /// Expected outcome    : the strings will be logged properly.
        ///
        /// </summary>
        [TestMethod]
        public void LOGGING_TEST_Logging_LogMsg()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : LOGGING_TEST_Logging_LogFileMissing
        /// Description         : to see that a new file is created and the log happens correctly
        /// Performed           : Automated: Delete the log file if it exists, Call the method with three strings.
        /// Type                : functional
        /// Expected outcome    : a new log file is created and the message is written in the new file
        ///
        /// </summary>
        [TestMethod]
        public void LOGGING_TEST_Logging_LogFileMissing()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_WriteLine_AppendsLine
        /// Description         : verify that the method correctly appends the given line to the file
        /// Performed           : Manual: Call the method with any temporary text file (eg test3.txt) and a string. 
        ///                       Look at the file to see if the line is there.
        /// Type                : functional
        /// Expected outcome    : the line is written to the file
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_WriteLine_AppendsLine()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_WriteLine_FileDoesNotExist
        /// Description         : verify that the method correctly appends the given line to the newly created file
        /// Performed           : Manual: Call the method with any nonexisting text file (eg notreal.txt) and a string. 
        ///                       Look for the file and see if the line is there.
        /// Type                : functional
        /// Expected outcome    : the file is created and the line is there
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_WriteLine_FileDoesNotExist()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_WriteLine_EmptyFilepath
        /// Description         : verify that the method throws an exception when the filepath is empty
        /// Performed           : Automated: Call the method using an empty string for the filepath.
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_WriteLine_EmptyFilepath()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_ReadAllLines_GetsArray
        /// Description         : verify that the method reads all lines of a text file into an array of lines
        /// Performed           : Automated: Call the method using test1db.txt. Compare the resulting array to expected.
        /// Type                : functional
        /// Expected outcome    : the resulting array matches expected
        /// 
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_ReadAllLines_GetsArray()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_ReadAllLines_EmptyFilepath
        /// Description         : verify that the method throws an exception when the filepath is empty
        /// Performed           : Automated: Call the method using an empty string for the filepath.
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_ReadAllLines_EmptyFilepath()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_ReadAllLines_FileNotFound
        /// Description         : verify that the method throws an exception when the file is not found
        /// Performed           : Manual: Call the method using a non-existing file.
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_ReadAllLines_FileNotFound()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_FindLineInBytes_ReturnsMatchingLine
        /// Description         : verify that the method correctly identifies, retrieves and returns a matching line
        /// Performed           : Automatic: Call the method looking for 001 in the file testbyte.txt. Compare the resulting string with expected.
        /// Type                : functional
        /// Expected outcome    : the returned string matches expected
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_FindLineInBytes_ReturnsMatchingLine()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_FindLineInBytes_ReturnsNoMatch
        /// Description         : verify that the method correctly does not find a match when there isn't one and returns an empty string
        /// Performed           : Automatic: Call the method looking for 010 in the file testbyte.txt. Compare the resulting string with expected.
        /// Type                : functional
        /// Expected outcome    : the returned string is an empty string
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_FindLineInBytes_ReturnsNoMatch()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_FindLineInBytes_EmptyFilepath
        /// Description         : verify that the method throws an exception when the filepath is empty
        /// Performed           : Automated: Call the method using an empty string for the filepath.
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_FindLineInBytes_EmptyFilepath()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : FILESUPPORT_TEST_FindLineInBytes_FileNotFound
        /// Description         : verify that the method throws an exception when the file is not found
        /// Performed           : Manual: Call the method using a non-existing file.
        /// Type                : exception
        /// Expected outcome    : an exception is thrown
        ///
        /// </summary>
        [TestMethod]
        public void FILESUPPORT_TEST_FindLineInBytes_FileNotFound()
        {
        }
    }
}
