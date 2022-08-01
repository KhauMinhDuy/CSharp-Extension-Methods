using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Tests
{
    public class ConfigurationTests
    {
        [Test]
        public void IsLoaded()
        {
            IConfiguration configuration = null;
            Assert.IsFalse(configuration.IsLoaded());
        }

        [Test]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProvider().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        }
    }
}
