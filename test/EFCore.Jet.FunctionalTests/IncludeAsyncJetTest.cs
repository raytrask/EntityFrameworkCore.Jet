﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;

namespace EntityFramework.Jet.FunctionalTests
{
    public class IncludeAsyncJetTest : IncludeAsyncTestBase<NorthwindQueryJetFixture>
    {
        public IncludeAsyncJetTest(NorthwindQueryJetFixture fixture)
            : base(fixture)
        {
        }


        [Theory(Skip = "Unsupported by JET: SKIP TAKE is supported only in outer queries")]
        public override Task Include_duplicate_collection()
        {
            return Task.CompletedTask;
        }

        [Theory(Skip = "Unsupported by JET: SKIP TAKE is supported only in outer queries")]
        public override Task Include_duplicate_collection_result_operator()
        {
            return Task.CompletedTask;
        }

        [Theory(Skip = "Unsupported by JET: SKIP TAKE is supported only in outer queries")]
        public override Task Include_duplicate_collection_result_operator2()
        {
            return Task.CompletedTask;
        }

        [Theory(Skip = "Unsupported by JET: CROSS JOIN and OTHER JOIN")]
        public override Task Include_duplicate_reference()
        {
            return Task.CompletedTask;
        }

        [Theory(Skip = "Unsupported by JET: CROSS JOIN and OTHER JOIN")]
        public override Task Include_duplicate_reference2()
        {
            return Task.CompletedTask;
        }

        [Theory(Skip = "Unsupported by JET: CROSS JOIN and OTHER JOIN")]
        public override Task Include_duplicate_reference3()
        { return Task.CompletedTask; }
    }
}


