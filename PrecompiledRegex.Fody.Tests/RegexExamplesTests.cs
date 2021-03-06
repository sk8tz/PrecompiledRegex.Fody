﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrecompiledRegex.Fody.Tests
{
    [TestClass]
    public class RegexExamplesTests
    {
        [TestMethod]
        public void TestRegexObjectNoOptions() => GetExamples().TestRegexObjectNoOptions();

        [TestMethod]
        public void TestRegexObjectWithOptions() => GetExamples().TestRegexObjectWithOptions();

        [TestMethod]
        public void TestRegexObjectWithOptionsAndTimeout() => GetExamples().TestRegexObjectWithOptionsAndTimeout();

        [TestMethod]
        public void TestRegexIdentity() => GetExamples().TestRegexIdentity();

        [TestMethod]
        public void TestStaticIsMatch() => GetExamples().TestStaticIsMatch();

        [TestMethod]
        public void TestStaticMatch() => GetExamples().TestStaticMatch();

        [TestMethod]
        public void TestStaticMatches() => GetExamples().TestStaticMatches();

        [TestMethod]
        public void TestStaticSplit() => GetExamples().TestStaticSplit();

        [TestMethod]
        public void TestStaticReplace() => GetExamples().TestStaticReplace();

        [TestMethod]
        public void TestInitializers() => GetExamples().TestInitializers();

        [TestMethod]
        public void TestStaticInitializer() => GetExamples().TestStaticInitializer();

        [TestMethod]
        public void TestConsts() => GetExamples().TestConsts();

        [TestMethod]
        public void TestTimeouts() => GetExamples().TestTimeouts();

        [TestMethod]
        public void TestComplexPattern() => GetExamples().TestComplexPattern();

        [TestMethod]
        public void TestCapturing() => GetExamples().TestCapturing();

        [TestMethod]
        public void TestPerformance() => GetExamples().TestPerformance();

        private static dynamic GetExamples() => Activator.CreateInstance(WeaverRunner.DefaultAssembly.GetType("AssemblyToProcess.RegexExamples"));
    }
}
