﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 22-05-2025 15:16:14
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace BD.BloodTransfusionCenter.Core
{

    public partial class WilayaDTO
    {
        #region Constructors

        public WilayaDTO() {
        }

        public WilayaDTO(int id, string name, List<int> communes, List<System.Guid> bloodTansfusionCenters) {

          this.Id = id;
          this.Name = name;
          this.Communes = communes;
          this.BloodTansfusionCenters = bloodTansfusionCenters;
        }

        #endregion

        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Navigation Properties

        public List<int> Communes { get; set; }

        public List<System.Guid> BloodTansfusionCenters { get; set; }

        #endregion
    }

}
