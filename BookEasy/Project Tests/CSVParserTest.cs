using BookEasy.Ingestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using BookEasy.Models;
using System.Collections.Generic;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace Project_Tests
{
    

    [TestClass()]
    public class CSVParserTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        
        [TestMethod()]
        public void parseOwnersTest()
        {
            StreamReader reader = new StreamReader("d:\\nci\\owners.csv");
            CSVParser target = new CSVParser(); 
            target.setStreamSource(reader);
            
            Owner owns = new Owner();
            owns.firstname="Alexander";
            owns.surname="Carson";
            owns.address1="92 Margarenstrasse";
            owns.address2="Vienna";
            owns.country = "Italy";
            owns.email="alexcarson@sabio.il";
            owns.contactno="+353 67639287828";
            owns.holidayhomeno="9876";
            


            List<Owner> expected = new List<Owner>();
            expected.Add(owns);
            List<Owner> actual;
            actual = target.parseOwners();


            Assert.AreEqual(expected[0].address1, actual[0].address1);
            Assert.AreEqual(expected[0].country, actual[0].country);
            Assert.AreEqual(expected[0].contactno, actual[0].contactno);

        }


              [TestMethod()]
             
              public void parseHolidayhomesTest1()
              {
                  StreamReader reader = new StreamReader("d:\\nci\\holidayhomes.csv");
                  CSVParser target = new CSVParser(); 
                  target.setStreamSource(reader);
            
                  Holidayhome hse = new Holidayhome();
                  hse.holidayhomeno="Spain";
                  hse.address1="San Costa";
                  hse.address2="Valencia";
                  hse.country = "Spain";
                  hse.email="john@live.com";
                  hse.contactno="+353 18767352";
                  hse.amenities="Swimming Pool| Gym | Sauna";
                  hse.price="445";


                 List<Holidayhome> expected = new List<Holidayhome>();
                 expected.Add(hse);
                 List<Holidayhome> actual = target.parseHolidayhomes();

                
                 Assert.AreEqual(expected[0].address1, actual[0].address1);
                 Assert.AreEqual(expected[0].country, actual[0].country);
                 Assert.AreEqual(expected[0].contactno, actual[0].contactno);
                                    
              }



              [TestMethod()]
              public void supportsTypeCSVTest()
              {
                  CSVParser csvtest = new CSVParser();
                  string format = "csv";
                  bool expected = true; 
                  bool actual;
                  actual = csvtest.supportsType(format);
                  Assert.AreEqual(expected, actual);
              }
    
              [TestMethod()]
              public void notsupportsTypeXLSTest()
              {
                  CSVParser csvtest = new CSVParser();
                  string format = "xls";
                  bool expected = false;
                  bool actual;
                  actual = csvtest.supportsType(format);
                  Assert.AreEqual(expected, actual);
              }

              [TestMethod()]
              public void notsupportsTypeXLSXTest()
              {
                  CSVParser csvtest = new CSVParser();
                  string format = "xlsx ";
                  bool expected = false;
                  bool actual;
                  actual = csvtest.supportsType(format);
                  Assert.AreEqual(expected, actual);
              }


              [TestMethod()]
              public void notsupportsTypeBlankTest()
              {
                  CSVParser csvtest = new CSVParser();
                  string format = " ";
                  bool expected = false;
                  bool actual;
                  actual = csvtest.supportsType(format);
                  Assert.AreEqual(expected, actual);
              }    
   


        [TestMethod()]
               public void setStreamSourceHolidayhomeTest()
                {
                string Holidayhomefile = "D:\\NCI\\holidayhomes.csv";
                CSVParser target = new CSVParser();
                StreamReader reader = new StreamReader(Holidayhomefile);
                target.setStreamSource(reader);
                
                }


        [TestMethod()]
        public void setStreamSourceOwnerTest()
        {
            string Ownerfile = "d:\\nci\\owners.csv";
            CSVParser target = new CSVParser();
            StreamReader reader = new StreamReader(Ownerfile);
            target.setStreamSource(reader);

        }



    }
}
