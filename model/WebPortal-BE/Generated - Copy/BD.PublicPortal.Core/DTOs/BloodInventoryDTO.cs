﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 22-05-2025 07:35:03
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace BD.PublicPortal.Core
{

    public partial class BloodInventoryDTO
    {
        #region Constructors

        public BloodInventoryDTO() {
        }

        public BloodInventoryDTO(System.Guid id, System.Guid bloodTansfusionCenterId, BloodGroup bloodGroup, BloodDonationType bloodDonationType, int? totalQty, int? minQty, int? maxQty, BloodTansfusionCenterDTO bloodTansfusionCenter) {

          this.Id = id;
          this.BloodTansfusionCenterId = bloodTansfusionCenterId;
          this.BloodGroup = bloodGroup;
          this.BloodDonationType = bloodDonationType;
          this.TotalQty = totalQty;
          this.MinQty = minQty;
          this.MaxQty = maxQty;
          this.BloodTansfusionCenter = bloodTansfusionCenter;
        }

        #endregion

        #region Properties

        public System.Guid Id { get; set; }

        public System.Guid BloodTansfusionCenterId { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public BloodDonationType BloodDonationType { get; set; }

        public int? TotalQty { get; set; }

        public int? MinQty { get; set; }

        public int? MaxQty { get; set; }

        #endregion

        #region Navigation Properties

        public BloodTansfusionCenterDTO BloodTansfusionCenter { get; set; }

        #endregion
    }

}
