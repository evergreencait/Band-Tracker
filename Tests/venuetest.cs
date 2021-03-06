using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BandTracker
{
    public class VenueTest : IDisposable
    {
        public VenueTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
        }

        [Fact]
        public void Test_VenueEmptyAtFirst()
        {
            //Arrange, Act
            int result = Venue.GetAll().Count;

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Equal_ReturnsTrueForSameName()
        {
            //Arrange, Act
            Venue firstVenue = new Venue("Gorge");
            Venue secondVenue = new Venue("Gorge");

            //Assert
            Assert.Equal(firstVenue, secondVenue);
        }

        [Fact]
        public void Test_Save_SavesVenueToDatabase()
        {
            //Arrange
            Venue testVenue = new Venue("Gorge");
            testVenue.Save();

            //Act
            List<Venue> result = Venue.GetAll();
            List<Venue> testList = new List<Venue>{testVenue};

            //Assert
            Assert.Equal(testList, result);
        }

        [Fact]
        public void Test_Save_AssignsIdToVenueObject()
        {
            //Arrange
            Venue testVenue = new Venue("Gorge");
            testVenue.Save();

            //Act
            Venue savedVenue = Venue.GetAll()[0];

            int result = savedVenue.GetId();
            int testId = testVenue.GetId();

            //Assert
            Assert.Equal(testId, result);
        }
        [Fact]
        public void UpdateVenue_UpdateVenuesInDatabase_true()
        {
            //Arrange
            string name = "Gorge";
            Venue testVenue = new Venue(name, 2);
            testVenue.Save();
            string newName = "Gorge Amphitheater";

            //Act
            testVenue.UpdateVenue(newName);

            string result = testVenue.GetName();

            //Assert
            Assert.Equal(newName, result);
        }

        [Fact]
        public void Test_AddBand_AddsBandToVenue()
        {
            //Arrange
            Band testBand = new Band("Radiohead");
            testBand.Save();

            Venue testVenue = new Venue("Gorge");
            testVenue.Save();

            //Act
            testVenue.AddBand(testBand);

            List<Band> result = testVenue.GetBands();
            List<Band> testList = new List<Band>{testBand};

            //Assert
            Assert.Equal(testList, result);
        }

        [Fact]
        public void Test_GetBands_ReturnsAllVenuesBands()
        {
            //Arrange
            Venue testVenue = new Venue("Gorge");
            testVenue.Save();

            Band testBand1 = new Band("Radiohead");
            testBand1.Save();

            Band testBand2 = new Band("Fleetwood Mac");
            testBand2.Save();

            //Act
            testVenue.AddBand(testBand1);
            List<Band> result = testVenue.GetBands();
            List<Band> testList = new List<Band> {testBand1};

            //Assert
            Assert.Equal(testList, result);
        }

        [Fact]
        public void Test_Delete_DeletesVenuesAssociationsFromDatabase()
        {
            //Arrange
            Band testBand = new Band("Radiohead");
            testBand.Save();

            Venue testVenue = new Venue("Gorge");
            testVenue.Save();

            //Act
            testVenue.AddBand(testBand);
            testVenue.Delete();

            List<Venue> resultBandsVenues = testBand.GetVenues();
            List<Venue> testBandsVenues = new List<Venue> {};

            //Assert
            Assert.Equal(testBandsVenues, resultBandsVenues);
        }

        public void Dispose()
        {
            Band.DeleteAll();
            Venue.DeleteAll();
        }
    }
}
