﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 24-05-2025 09:37:07
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
    public partial class ApplicationUser : IdentityUser<Guid>, IAggregateRoot {

        public ApplicationUser()
        {
            this.DonorBloodTransferCenterSubscriptions = new List<DonorBloodTransferCenterSubscriptions>();
            this.BloodDonationPledges = new List<BloodDonationPledge>();
            OnCreated();
        }

        public Guid Id { get; set; }

        public Guid? DonorCorrelationId { get; set; }

        public bool? DonorWantToStayAnonymous { get; set; }

        public bool? DonorExcludeFromPublicPortal { get; set; }

        public DonorAvailability? DonorAvailability { get; set; }

        public DonorContactMethod? DonorContactMethod { get; set; }

        public string DonorName { get; set; }

        public DateTime DonorBirthDate { get; set; }

        public BloodGroup DonorBloodGroup { get; set; }

        public string DonorNIN { get; set; }

        public string DonorTel { get; set; }

        public string DonorNotesForBTC { get; set; }

        public DateTime? DonorLastDonationDate { get; set; }

        public int? CommuneId { get; set; }

        public virtual IList<DonorBloodTransferCenterSubscriptions> DonorBloodTransferCenterSubscriptions { get; set; }

        public virtual IList<BloodDonationPledge> BloodDonationPledges { get; set; }

        public virtual Commune Commune { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
