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

        public void Dispose()
        {
            // Band.DeleteAll();
        }
    }
}
