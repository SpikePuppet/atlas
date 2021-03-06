﻿// // -----------------------------------------------------------------------
// // <copyright file="DummyEntity.cs">
// //     Copyright 2020 Clint Irving
// //     All rights reserved.
// // </copyright>
// // <author>Clint Irving</author>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Atlas.Model.Attributes;

namespace AtlasTests
{
    public enum Choices
    {
        Undefined,

        Wisely,

        Poorly
    }

    public class DummyEntity
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; }

        public int? Number { get; set; }

        public bool? Off { get; set; }

        public DateTime Start { get; set; }

        public DateTime? Finish { get; set; }

        [DefaultValue(UtcNow = true)] public DateTime? DefaultingDate { get; set; }

        [DefaultValue(Value = "")] public string StringWithDefaultEmptyValue { get; set; }

        [DefaultValue(Value = "Thing")] public string StringWithDefaultValue { get; set; }

        [DefaultValue(Value = "2016-1-30")] public DateTime? DateTimeWithDefaultValue { get; set; }

        [DefaultValue(Value = "23:59:59.9999999")]
        public TimeSpan? TimeSpanWithDefaultValue { get; set; }

        [DefaultValue(Value = "100")] public int? IntWithDefaultValue { get; set; }

        [DefaultValue(Value = "Wisely")] public Choices ChoicesWithDefaultValue { get; set; }

        public Choices Choices { get; set; }

        public Choices? NullableChoices { get; set; }

        public DummyParent DummyParent { get; set; }

        public int DummyParentId { get; set; }

        public virtual List<DummyChild> DummyChildren { get; set; }

        [Filter(AllowPartialStringMatch = true)]
        public string PartialMatchingString { get; set; }

        [Filter(AllowPartialStringMatch = false)]
        public string NotPartialMatchingString { get; set; }

        [FilterExtensions] public DummyFilterExtensions DummyFilterExtensions { get; set; }

        [NotMapped] public string NotMappedProperty { get; set; }
        
        public TimeSpan? TimeOfDay { get; set; }

        public int FilterableInt { get; set; }

        public long FilterableLong { get; set; }

        public string FilterableString { get; set; }

        public int? FilterableNullableInt { get; set; }
    }
}