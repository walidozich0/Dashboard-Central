﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 22-05-2025 07:35:03
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

namespace BD.PublicPortal.Core
{
    public partial class BloodTansfusionCenter : EntityBase<Guid>, IAggregateRoot {

        public BloodTansfusionCenter()
        {
            this.DonorBloodTransferCenterSubscriptions = new List<DonorBloodTransferCenterSubscriptions>();
            this.BloodDonationRequests = new List<BloodDonationRequest>();
            this.BloodInventories = new List<BloodInventory>();
            OnCreated();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public int WilayaId { get; set; }

        public virtual IList<DonorBloodTransferCenterSubscriptions> DonorBloodTransferCenterSubscriptions { get; set; }

        public virtual IList<BloodDonationRequest> BloodDonationRequests { get; set; }

        public virtual Wilaya Wilaya { get; set; }

        public virtual IList<BloodInventory> BloodInventories { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
