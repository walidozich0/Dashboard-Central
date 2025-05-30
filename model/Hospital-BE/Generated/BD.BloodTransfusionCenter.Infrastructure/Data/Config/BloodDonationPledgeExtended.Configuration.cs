﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 22-05-2025 15:16:13
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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BD.BloodTransfusionCenter.Core
{
    /// <summary>
    /// There are no comments for BloodDonationPledgeExtendedConfiguration in the schema.
    /// </summary>
    public partial class BloodDonationPledgeExtendedConfiguration : IEntityTypeConfiguration<BloodDonationPledgeExtended>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<BloodDonationPledgeExtended> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<BloodDonationPledgeExtended> builder)
        {
            builder.ToTable(@"BloodDonationPledgeExtendeds");
            builder.Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.EvolutionStatus).HasColumnName(@"EvolutionStatus").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PledgeInitiatedDate).HasColumnName(@"PledgeInitiatedDate").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PledgeEffectiveDate).HasColumnName(@"PledgeEffectiveDate").ValueGeneratedNever();
            builder.Property(x => x.PledgeHonoredOrCanceledDate).HasColumnName(@"PledgeHonoredOrCanceledDate").ValueGeneratedNever();
            builder.Property(x => x.CantBeDoneReason).HasColumnName(@"CantBeDoneReason").ValueGeneratedNever();
            builder.Property(x => x.DonorId).HasColumnName(@"DonorId").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorName).HasColumnName(@"DonorName").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorBirthDate).HasColumnName(@"DonorBirthDate").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorBloodGroup).HasColumnName(@"DonorBloodGroup").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorNIN).HasColumnName(@"DonorNIN").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorTel).HasColumnName(@"DonorTel").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorEmail).HasColumnName(@"DonorEmail").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DonorNotes).HasColumnName(@"DonorNotes").ValueGeneratedNever();
            builder.Property(x => x.DonorLastDonationDate).HasColumnName(@"DonorLastDonationDate").ValueGeneratedNever();
            builder.Property(x => x.BloodDonationRequestId).HasColumnName(@"BloodDonationRequestId").ValueGeneratedNever();
            builder.HasKey(@"Id");
            builder.HasOne(x => x.BloodDonationRequest).WithMany(op => op.BloodDonationPledges).OnDelete(DeleteBehavior.Restrict).HasForeignKey(@"BloodDonationRequestId").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<BloodDonationPledgeExtended> builder);

        #endregion
    }

}
