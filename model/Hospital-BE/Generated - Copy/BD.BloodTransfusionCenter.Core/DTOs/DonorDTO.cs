﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 21-05-2025 19:15:12
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace BD.BloodTransfusionCenter.Core
{

    public partial class DonorDTO
    {
        #region Constructors

        public DonorDTO() {
        }

        public DonorDTO(System.Guid id, System.Guid? correlationId, string name, System.DateTime birthDate, BloodGroup bloodGroup, string nIN, string tel, string email, string notesForBTC, System.DateTime? lastDonationDate, int communeId, List<BloodDonationDTO> bloodDonations, CommuneDTO commune) {

          this.Id = id;
          this.CorrelationId = correlationId;
          this.Name = name;
          this.BirthDate = birthDate;
          this.BloodGroup = bloodGroup;
          this.NIN = nIN;
          this.Tel = tel;
          this.Email = email;
          this.NotesForBTC = notesForBTC;
          this.LastDonationDate = lastDonationDate;
          this.CommuneId = communeId;
          this.BloodDonations = bloodDonations;
          this.Commune = commune;
        }

        #endregion

        #region Properties

        public System.Guid Id { get; set; }

        public System.Guid? CorrelationId { get; set; }

        public string Name { get; set; }

        public System.DateTime BirthDate { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public string NIN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string NotesForBTC { get; set; }

        public System.DateTime? LastDonationDate { get; set; }

        public int CommuneId { get; set; }

        #endregion

        #region Navigation Properties

        public List<BloodDonationDTO> BloodDonations { get; set; }

        public CommuneDTO Commune { get; set; }

        #endregion
    }

}
