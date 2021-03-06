﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RethinkDb.Driver.Linq.Tests
{
    public class CountTests : BaseLinqTest
    {
        [Test]
        public void Count_GeneratesCorrectReql()
        {
            var data = new List<TestObject>
            {
                new TestObject(),
                new TestObject()
            };

            SpawnData( data );

            var expected = RethinkDB.R.Table( TableName ).Count();

            var result = GetQueryable<TestObject>( TableName, expected ).Count();

            Assert.AreEqual( 2, result );
        }

        [Test]
        public void CountWithFilter_GeneratesCorrectReql()
        {
            var data = new List<TestObject>
            {
                new TestObject
                {
                    Name = "One"
                },
                new TestObject
                {
                    Name = "Two"
                }
            };

            SpawnData( data );

            var expected = RethinkDB.R.Table( TableName ).Filter( x => x["Name"].Eq( "One" ) ).Count();

            var result = GetQueryable<TestObject>( TableName, expected ).Count( x => x.Name == "One" );

            Assert.AreEqual( 1, result );
        }

        [Test]
        public void WhereWithCount_GeneratesCorrectReql()
        {
            var data = new List<TestObject>
            {
                new TestObject
                {
                    Name = "One"
                },
                new TestObject
                {
                    Name = "Two",
                    Values = new List<string>
                    {
                        "One",
                        "Two"
                    }
                }
            };

            SpawnData( data );

            var expected = RethinkDB.R.Table( TableName ).Filter( x => x["Values"].Count().Eq( 2 ) );

            var result = GetQueryable<TestObject>( TableName, expected ).Where( x => x.Values.Count() == 2 ).ToList();

            Assert.AreEqual( 1, result.Count );
        }

        [Test]
        public void WhereWithListCount_GeneratesCorrectReql()
        {
            var data = new List<TestObject>
            {
                new TestObject
                {
                    Name = "One"
                },
                new TestObject
                {
                    Name = "Two",
                    Values = new List<string>
                    {
                        "One",
                        "Two"
                    }
                }
            };

            SpawnData( data );

            var expected = RethinkDB.R.Table( TableName ).Filter( x => x["Values"].Count().Eq( 2 ) );

            var result = GetQueryable<TestObject>( TableName, expected ).Where( x => x.Values.Count == 2 ).ToList();

            Assert.AreEqual( 1, result.Count );
        }

        [Test]
        public void WhereWithCountWithFilter_GeneratesCorrectReql()
        {
            var data = new List<TestObject>
            {
                new TestObject
                {
                    Name = "One"
                },
                new TestObject
                {
                    Name = "Two",
                    Values = new List<string>
                    {
                        "One",
                        "Two"
                    }
                }
            };

            SpawnData( data );

            var expected = RethinkDB.R.Table( TableName ).Filter( x => x["Values"].Filter( v => v.Eq( "One" ) ).Count().Eq( 1 ) );

            var result = GetQueryable<TestObject>( TableName, expected ).Where( x => x.Values.Count( v => v == "One" ) == 1 ).ToList();

            Assert.AreEqual( 1, result.Count );
        }

        public class TestObject
        {
            public string Name { get; set; }
            public List<string> Values { get; set; }
        }
    }
}
