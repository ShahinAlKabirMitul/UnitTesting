﻿using System;

using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User() {IsAdmin = true});
            //Assert
            Assert.That(result, Is.True);
            
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ResturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation() {MadeBy = user};
            var result = reservation.CanBeCancelledBy(user);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ResturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(user);
            Assert.That(result, Is.False);
        }
    }
}
