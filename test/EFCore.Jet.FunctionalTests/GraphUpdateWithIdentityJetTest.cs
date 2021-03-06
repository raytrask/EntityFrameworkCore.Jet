﻿using Xunit;

namespace EntityFramework.Jet.FunctionalTests
{
    public class GraphUpdatesWithIdentityJetTest : GraphUpdatesJetTestBase<GraphUpdatesWithIdentityJetTest.GraphUpdatesWithIdentityJetFixture>
    {
        public GraphUpdatesWithIdentityJetTest(GraphUpdatesWithIdentityJetFixture fixture)
            : base(fixture)
        {
        }

        public class GraphUpdatesWithIdentityJetFixture : GraphUpdatesJetFixtureBase
        {
            protected override string DatabaseName => "GraphIdentityUpdatesTest";
        }

        [Theory(Skip = "Unsupported by JET: JET behaviour requires that both columns in a composite foreign key are null")]
        public override void Reparent_to_different_one_to_many(ChangeMechanism changeMechanism, bool useExistingParent)
        {
            base.Reparent_to_different_one_to_many(changeMechanism, useExistingParent);
        }

        [Theory(Skip = "Unsupported by JET: JET behaviour requires that both columns in a composite foreign key are null")]
        public override void Optional_many_to_one_dependents_with_alternate_key_are_orphaned() { }
        [Theory(Skip = "Unsupported by JET: JET behaviour requires that both columns in a composite foreign key are null")]
        public override void Optional_one_to_one_with_alternate_key_are_orphaned() { }
        [Theory(Skip = "Unsupported by JET: JET behaviour requires that both columns in a composite foreign key are null")]
        public override void Save_optional_many_to_one_dependents_with_alternate_key(ChangeMechanism changeMechanism, bool useExistingEntities) { }
        [Theory(Skip = "Unsupported by JET: JET behaviour requires that both columns in a composite foreign key are null")]
        public override void Save_removed_optional_many_to_one_dependents_with_alternate_key(ChangeMechanism changeMechanism) { }


        [Theory(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Save_required_one_to_one_changed_by_reference(ChangeMechanism changeMechanism) { }

        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_many_to_one_dependents_are_cascade_deleted_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_many_to_one_dependents_with_alternate_key_are_cascade_deleted_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_many_to_one_dependents_with_alternate_key_are_cascade_deleted_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_non_PK_one_to_one_are_cascade_deleted_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_non_PK_one_to_one_are_cascade_deleted_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_non_PK_one_to_one_with_alternate_key_are_cascade_deleted_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_non_PK_one_to_one_with_alternate_key_are_cascade_deleted_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_one_to_one_are_cascade_deleted_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_one_to_one_are_cascade_deleted_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_one_to_one_with_alternate_key_are_cascade_deleted_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Required_one_to_one_with_alternate_key_are_cascade_deleted_starting_detached() { }

        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_many_to_one_dependents_are_orphaned_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_many_to_one_dependents_are_orphaned_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_many_to_one_dependents_with_alternate_key_are_orphaned_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_many_to_one_dependents_with_alternate_key_are_orphaned_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_one_to_one_are_orphaned_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_one_to_one_are_orphaned_starting_detached() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_one_to_one_with_alternate_key_are_orphaned_in_store() { }
        [Fact(Skip = "Unsupported by JET: OleDB does not support parallel transactions")]
        public override void Optional_one_to_one_with_alternate_key_are_orphaned_starting_detached() { }
    }
}
