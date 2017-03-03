using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BandTracker
{
    public class BandTest : IDisposable
    {
        public BandTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
        }
        [Fact]
        public void GetAll_BandEmptyAtFirst_true()
        {
            int result = Band.GetAll().Count;

            Assert.Equal(0, result);
        }

        [Fact]
        public void Equals_ReturnsTrueForSameName_true()
        {
            Band firstBand = new Band("Radiohead");
            Band secondBand = new Band("Radiohead");

            Assert.Equal(firstBand, secondBand);
        }

        [Fact]
        public void Save_ReturnsBandName_name()
        {
            Band newBand = new Band("Radiohead");
            newBand.Save();

            List<Band> expected = new List<Band>{newBand};
            List<Band> result = Band.GetAll();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Find_ReturnsFoundBand_name()
        {
            Band newBand = new Band("Radiohead");
            newBand.Save();

            Band foundBand = Band.Find(newBand.GetId());

            Assert.Equal(newBand, foundBand);
        }

        [Fact]
        public void Test_AddVenue_AddsVenueToBand()
        {
            //Arrange
            Venue testVenue = new Venue("Gorge");
            testVenue.Save();

            Band testBand = new Band("Radiohead");
            testBand.Save();

            //Act
            testVenue.AddBand(testBand);

            List<Venue> result = testBand.GetVenues();
            List<Venue> testList = new List<Venue>{testVenue};

            //Assert
            Assert.Equal(testList, result);
        }


        public void Dispose()
        {
            Band.DeleteAll();
            Venue.DeleteAll();
        }
    }
}
