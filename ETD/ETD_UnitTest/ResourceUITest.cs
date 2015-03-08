﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ETD.Models;
using ETD.ViewsPresenters.MapSection;
using ETD.ViewsPresenters.MapSection.PinManagement;
using ETD.ViewsPresenters;
using ETD.Models.Objects;
using ETD.Models.Grids;
namespace ETD_UnitTest
{
    [TestClass]
    public class ResourceUITest
    {
        [TestMethod]
        public void testLabelName()
        {
            Random randomName = new Random();
            MainWindow mw = new MainWindow();
            MapSectionPage mapSection = new MapSectionPage(mw);
            int teamSize = 3;
            Team b = new Team("Bob");
            DateTime departure = new DateTime(2014, 11, 20);
            TeamMember MemberA = new TeamMember("John", Trainings.firstResponder, departure);
            TeamMember MemberB = new TeamMember("Alex", Trainings.firstAid, departure);
            b.addMember(MemberA);
            b.addMember(MemberB);           
            TeamGrid tg = new TeamGrid(b, mapSection, teamSize);
            Assert.AreEqual(tg.Name, b.getName());
        }        
    }
}