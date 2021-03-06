﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


namespace ChordsTest.Profiling
{
    [TestClass]
    public class LongAudioProfilingTest
    {
        [TestMethod]
        public void GetNumberOfSamplesGivenWindowInMs_GetsTheSampleSizeCorrectly()
        {
            Assert.AreEqual(
                Chords.Profiling.LongAudioProfiling
                    .GetNumberOfSamplesGivenWindowInMs(44100, 1000),
                44100
            );

            Assert.AreEqual(
                Chords.Profiling.LongAudioProfiling
                    .GetNumberOfSamplesGivenWindowInMs(44100, 500),
                22050
            );

            Assert.AreEqual(
                Chords.Profiling.LongAudioProfiling
                    .GetNumberOfSamplesGivenWindowInMs(44100, 200),
                8820
            );

            Assert.AreEqual(
               Chords.Profiling.LongAudioProfiling
                   .GetNumberOfSamplesGivenWindowInMs(44100, 333),
               14685
           );
        }

        [TestMethod]
        public void GetPrediction_GetsTheCorrectPrediction()
        {
            var predictions = Chords.Profiling.LongAudioProfiling.GetPrediction("resources/about.wav");
            Assert.IsNotNull(predictions);
            Assert.IsTrue(predictions.Contains("G"));
            Assert.IsTrue(predictions.Contains("Em"));
        }
    }
}
