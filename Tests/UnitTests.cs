using System;
using NUnit.Framework;

namespace GameFrameX.Mono.Tests
{
    internal class UnitTests
    {
        [Test]
        public void TestIsUnixSameDay_SameDay_ReturnsTrue()
        {
            long timestamp1 = 1617842400; // April 7, 2021 12:00:00 AM UTC
            long timestamp2 = 1617896400; // April 7, 2021 12:00:00 PM UTC

            var date1 = DateTimeOffset.FromUnixTimeSeconds(timestamp1).UtcDateTime;
            var date2 = DateTimeOffset.FromUnixTimeSeconds(timestamp2).UtcDateTime;

            Assert.That(date1.Year, Is.EqualTo(date2.Year));
            Assert.That(date1.Month, Is.EqualTo(date2.Month));
            Assert.That(date1.Day, Is.EqualTo(date2.Day));
        }

        [Test]
        public void TestDateTimeAddHoursSameDay()
        {
            var now = DateTime.Now;
            var later = now.AddHours(1);

            Assert.That(later.Year, Is.EqualTo(now.Year));
            Assert.That(later.Month, Is.EqualTo(now.Month));
            Assert.That(later.Day, Is.EqualTo(now.Day));
        }
    }
}