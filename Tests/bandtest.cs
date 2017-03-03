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


        public void Dispose()
        {
            Band.DeleteAll();
        }
    }
}
