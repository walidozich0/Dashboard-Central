﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 21-05-2025 19:15:12
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace BD.BloodTransfusionCenter.Core
{
    public partial class BloodInventory : EntityBase<Guid>, IAggregateRoot {

        public BloodInventory()
        {
            OnCreated();
        }

        public Guid Id { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public BloodDonationType BloodDonationType { get; set; }

        public int? TotalQty { get; set; }

        public int? MinQty { get; set; }

        public int? MaxQty { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
